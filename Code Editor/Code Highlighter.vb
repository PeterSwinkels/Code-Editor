﻿'This module's settings:
Option Compare Binary
Option Explicit On
Option Infer Off
Option Strict On

Imports System
Imports System.Collections.Generic
Imports System.Environment
Imports System.IO
Imports System.Windows.Forms
Imports System.Xml

'This module contains the code highlighting procedures.
Public Module CodeHighlighterModule
   'This structure defines a code highlighting template.
   Public Structure TemplateStr
      Public CaseSensitive As Boolean           'Indicates whether the code is case sensitive.
      Public CommentEnd As List(Of String)      'Defines the end of comment markers.
      Public CommentStart As List(Of String)    'Defines the start of comment markers.
      Public Delimiters As String               'Defines the characters that delimit keywords.
      Public EscapedStrings As Boolean          'Indicates whether escaped strings are supported.
      Public Keywords As List(Of String)        'Defines the list of keywords.
      Public Language As String                 'Defines the name of the language defined.
      Public StringLiterals As List(Of String)  'Defines the string literal markers.
   End Structure

   'This procedure returns a blank code highlighting template.
   Public Function BlankTemplate() As TemplateStr
      Try
         Dim NewTemplate As New TemplateStr

         With NewTemplate
            .CaseSensitive = False
            .CommentEnd = New List(Of String)
            .CommentStart = New List(Of String)
            .Delimiters = ""
            .KeyWords = New List(Of String)
            .Language = Nothing
            .StringLiterals = New List(Of String)
         End With

         Return NewTemplate
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try

      Return Nothing
   End Function

   'This procedure creates and returns an empty code highlighting template.
   Public Function CreateTemplate() As String
      Try
         Dim TemplatePath As String = Nothing

         If AskSaveIfModified() = DialogResult.Yes Then
            SaveDocument(InterfaceWindow.TextBox.Text, NoDialog:=True)
         Else
            DocumentO.Modified = False
         End If

         With New SaveFileDialog
            .FileName = Nothing
            .Filter = "XML files (*.xml)|*.xml"
            .InitialDirectory = Path.GetDirectoryName(Locations().SettingsPath)
            .Title = "Create highlighting template:"
            .ShowDialog()
            TemplatePath = .FileName
         End With

         If Not TemplatePath = Nothing Then
            Using TemplateFile As XmlWriter = XmlWriter.Create(TemplatePath, New XmlWriterSettings With {.Indent = True, .IndentChars = " ", .NewLineChars = NewLine})
               With TemplateFile
                  .WriteStartElement("Code")
                  .WriteElementString("Language", NewLine)
                  .WriteElementString("CaseSensitive", CStr(False))
                  .WriteElementString("Delimiters", NewLine)
                  .WriteElementString("EscapedStrings", CStr(False))
                  .WriteElementString("CommentEnd", NewLine)
                  .WriteElementString("CommentStart", NewLine)
                  .WriteElementString("Keywords", NewLine)
                  .WriteElementString("StringLiterals", NewLine)
                  .Close()
               End With
            End Using

            DocumentO.PathO = TemplatePath

            Return LoadDocument(NoDialog:=True)
         End If
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try

      Return Nothing
   End Function

   'This procedure searches the specified code for the specified items.
   Private Function GetIndex(SearchList As List(Of String), Code As String, CompareMethod As StringComparison, Optional Delimiters As String = Nothing, Optional IsKeyword As Boolean = False) As Integer?
      Try
         For Index As Integer = 0 To SearchList.Count - 1
            If Code.StartsWith(SearchList(Index), CompareMethod) Then
               If IsKeyword Then
                  If Code.Length = SearchList(Index).Length OrElse Delimiters.Contains(Code.Chars(SearchList(Index).Length)) Then
                     Return Index
                  End If
               Else
                  Return Index
               End If
            End If
         Next Index

         Return Nothing
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try

      Return Nothing
   End Function

   'This procedure parses the specified code and gives the command to highlight sections using the specicifed template.
   Public Sub HighlightCode(Target As RichTextBox, Template As TemplateStr)
      Try
         Dim Buffer As New RichTextBox With {.Font = Target.Font, .Rtf = Target.Rtf, .Text = Target.Text}
         Dim CommentStart As New Integer?
         Dim CompareMethod As StringComparison = If(Template.CaseSensitive, StringComparison.CurrentCulture, StringComparison.CurrentCultureIgnoreCase)
         Dim CurrentModifiedState As Boolean = DocumentO.Modified
         Dim CurrentSelection As Integer = Target.SelectionStart
         Dim Fragment As String = Nothing
         Dim Keyword As New Integer?
         Dim NextFragment As String = Nothing
         Dim Offset As Integer = 0
         Dim Position As Integer = 0
         Dim PreviousCharacter As Char = Nothing
         Dim StringLiteral As New Integer?

         With Buffer
            Target.Parent.UseWaitCursor = True
            My.Application.DoEvents()

            .SelectAll()
            .SelectionColor = Settings.ForegroundColor
            .DeselectAll()

            Do While Position < .Text.Length
               If CommentStart Is Nothing Then
                  If StringLiteral Is Nothing Then
                     StringLiteral = GetIndex(Template.StringLiterals, .Text.Substring(Position), CompareMethod)
                     If StringLiteral IsNot Nothing Then Offset = Position
                  Else
                     If .Text.Substring(Position).StartsWith(Template.StringLiterals(StringLiteral.Value), CompareMethod) Then
                        Fragment = Template.StringLiterals(StringLiteral.Value)

                        If Not (Template.EscapedStrings AndAlso Position < .Text.Length - (Fragment.Length * 2) - 1 AndAlso .Text.Substring(Position + Fragment.Length, Fragment.Length) = Fragment) Then
                           .Select(Offset, (Position - Offset) + 1)
                           .SelectionColor = Settings.StringColor
                           StringLiteral = Nothing
                           Offset = 0
                           PreviousCharacter = Nothing
                        End If

                        Position += Fragment.Length
                     End If
                  End If
               End If

               If Position < .Text.Length Then
                  If StringLiteral Is Nothing Then
                     If CommentStart Is Nothing Then
                        CommentStart = GetIndex(Template.CommentStart, .Text.Substring(Position), CompareMethod)
                        If CommentStart IsNot Nothing Then Offset = Position
                     Else
                        If .Text.Substring(Position).StartsWith(Template.CommentEnd(CommentStart.Value), CompareMethod) Then
                           Fragment = Template.CommentEnd(CommentStart.Value)
                           .Select(Offset, (Position - Offset) + 1)
                           .SelectionColor = Settings.CommentColor
                           CommentStart = Nothing
                           Offset = 0
                           PreviousCharacter = Nothing
                           Position += Fragment.Length
                        End If
                     End If
                  End If

                  If CommentStart Is Nothing AndAlso StringLiteral Is Nothing Then
                     Keyword = GetIndex(Template.KeyWords, .Text.Substring(Position), CompareMethod, Template.Delimiters, IsKeyword:=True)
                     If Keyword IsNot Nothing Then
                        If PreviousCharacter = Nothing OrElse Not Char.IsLetterOrDigit(PreviousCharacter) Then
                           Fragment = Template.KeyWords(Keyword.Value)
                           .Select(Position, Fragment.Length)
                           .SelectionColor = Settings.KeyWordColor
                           Position += Fragment.Length
                        End If
                     End If
                  End If
               End If

               If Position < .Text.Length Then PreviousCharacter = .Text.Chars(Position)
               Position += 1
            Loop

            If CommentStart IsNot Nothing Then
               .Select(Offset, .Text.Length - Offset)
               .SelectionColor = Settings.CommentColor
               CommentStart = Nothing
            End If

            Target.Text = .Text
            Target.Rtf = .Rtf
            Target.Select(CurrentSelection, 0)
            Target.SelectionColor = Settings.ForegroundColor
            Target.Parent.UseWaitCursor = False

            DocumentO.Modified = CurrentModifiedState
         End With
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      Finally
         Target.Parent.UseWaitCursor = False
      End Try
   End Sub

   'This procedure loads and returns a code highlighting template.
   Public Function LoadTemplate(Optional TemplatePath As String = Nothing) As TemplateStr
      Try
         Dim NewTemplate As TemplateStr = BlankTemplate()

         If TemplatePath = Nothing Then
            With New OpenFileDialog
               .FileName = Nothing
               .Filter = "XML files (*.xml)|*.xml"
               .Title = "Open highlighting template:"
               .ShowDialog()
               TemplatePath = .FileName
            End With
         End If

         If Not TemplatePath = Nothing Then
            Using TemplateFile As XmlReader = XmlReader.Create(TemplatePath, New XmlReaderSettings)
               With TemplateFile
                  .ReadStartElement("Code")
                  NewTemplate.Language = .ReadElementString("Language")
                  NewTemplate.CaseSensitive = CBool(.ReadElementString("CaseSensitive"))
                  NewTemplate.Delimiters = .ReadElementString("Delimiters")
                  NewTemplate.EscapedStrings = CBool(.ReadElementString("EscapedStrings"))

                  Do Until .EOF
                     .Read()
                     Select Case .NodeType
                        Case XmlNodeType.Element
                           Select Case .Name
                              Case "CommentEnd"
                                 NewTemplate.CommentEnd.Add(.ReadElementString)
                              Case "CommentStart"
                                 NewTemplate.CommentStart.Add(.ReadElementString)
                              Case "KeyWords"
                                 NewTemplate.KeyWords.AddRange(.ReadElementString.Split(NewLine.ToCharArray))
                              Case "StringLiterals"
                                 NewTemplate.StringLiterals.Add(.ReadElementString)
                              Case Else
                                 MessageBox.Show($"Unknown element ""{ .Name}"".", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                           End Select
                     End Select
                  Loop
                  .Close()
               End With
            End Using
         End If

         Return NewTemplate
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try

      Return Nothing
   End Function
End Module
