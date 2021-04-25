'This module's settings and imports:
Option Compare Binary
Option Explicit On
Option Infer Off
Option Strict On

Imports System
Imports System.Windows.Forms

'This module contains the find and replace window.
Public Class FindWindow
   'This procedure gives the command to search backwards for the specified text.
   Private Sub BackwardFindButton_Click(sender As Object, e As EventArgs) Handles BackwardFindButton.Click
      Try
         FindText(InterfaceWindow.TextBox, Backwards:=True)
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure closes this window.
   Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
      Try
         Me.Close()
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure searches for the specified text.
   Private Sub FindText(TextBox As RichTextBox, Optional Backwards As Boolean = False)
      Try
         Dim EndAt As Integer = 0
         Dim Options As RichTextBoxFinds = If(Backwards, RichTextBoxFinds.Reverse, RichTextBoxFinds.None)
         Dim Result As Integer = 0
         Dim StartAt As Integer = 0

         If CaseSensitiveBox.Checked Then Options = Options Or RichTextBoxFinds.MatchCase
         If WholeWordBox.Checked Then Options = Options Or RichTextBoxFinds.WholeWord

         With TextBox
            If Backwards Then
               EndAt = If(.SelectionStart >= .Text.Length - 1, 0, .SelectionStart - 1)
               StartAt = 0
            Else
               EndAt = -1
               StartAt = If(.SelectionStart >= .Text.Length - 1, 0, .SelectionStart + 1)
            End If

            Result = .Find(FindBox.Text, StartAt, EndAt, Options)
            If Result < 0 Then .SelectionStart = If(Backwards, .Text.Length - 1, 0)
         End With
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure gives the command to search forwards for the specified text.
   Private Sub ForwardFindButton_Click(sender As Object, e As EventArgs) Handles ForwardFindButton.Click
      Try
         FindText(InterfaceWindow.TextBox)
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure replaces the selected text.
   Private Sub ReplaceButton_Click(sender As Object, e As EventArgs) Handles ReplaceButton.Click
      Try
         InterfaceWindow.TextBox.SelectedText = InterfaceWindow.TextBox.SelectedText.Replace(FindBox.Text, ReplaceBox.Text)
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure replaces all text.
   Private Sub ReplaceAllButton_Click(sender As Object, e As EventArgs) Handles ReplaceAllButton.Click
      Try
         InterfaceWindow.TextBox.Text = InterfaceWindow.TextBox.Text.Replace(FindBox.Text, ReplaceBox.Text)
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   Private Sub FindWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

   End Sub
End Class
