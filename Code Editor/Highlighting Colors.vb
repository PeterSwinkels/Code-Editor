'This module's settings and imports:
Option Compare Binary
Option Explicit On
Option Infer Off
Option Strict On

Imports System

'This module contains the highlighting colors window.
Public Class HighlightingColorsWindow
   'This procedure closes this window.
   Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
      Try
         Me.Close()
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure requests the user to select a color for comments.
   Private Sub CommentColorButton_Click(sender As Object, e As EventArgs) Handles CommentColorButton.Click
      Try
         Settings.CommentColor = ShowColorDialog(Settings.CommentColor)
         UpdateWindow()
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure initializes this window.
   Private Sub HighlightingColorsWindow_Load(sender As Object, e As EventArgs) Handles Me.Load
      Try
         UpdateWindow()
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure requests the user to select a color for keywords.
   Private Sub KeywordColorButton_Click(sender As Object, e As EventArgs) Handles KeywordColorButton.Click
      Try
         Settings.KeyWordColor = ShowColorDialog(Settings.KeyWordColor)
         UpdateWindow()
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure requests the user to select a color for strings.
   Private Sub StringsColorButton_Click(sender As Object, e As EventArgs) Handles StringColorButton.Click
      Try
         Settings.StringColor = ShowColorDialog(Settings.StringColor)
         UpdateWindow()
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure updates the information displayed by this window.
   Private Sub UpdateWindow()
      Try
         With Settings
            CommentColorBox.BackColor = .CommentColor
            KeywordColorBox.BackColor = .KeyWordColor
            StringColorBox.BackColor = .StringColor
         End With
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub
End Class