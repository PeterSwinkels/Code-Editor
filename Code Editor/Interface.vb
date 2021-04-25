'This module's settings and imports:
Option Compare Binary
Option Explicit On
Option Infer Off
Option Strict On

Imports Microsoft.VisualBasic
Imports System
Imports System.Convert
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Environment
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms

'This module contains this program's main interface window.
Public Class InterfaceWindow
   Private LastLinePrinted As Integer = 0                        'Contains the number of the last line printed.
   Private WithEvents EditContextMenuO As New ContextMenuStrip   'Contains the edit context menu strip.
   Private WithEvents PrinterO As New PrintDocument              'Contains a reference to the printer object.

   'This procedure toggles the capture external program output option on/off.
   Private Sub CaptureOutputMenu_Click(sender As Object, e As EventArgs) Handles CaptureOutputMenu.Click
      Try
         With Settings
            .CaptureOutput = Not .CaptureOutput
            CaptureOutputMenu.Checked = .CaptureOutput
         End With
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure converts the spaces in the selected text to tabs.
   Private Sub ConvertSpacesToTabsMenu_Click(sender As Object, e As EventArgs) Handles ConvertSpacesToTabsMenu.Click
      Try
         TextBox.SelectedText = TextBox.SelectedText.Replace(" ", ControlChars.Tab)
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure converts the tabs in the selected text to spaces.
   Private Sub ConvertTabsToSpacesMenu_Click(sender As Object, e As EventArgs) Handles ConvertTabsToSpacesMenu.Click
      Try
         TextBox.SelectedText = TextBox.SelectedText.Replace(ControlChars.Tab, " ")
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure copies the selected text.
   Private Sub CopyMenu_Click(sender As Object, e As EventArgs) Handles CopyMenu.Click
      Try
         TextBox.Copy()
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure cuts the selected text.
   Private Sub CutMenu_Click(sender As Object, e As EventArgs) Handles CutMenu.Click
      Try
         TextBox.Cut()
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure gives the command to create a template.
   Private Sub CreateTemplateMenu_Click(sender As Object, e As EventArgs) Handles CreateTemplateMenu.Click
      Try
         Dim NewTemplate As String = CreateTemplate()

         If NewTemplate IsNot Nothing Then
            TextBox.Text = NewTemplate
            HighlightingTemplate = BlankTemplate()
         End If

         UpdateInterface()
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure requests the user to specify an external program's arguments.
   Private Sub ExternalArgumentsMenu_Click(sender As Object, e As EventArgs) Handles ExternalArgumentsMenu.Click
      Try
         Dim Button As New DialogResult
         Dim Index As New Integer
         Dim NewArguments As String = Settings.ExternalArguments

         Do
            NewArguments = ShowInputDialog($"""{DOCUMENT_PATH}"" = current document.{NewLine}""{DOCUMENT_PATH_WITHOUT_EXTENSION}"" = current document without extension.", NewArguments, Button)

            If Button = DialogResult.Cancel Then
               Exit Do
            ElseIf NewArguments.Contains(DOCUMENT_PATH) Then
               Settings.ExternalArguments = NewArguments
               Exit Do
            Else
               MessageBox.Show($"The current document place holder ({DOCUMENT_PATH}) is missing.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
         Loop
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure requests the user to specify an external program to open any current documents with.
   Private Sub ExternalProgramMenu_Click(sender As Object, e As EventArgs) Handles ExternalProgramMenu.Click
      Try
         With New OpenFileDialog
            If Not Settings.ExternalProgram = Nothing Then
               .FileName = Path.GetFileName(Settings.ExternalProgram)
               .InitialDirectory = Path.GetDirectoryName(Settings.ExternalProgram)
            End If
            If .ShowDialog() = DialogResult.OK Then Settings.ExternalProgram = .FileName
         End With

         UpdateInterface()
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure displays the find and replace window.
   Private Sub FindAndReplaceMenu_Click(sender As Object, e As EventArgs) Handles FindAndReplaceMenu.Click
      Try
         FindWindow.ShowDialog()
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure gives the command to highlight any code in the current document.
   Private Sub HighlightCodeMenu_Click(sender As Object, e As EventArgs) Handles HighlightCodeMenu.Click
      Try
         HighlightCode(TextBox, HighlightingTemplate)
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure displays the highlighting colors dialog.
   Private Sub HighlightingSelectColorsMenu_Click(sender As Object, e As EventArgs) Handles HighlightingSelectColorsMenu.Click
      Try
         HighlightingColorsWindow.ShowDialog()

         If Not HighlightingTemplate.Language = Nothing Then HighlightCode(TextBox, HighlightingTemplate)
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure requests the user to specify an indentation value.
   Private Sub IndentationMenu_Click(sender As Object, e As EventArgs) Handles IndentationMenu.Click
      Try
         Dim NewIndentation As String = ShowInputDialog("Indentation:", CStr(Settings.Indentation))

         If NewIndentation IsNot Nothing Then Settings.Indentation = ToInt32(NewIndentation)
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure displays information about this program.
   Private Sub InformationMainMenu_Click(sender As Object, e As EventArgs) Handles InformationMainMenu.Click
      Try
         MessageBox.Show(My.Application.Info.Description, ProgramInformation(), MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure closes this window after getting confirmation from the user.
   Private Sub InterfaceWindow_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
      Try
         e.Cancel = (MessageBox.Show("Quit?", My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No)

         If Not e.Cancel Then
            If AskSaveIfModified() = DialogResult.Yes Then SaveDocument(TextBox.Text, NoDialog:=True)

            With Settings
               .InterfacePosition = Me.Location
               .InterfaceSize = Me.ClientSize
               .InterfaceState = Me.WindowState
               .ShowErrorsHeight = OutputErrorSplitterBox.SplitterDistance
               .ShowOutputHeight = DocumentOutputSplitterBox.SplitterDistance
            End With

            SaveSettings(Locations().SettingsPath, Settings)
         End If
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure handles the user's key strokes.
   Private Sub InterfaceWindow_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
      Try
         e.SuppressKeyPress = (TextBox.SelectedText.Length > 0 AndAlso e.KeyCode = Keys.Tab AndAlso Settings.Indentation > 0)
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure handles the user's key strokes.
   Private Sub InterfaceWindow_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
      Try
         If TextBox.SelectedText.Length > 0 AndAlso e.KeyCode = Keys.Tab AndAlso Settings.Indentation > 0 Then Indent(TextBox, My.Computer.Keyboard.ShiftKeyDown)
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure initializes this window.
   Private Sub InterfaceWindow_Load(sender As Object, e As EventArgs) Handles Me.Load
      Try
         Dim NewItem As ToolStripMenuItem = Nothing

         If File.Exists(Locations().SettingsPath) Then Settings = LoadSettings(Locations().SettingsPath)

         ProcessCommandLine()

         With Settings
            Me.ClientSize = .InterfaceSize
            Me.Location = .InterfacePosition
            Me.WindowState = .InterfaceState

            DocumentOutputSplitterBox.SplitterDistance = .ShowOutputHeight
            OutputErrorSplitterBox.SplitterDistance = .ShowErrorsHeight

            CaptureOutputMenu.Checked = .CaptureOutput
            ShowErrorsMenu.Checked = .ShowErrors
            ShowOutputMenu.Checked = .ShowOutput

            SetPaneVisibity()
         End With

         With TextBox
            .BackColor = Settings.BackgroundColor
            .Font = Settings.DocumentFont
            .ForeColor = Settings.ForegroundColor
         End With

         If Not DocumentO.PathO = Nothing Then OpenDocument(NoDialog:=True)

         For Each Item As ToolStripItem In EditMainMenu.DropDownItems
            If TypeOf Item Is ToolStripMenuItem Then
               NewItem = New ToolStripMenuItem

               With DirectCast(Item, ToolStripMenuItem)
                  AddHandler NewItem.Click, AddressOf EditContextMenu
                  NewItem.ShortcutKeys = .ShortcutKeys
                  NewItem.Text = .Text
               End With
               EditContextMenuO.Items.Add(NewItem)
            ElseIf TypeOf Item Is ToolStripSeparator Then
               EditContextMenuO.Items.Add(New ToolStripSeparator)
            End If
         Next Item

         UpdateInterface()
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure displays the interface colors dialog.
   Private Sub InterfaceSelectColorsMenu_Click(sender As Object, e As EventArgs) Handles InterfaceSelectColorsMenu.Click
      Try
         InterfaceColorsWindow.ShowDialog()
         TextBox.BackColor = Settings.BackgroundColor
         TextBox.ForeColor = Settings.ForegroundColor
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure gives the command to open the document with an external program.
   Private Sub LaunchProgramMenu_Click(sender As Object, e As EventArgs) Handles LaunchProgramMenu.Click
      Try
         If AskSaveIfModified() = DialogResult.Yes Then SaveDocument(TextBox.Text, NoDialog:=True)

         LaunchExternalProgram()
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure gives the command to open a highlighting template.
   Private Sub LoadTemplateMenu_Click(sender As Object, e As EventArgs) Handles LoadTemplateMenu.Click
      Try
         HighlightingTemplate = LoadTemplate()
         If Not HighlightingTemplate.Language = Nothing Then HighlightCode(TextBox, HighlightingTemplate)
         UpdateInterface()
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure erases the current document.
   Private Sub NewMenu_Click(sender As Object, e As EventArgs) Handles NewMenu.Click
      Try
         If MessageBox.Show("Start new document?", My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If AskSaveIfModified() = DialogResult.Yes Then SaveDocument(TextBox.Text, NoDialog:=True)
            ErrorBox.Clear()
            OutputBox.Clear()
            TextBox.Clear()
            DocumentO.Modified = False
            DocumentO.PathO = Nothing
            UpdateInterface()
         End If
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure gives the command to save the current document without requesting a file name if the document already has one.
   Private Sub OpenMenu_Click(sender As Object, e As EventArgs) Handles OpenMenu.Click
      Try
         OpenDocument()
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure opens the current document using the shell.
   Private Sub OpenWithShellMenu_Click(sender As Object, e As EventArgs) Handles OpenWithShellMenu.Click
      Try
         If AskSaveIfModified() = DialogResult.Yes Then SaveDocument(TextBox.Text, NoDialog:=True)

         Process.Start(New ProcessStartInfo With {.FileName = DocumentO.PathO, .UseShellExecute = True})
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure pastes items on the clipboard into the current document.
   Private Sub PasteMenu_Click(sender As Object, e As EventArgs) Handles PasteMenu.Click
      Try
         TextBox.Paste()
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure gives the command to print the current document.
   Private Sub PrintMenu_Click(sender As System.Object, e As System.EventArgs) Handles PrintMenu.Click
      Try
         With New PrintDialog
            If .ShowDialog() = DialogResult.OK Then
               LastLinePrinted = 0
               PrinterO.PrinterSettings = .PrinterSettings

               Do While LastLinePrinted < TextBox.Lines.Count
                  PrinterO.Print()
               Loop
            End If
         End With
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure prints a page from the current document.
   Private Sub PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrinterO.PrintPage
      Try
         Dim Line As String = Nothing
         Dim LineNumber As Integer = LastLinePrinted
         Dim NextLine As String = Nothing
         Dim Row As Single = TextBox.Margin.Top

         With TextBox
            e.Graphics.Clear(.BackColor)
            Do Until LineNumber >= .Lines.Count
               Line = .Lines(LineNumber)
               Do
                  NextLine = ""
                  Do While e.Graphics.MeasureString(Line, .Font).Width > (e.Graphics.VisibleClipBounds.Width - .Margin.Right)
                     NextLine = Line.Substring(Line.Length - 1) & NextLine
                     Line = Line.Substring(0, Line.Length - 1)
                  Loop

                  e.Graphics.DrawString(Line, .Font, New SolidBrush(.ForeColor), .Margin.Left, Row)
                  Row += .Font.GetHeight
                  If Row > e.Graphics.VisibleClipBounds.Bottom OrElse NextLine.Length = 0 Then Exit Do

                  Line = NextLine
               Loop
               LineNumber += 1
               If Row > e.Graphics.VisibleClipBounds.Bottom Then Exit Do
            Loop
         End With

         LastLinePrinted = LineNumber
         e.HasMorePages = (LastLinePrinted < TextBox.Lines.GetUpperBound(0))
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure redoes the user's most recent modification.
   Private Sub RedoMenu_Click(sender As Object, e As EventArgs) Handles RedoMenu.Click
      Try
         TextBox.Redo()
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure closes this window.
   Private Sub QuitMenu_Click(sender As Object, e As EventArgs) Handles QuitMenu.Click
      Try
         Me.Close()
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure gives the command to save the current document without requesting a file name if the document already has one.
   Private Sub SaveMenu_Click(sender As Object, e As EventArgs) Handles SaveMenu.Click
      Try
         SaveDocument(TextBox.Text, NoDialog:=True)
         UpdateInterface()
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure gives the command to save the current document.
   Private Sub SaveAsMenu_Click(sender As Object, e As EventArgs) Handles SaveAsMenu.Click
      Try
         SaveDocument(TextBox.Text)
         UpdateInterface()
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure cuts the selected text.
   Private Sub SelectAllMenu_Click(sender As Object, e As EventArgs) Handles SelectAllMenu.Click
      Try
         TextBox.SelectAll()
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure requests the user to specify a font to display documents with.
   Private Sub SelectFontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectFontMenu.Click
      Try
         With New FontDialog
            .Font = TextBox.Font
            .ShowDialog()
            TextBox.Font = .Font
            Settings.DocumentFont = TextBox.Font
         End With
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure toggles the show external program errors option on/off.
   Private Sub ShowErrorMenu_Click(sender As Object, e As EventArgs) Handles ShowErrorsMenu.Click
      Try
         With Settings
            .ShowErrors = Not .ShowErrors
            ShowErrorsMenu.Checked = .ShowErrors
            SetPaneVisibity()
         End With
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure toggles the show external program output option on/off.
   Private Sub ShowOutputMenu_Click(sender As Object, e As EventArgs) Handles ShowOutputMenu.Click
      Try
         With Settings
            .ShowOutput = Not .ShowOutput
            ShowOutputMenu.Checked = .ShowOutput
            SetPaneVisibity()
         End With
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure gives the command to stop highlighting.
   Private Sub StopHighlightingMenu_Click(sender As Object, e As EventArgs) Handles StopHighlightingMenu.Click
      Try
         HighlightingTemplate = BlankTemplate()
         TextBox.SelectAll()
         TextBox.SelectionColor = TextBox.ForeColor
         TextBox.DeselectAll()
         UpdateInterface()
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure handles the user's mouse clicks in the text box.
   Private Sub TextBox_MouseDown(sender As Object, e As MouseEventArgs) Handles TextBox.MouseDown
      Try
         If e.Button = MouseButtons.Right Then EditContextMenuO.Show(TextBox, e.Location)
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure opens any file that is dropped into the text box.
   Private Sub TextBox_DragDrop(sender As Object, e As DragEventArgs) Handles TextBox.DragDrop
      Try
         Dim DropItems() As String = DirectCast(e.Data.GetData(DataFormats.FileDrop), String())

         e.Effect = DragDropEffects.None
         If DropItems IsNot Nothing AndAlso DropItems.Any Then
            DocumentO.PathO = DropItems.First
            OpenDocument(NoDialog:=True)
         End If
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure gives the command to update the status bar.
   Private Sub TextBox_SelectionChanged(sender As Object, e As EventArgs) Handles TextBox.SelectionChanged
      Try
         UpdateStatusBar()
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure is executed when the current document is modified.
   Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles TextBox.TextChanged
      Try
         DocumentO.Modified = True
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure gives the command to trim the end of the selected lines.
   Private Sub TrimEndOfLines_Click(sender As Object, e As EventArgs) Handles TrimEndOfLinesMenu.Click
      Try
         TrimLines(TextBox, TrimStart:=False)
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure gives the command to trim the start of the selected lines.
   Private Sub TrimStartOfLines_Click(sender As Object, e As EventArgs) Handles TrimStartOfLinesMenu.Click
      Try
         TrimLines(TextBox)
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure undoes the user's most recent modification.
   Private Sub UndoMenu_Click(sender As Object, e As EventArgs) Handles UndoMenu.Click
      Try
         TextBox.Undo()
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure handles the edit context menu events.
   Private Sub EditContextMenu(sender As Object, e As EventArgs)
      Try
         For Each Item As ToolStripItem In EditMainMenu.DropDownItems
            If TypeOf Item Is ToolStripMenuItem AndAlso DirectCast(Item, ToolStripMenuItem).Text = DirectCast(sender, ToolStripMenuItem).Text Then DirectCast(Item, ToolStripMenuItem).PerformClick()
         Next Item
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure sets the output/error panes' visibility state.
   Private Sub SetPaneVisibity()
      Try
         With Settings
            DocumentOutputSplitterBox.Panel2Collapsed = Not (.ShowErrors Or .ShowOutput)
            OutputErrorSplitterBox.Panel1Collapsed = Not .ShowOutput
            OutputErrorSplitterBox.Panel2Collapsed = Not .ShowErrors
         End With
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub
End Class
