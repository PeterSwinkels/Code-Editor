'This module's settings and imports:
Option Compare Binary
Option Explicit On
Option Infer Off
Option Strict On

Imports System

'This module contains the interface colors window.
Public Class InterfaceColorsWindow
   'This procedure closes this window.
   Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
      Try
         Me.Close()
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure initializes this window.
   Private Sub InterfaceColorsWindow_Load(sender As Object, e As EventArgs) Handles Me.Load
      Try
         UpdateWindow()
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure requests the user to select a background color for text.
   Private Sub TextBackgroundColorButton_Click(sender As Object, e As EventArgs) Handles TextBackgroundColorButton.Click
      Try
         Settings.BackgroundColor = ShowColorDialog(Settings.BackgroundColor)
         UpdateWindow()
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure requests the user to select a foreground color for text.
   Private Sub TextForegroundColorButton_Click(sender As Object, e As EventArgs) Handles TextForegroundColorButton.Click
      Try
         Settings.ForegroundColor = ShowColorDialog(Settings.ForegroundColor)
         UpdateWindow()
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub

   'This procedure updates the information displayed by this window.
   Private Sub UpdateWindow()
      Try
         With Settings
            TextBackgroundColor.BackColor = .BackgroundColor
            TextForegroundColorBox.BackColor = .ForegroundColor
         End With
      Catch ExceptionO As Exception
         HandleError(ExceptionO)
      End Try
   End Sub
End Class