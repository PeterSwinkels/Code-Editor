'This module's settings:
Option Compare Binary
Option Explicit On
Option Infer Off
Option Strict On

Imports System
Imports System.Convert
Imports System.Diagnostics
Imports System.Diagnostics.FileVersionInfo
Imports System.Drawing
Imports System.Environment
Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports System.Text
Imports System.Windows.Forms
Imports System.Xml

'This module contains this program's core procedures.
Public Module CoreModule
   Public Const DOCUMENT_PATH As String = "%%"                    'Defines the place holder for the current document's path in an external program's arguments.
   Public Const DOCUMENT_PATH_WITHOUT_EXTENSION As String = "%"   'Defines the place holder for the current document's path without extension in an external program's arguments.

   'This structure defines the current document.
   Public Structure DocumentStr
      Public Modified As Boolean   'Indicates whether the currents document has been modified but not saved.
      Public PathO As String       'Defines the current document's path.
   End Structure

   'This structure defines the paths used by this program.
   Public Structure LocationsStr
      Public ProgramPath As String    'Defines the path of this program's executable.
      Public SettingsPath As String   'Defines the path of this program's settings file.
   End Structure

   'This structure defines the settings used by this program.
   Public Structure SettingsStr
      Public BackgroundColor As Color            'Defines the document text's background color.
      Public CaptureOutput As Boolean            'Indicates whether an external program's output is captured.
      Public CommentColor As Color               'Defines the color used to highligth comments.
      Public DocumentFont As Font                'Defines the font used to display documents.
      Public ExternalArguments As String         'Defines the arguments passed to an external program.
      Public ExternalProgram As String           'Defines the path of an external program to open the current document with.
      Public ForegroundColor As Color            'Defines the document text's foreground color.
      Public Indentation As Integer              'Defines the number of spaces to be used for indenting text.
      Public InterfacePosition As Point          'Defines the interface window's position.
      Public InterfaceSize As Size               'Defines the interface window's size.
      Public InterfaceState As FormWindowState   'Defines the interface window's state.
      Public KeywordColor As Color               'Defines the color used to highlight keywords.
      Public ShowErrors As Boolean               'Indicates whether the external program error pane is visible.
      Public ShowErrorsHeight As Integer         'Defines the external program's error pane height.
      Public ShowOutput As Boolean               'Indicates whether the external program output pane is visible.
      Public ShowOutputHeight As Integer         'Defines the external program's output pane height.
      Public StringColor As Color                'Defines the color used to highlight string literals.
   End Structure

   'The variables used by this module:
   Public DocumentO As New DocumentStr With {.Modified = False, .PathO = Nothing}  'Defines the current document.
   Public HighlightingTemplate As TemplateStr = BlankTemplate()                    'Defines the current code highlighting template.
   Public Settings As SettingsStr = DefaultSettings()                              'Defines the settings used by this program.

   'This procedure asks the user if the current document should be saved if it has been modified and returns the user's choice.
   Public Function AskSaveIfModified() As DialogResult
      Try
         If DocumentO.Modified Then Return MessageBox.Show("This document has been modified since it was last saved. Save now?", My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try

      Return Nothing
   End Function

   'This procedure returns this program's default settings.
   Public Function DefaultSettings() As SettingsStr
      Try
         Dim NewSettings As New SettingsStr

         With NewSettings
            .BackgroundColor = Color.White
            .CaptureOutput = False
            .CommentColor = Color.Green
            .DocumentFont = New Font("Lucida Console", emSize:=12, style:=FontStyle.Regular)
            .ExternalArguments = $"""{DOCUMENT_PATH}"""
            .ExternalProgram = Nothing
            .ForegroundColor = Color.Black
            .Indentation = 0
            .InterfaceSize = New Size(CInt(Screen.PrimaryScreen.WorkingArea.Width / 1.5), CInt(Screen.PrimaryScreen.WorkingArea.Height / 1.5))
            .InterfacePosition = New Point(CInt(Screen.PrimaryScreen.WorkingArea.Width / 2) - CInt(.InterfaceSize.Width / 2), CInt(Screen.PrimaryScreen.WorkingArea.Height / 2) - CInt(.InterfaceSize.Height / 2))
            .InterfaceState = FormWindowState.Normal
            .ShowOutputHeight = CInt(InterfaceWindow.TextBox.Height / 1.1)
            .ShowErrorsHeight = .ShowOutputHeight
            .KeyWordColor = Color.Blue
            .ShowErrors = False
            .ShowOutput = False
            .StringColor = Color.DarkRed
         End With

         Return NewSettings
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try

      Return Nothing
   End Function

   'This procedure handles any errors that occur.
   Public Sub HandleError(ExceptionO As Exception)
      Try
         MessageBox.Show(ExceptionO.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Catch
         [Exit](0)
      End Try
   End Sub

   'This procedure indents the specified text.
   Public Sub Indent(TextBox As RichTextBox, Optional Unindent As Boolean = False)
      Try
         Dim NewText As New StringBuilder
         Dim SelectionLength As Integer = TextBox.SelectionLength
         Dim SelectionStart As Integer = TextBox.SelectionStart
         Dim Spaces As New String(" "c, Settings.Indentation)

         For Each Line As String In TextBox.SelectedText.Split(NewLine.ToCharArray())
            If Unindent Then
               If Line.StartsWith(Spaces) Then Line = Line.Substring(Settings.Indentation)
               NewText.Append(Line)
            Else
               NewText.Append($"{Spaces}{Line}")
            End If
            NewText.Append(NewLine)

            SelectionLength += If(Unindent, -Settings.Indentation, Settings.Indentation)
         Next Line

         TextBox.SelectedText = NewText.ToString().Substring(0, NewText.Length - NewLine.Length)
         TextBox.Select(SelectionStart, SelectionLength)
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure opens the current document with an external program 
   Public Sub LaunchExternalProgram()
      Try
         If DocumentO.PathO = Nothing Then
            MessageBox.Show("The document needs to be saved first.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
         ElseIf Not Settings.ExternalProgram = Nothing Then
            With New Process
               With .StartInfo
                  .Arguments = Settings.ExternalArguments
                  .Arguments = .Arguments.Replace(DOCUMENT_PATH, DocumentO.PathO)
                  If .Arguments.Contains(DOCUMENT_PATH_WITHOUT_EXTENSION) Then .Arguments = .Arguments.Replace(DOCUMENT_PATH_WITHOUT_EXTENSION, Path.Combine(Path.GetDirectoryName(DocumentO.PathO), Path.GetFileNameWithoutExtension(DocumentO.PathO)))

                  .FileName = Settings.ExternalProgram
                  .UseShellExecute = False

                  .CreateNoWindow = Settings.CaptureOutput
                  .RedirectStandardError = .CreateNoWindow
                  .RedirectStandardOutput = .CreateNoWindow
               End With

               .Start()

               If .StartInfo.CreateNoWindow Then
                  .WaitForExit()
                  InterfaceWindow.ErrorBox.Text = .StandardError.ReadToEnd
                  InterfaceWindow.OutputBox.Text = .StandardOutput.ReadToEnd
               End If
            End With
         End If
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure loads the settings from the settings file.
   Public Function LoadSettings(SettingsPath As String) As SettingsStr
      Try
         Dim NewSettings As New SettingsStr

         Using SettingsFile As XmlReader = XmlReader.Create(SettingsPath)
            With SettingsFile
               .ReadStartElement("Settings")

               .ReadStartElement("ExternalProgram")
               NewSettings.CaptureOutput = CBool(.ReadElementString("CaptureOutput"))
               NewSettings.ExternalProgram = .ReadElementString("Path")
               NewSettings.ExternalArguments = .ReadElementString("Arguments")
               NewSettings.ShowErrors = CBool(.ReadElementString("ShowErrors"))
               NewSettings.ShowErrorsHeight = CInt(.ReadElementString("ShowErrorsHeight"))
               NewSettings.ShowOutput = CBool(.ReadElementString("ShowOutput"))
               NewSettings.ShowOutputHeight = CInt(.ReadElementString("ShowOutputHeight"))
               .ReadEndElement()

               .ReadStartElement("Font")
               NewSettings.BackgroundColor = Color.FromArgb(ToInt32(.ReadElementString("BackgroundColor"), fromBase:=16))
               NewSettings.ForegroundColor = Color.FromArgb(ToInt32(.ReadElementString("ForegroundColor"), fromBase:=16))
               NewSettings.DocumentFont = New Font(.ReadElementString("Name"), CSng(.ReadElementString("Size")), DirectCast(CInt(.ReadElementString("Style")), FontStyle))
               .ReadEndElement()

               .ReadStartElement("Highlighting")
               NewSettings.CommentColor = Color.FromArgb(ToInt32(.ReadElementString("Comments"), fromBase:=16))
               NewSettings.KeyWordColor = Color.FromArgb(ToInt32(.ReadElementString("Keywords"), fromBase:=16))
               NewSettings.StringColor = Color.FromArgb(ToInt32(.ReadElementString("Strings"), fromBase:=16))
               .ReadEndElement()

               .ReadStartElement("Indentation")
               NewSettings.Indentation = CInt(.ReadElementString("Spaces"))
               .ReadEndElement()

               .ReadStartElement("Interface")
               NewSettings.InterfacePosition = New Point(ToInt32(.ReadElementString("X")), ToInt32(.ReadElementString("Y")))
               NewSettings.InterfaceSize = New Size(ToInt32(.ReadElementString("Width")), ToInt32(.ReadElementString("Height")))
               NewSettings.InterfaceState = DirectCast(ToInt32(.ReadElementString("State")), FormWindowState)
               .ReadEndElement()

               .ReadEndElement()
               .Close()
            End With
         End Using

         Return NewSettings
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try

      Return Nothing
   End Function

   'This procedure loads a document and returns its contents.
   Public Function LoadDocument(Optional NoDialog As Boolean = False) As String
      Try
         Dim Choice As New DialogResult

         With New OpenFileDialog
            If Not NoDialog Then
               If Not DocumentO.PathO = Nothing Then
                  .FileName = Path.GetFileName(DocumentO.PathO)
                  .InitialDirectory = Path.GetDirectoryName(DocumentO.PathO)
               End If
               Choice = .ShowDialog()
               If Choice = DialogResult.OK Then DocumentO.PathO = .FileName
            End If

            If Choice = DialogResult.OK OrElse NoDialog Then
               If AskSaveIfModified() = DialogResult.Yes Then SaveDocument(InterfaceWindow.TextBox.Text, NoDialog:=True)
               DocumentO.Modified = False
               InterfaceWindow.ErrorBox.Clear()
               InterfaceWindow.OutputBox.Clear()
            End If
         End With

         Return If(DocumentO.PathO = Nothing, Nothing, File.ReadAllText(DocumentO.PathO))
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try

      Return Nothing
   End Function

   'This procedure returns this program's file locations.
   Public Function Locations() As LocationsStr
      Try
         Static ProgramPath As String = GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileName

         Return New LocationsStr With {.ProgramPath = ProgramPath, .SettingsPath = Path.Combine(Path.GetDirectoryName(ProgramPath), "Settings.xml")}
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try

      Return Nothing
   End Function

   'This procedure gives the command to load a document and update the interface.
   Public Sub OpenDocument(Optional NoDialog As Boolean = False)
      Try
         With InterfaceWindow
            .TextBox.Text = LoadDocument(NoDialog)
            UpdateInterface()
            If Not HighlightingTemplate.Language = Nothing Then HighlightCode(.TextBox, HighlightingTemplate)
            DocumentO.Modified = False
         End With
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure processes the command line arguments.
   Public Sub ProcessCommandLine()
      Try
         If GetCommandLineArgs.Count = 2 Then
            If GetCommandLineArgs.Last = "/?" Then
               MessageBox.Show($"Usage: ""{ Path.GetFileName(Locations().ProgramPath)}"" [document] [highlighting template]", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
               [Exit](0)
            Else
               DocumentO.PathO = GetCommandLineArgs.Last
            End If
         ElseIf GetCommandLineArgs.Count = 3 Then
            DocumentO.PathO = GetCommandLineArgs(1)
            LoadTemplate(GetCommandLineArgs(2))
         End If
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure returns information about this program.
   Public Function ProgramInformation() As String
      Try
         With My.Application.Info
            Return $"{ .Title} v{ .Version} - by: { .CompanyName}"
         End With
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try

      Return Nothing
   End Function

   'This procedure saves the current document.
   Public Sub SaveDocument(Text As String, Optional NoDialog As Boolean = False)
      Try
         Dim Choice As New DialogResult

         With New SaveFileDialog
            If (Not NoDialog) OrElse DocumentO.PathO = Nothing Then
               If Not DocumentO.PathO = Nothing Then
                  .FileName = Path.GetFileName(DocumentO.PathO)
                  .InitialDirectory = Path.GetDirectoryName(DocumentO.PathO)
               End If
               Choice = .ShowDialog()
               If Choice = DialogResult.OK Then DocumentO.PathO = .FileName
            End If

            If Not DocumentO.PathO = Nothing Then
               If Choice = DialogResult.OK OrElse NoDialog Then
                  File.WriteAllText(DocumentO.PathO, Text)
                  DocumentO.Modified = False
               End If
            End If
         End With
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure saves the current settings.
   Public Sub SaveSettings(SettingsPath As String, UnsavedSettings As SettingsStr)
      Try
         Using SettingsFile As XmlWriter = XmlWriter.Create(SettingsPath, New XmlWriterSettings With {.Indent = True, .IndentChars = " "c, .NewLineChars = NewLine})
            With SettingsFile
               .WriteStartDocument()
               .WriteStartElement("Settings")

               .WriteStartElement("ExternalProgram")
               .WriteElementString("CaptureOutput", CStr(UnsavedSettings.CaptureOutput))
               .WriteElementString("Path", UnsavedSettings.ExternalProgram)
               .WriteElementString("Arguments", UnsavedSettings.ExternalArguments)
               .WriteElementString("ShowErrors", CStr(UnsavedSettings.ShowErrors))
               .WriteElementString("ShowErrorsHeight", CStr(UnsavedSettings.ShowErrorsHeight))
               .WriteElementString("ShowOutput", CStr(UnsavedSettings.ShowOutput))
               .WriteElementString("ShowOutputHeight", CStr(UnsavedSettings.ShowOutputHeight))
               .WriteEndElement()

               .WriteStartElement("Font")
               .WriteElementString("BackgroundColor", $"{UnsavedSettings.BackgroundColor.ToArgb:X}")
               .WriteElementString("ForegroundColor", $"{UnsavedSettings.ForegroundColor.ToArgb:X}")
               .WriteElementString("Name", UnsavedSettings.DocumentFont.Name)
               .WriteElementString("Size", CStr(UnsavedSettings.DocumentFont.Size))
               .WriteElementString("Style", CStr(UnsavedSettings.DocumentFont.Style))
               .WriteEndElement()

               .WriteStartElement("Highlighting")
               .WriteElementString("Comments", $"{UnsavedSettings.CommentColor.ToArgb:X}")
               .WriteElementString("Keywords", $"{UnsavedSettings.KeyWordColor.ToArgb:X}")
               .WriteElementString("Strings", $"{UnsavedSettings.StringColor.ToArgb:X}")
               .WriteEndElement()

               .WriteStartElement("Indentation")
               .WriteElementString("Spaces", CStr(UnsavedSettings.Indentation))
               .WriteEndElement()

               .WriteStartElement("Interface")
               .WriteElementString("X", CStr(UnsavedSettings.InterfacePosition.X))
               .WriteElementString("Y", CStr(UnsavedSettings.InterfacePosition.Y))
               .WriteElementString("Width", CStr(UnsavedSettings.InterfaceSize.Width))
               .WriteElementString("Height", CStr(UnsavedSettings.InterfaceSize.Height))
               .WriteElementString("State", CStr(UnsavedSettings.InterfaceState))
               .WriteEndElement()

               .WriteEndElement()
               .WriteEndDocument()
               .Close()
            End With
         End Using
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure returns a color selected by the user.
   Public Function ShowColorDialog(CurrentColor As Color) As Color
      Try
         With New ColorDialog
            .Color = CurrentColor
            .ShowDialog()
            Return .Color
         End With
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try

      Return Nothing
   End Function

   'This procedure displays the input dialog and returns the user's input.
   Public Function ShowInputDialog(Optional Prompt As String = Nothing, Optional Input As String = Nothing, Optional ByRef Button As DialogResult = Nothing) As String
      Try
         With InputDialog
            .PromptLabel.Text = Prompt
            .TextBox.Text = Input
            Button = .ShowDialog()
            Return If(Button = DialogResult.Cancel, Nothing, .TextBox.Text)
         End With
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try

      Return Nothing
   End Function

   'This procedure trims the end or start of the selected lines.
   Public Sub TrimLines(TextBox As RichTextBox, Optional TrimStart As Boolean = True)
      Try
         Dim NewText As New StringBuilder

         Array.ForEach(TextBox.SelectedText.Split(NewLine.ToCharArray()), Sub(Line As String) NewText.Append(If(TrimStart, Line.TrimStart(), Line.TrimEnd) & NewLine))

         TextBox.SelectedText = NewText.ToString().Substring(0, NewText.Length - NewLine.Length)
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure updates the interface.
   Public Sub UpdateInterface()
      Try
         With InterfaceWindow
            .HighlightCodeMenu.Enabled = Not (HighlightingTemplate.Language = Nothing)
            .LaunchProgramMenu.Enabled = Not (Settings.ExternalProgram = Nothing)
            .OpenWithShellMenu.Enabled = Not (DocumentO.PathO = Nothing)
            .StopHighlightingMenu.Enabled = .HighlightCodeMenu.Enabled
            .Text = $"{ProgramInformation()}{If(DocumentO.PathO = Nothing, Nothing, $" - {DocumentO.PathO}")}"
         End With

         UpdateStatusBar()
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure updates the status bar.
   Public Sub UpdateStatusBar()
      Try
         With InterfaceWindow
            Dim Row As Integer = .TextBox.GetLineFromCharIndex(.TextBox.SelectionStart)

            .StatusLabel.Text = Nothing
            If Not HighlightingTemplate.Language = Nothing Then .StatusLabel.Text = $"Highlighting: {HighlightingTemplate.Language}{New String(" "c, 5)}"
            .StatusLabel.Text &= $"Row: {Row + 1}   Column: {(.TextBox.SelectionStart - .TextBox.GetFirstCharIndexFromLine(Row)) + 1}{New String(" "c, 5)}"
         End With
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub
End Module
