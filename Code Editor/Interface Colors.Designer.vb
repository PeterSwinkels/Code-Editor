<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InterfaceColorsWindow
   Inherits System.Windows.Forms.Form

   'Form overrides dispose to clean up the component list.
   <System.Diagnostics.DebuggerNonUserCode()> _
   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
      Try
         If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
         End If
      Finally
         MyBase.Dispose(disposing)
      End Try
   End Sub

   'Required by the Windows Form Designer
   Private components As System.ComponentModel.IContainer

   'NOTE: The following procedure is required by the Windows Form Designer
   'It can be modified using the Windows Form Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
      Me.CloseButton = New System.Windows.Forms.Button()
      Me.TextForegroundColorButton = New System.Windows.Forms.Button()
      Me.TextBackgroundColorButton = New System.Windows.Forms.Button()
      Me.TextForegroundColorBox = New System.Windows.Forms.PictureBox()
      Me.TextBackgroundColor = New System.Windows.Forms.PictureBox()
      CType(Me.TextForegroundColorBox, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBackgroundColor, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'CloseButton
      '
      Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.CloseButton.Location = New System.Drawing.Point(148, 91)
      Me.CloseButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      Me.CloseButton.Name = "CloseButton"
      Me.CloseButton.Size = New System.Drawing.Size(100, 28)
      Me.CloseButton.TabIndex = 2
      Me.CloseButton.Text = "C&lose"
      Me.CloseButton.UseVisualStyleBackColor = True
      '
      'TextForegroundColorButton
      '
      Me.TextForegroundColorButton.Location = New System.Drawing.Point(17, 47)
      Me.TextForegroundColorButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      Me.TextForegroundColorButton.Name = "TextForegroundColorButton"
      Me.TextForegroundColorButton.Size = New System.Drawing.Size(180, 32)
      Me.TextForegroundColorButton.TabIndex = 1
      Me.TextForegroundColorButton.Text = "Text &Foreground Color"
      Me.TextForegroundColorButton.UseVisualStyleBackColor = True
      '
      'TextBackgroundColorButton
      '
      Me.TextBackgroundColorButton.Location = New System.Drawing.Point(17, 15)
      Me.TextBackgroundColorButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      Me.TextBackgroundColorButton.Name = "TextBackgroundColorButton"
      Me.TextBackgroundColorButton.Size = New System.Drawing.Size(180, 28)
      Me.TextBackgroundColorButton.TabIndex = 0
      Me.TextBackgroundColorButton.Text = "Text &Background Color"
      Me.TextBackgroundColorButton.UseVisualStyleBackColor = True
      '
      'TextForegroundColorBox
      '
      Me.TextForegroundColorBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.TextForegroundColorBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.TextForegroundColorBox.Location = New System.Drawing.Point(208, 50)
      Me.TextForegroundColorBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      Me.TextForegroundColorBox.Name = "TextForegroundColorBox"
      Me.TextForegroundColorBox.Size = New System.Drawing.Size(41, 27)
      Me.TextForegroundColorBox.TabIndex = 4
      Me.TextForegroundColorBox.TabStop = False
      '
      'TextBackgroundColor
      '
      Me.TextBackgroundColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.TextBackgroundColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.TextBackgroundColor.Location = New System.Drawing.Point(208, 15)
      Me.TextBackgroundColor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      Me.TextBackgroundColor.Name = "TextBackgroundColor"
      Me.TextBackgroundColor.Size = New System.Drawing.Size(41, 27)
      Me.TextBackgroundColor.TabIndex = 5
      Me.TextBackgroundColor.TabStop = False
      '
      'InterfaceColorsWindow
      '
      Me.AcceptButton = Me.CloseButton
      Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.CancelButton = Me.CloseButton
      Me.ClientSize = New System.Drawing.Size(267, 134)
      Me.Controls.Add(Me.TextBackgroundColor)
      Me.Controls.Add(Me.TextForegroundColorBox)
      Me.Controls.Add(Me.TextBackgroundColorButton)
      Me.Controls.Add(Me.TextForegroundColorButton)
      Me.Controls.Add(Me.CloseButton)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.KeyPreview = True
      Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "InterfaceColorsWindow"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = "Interface Colors"
      CType(Me.TextForegroundColorBox, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBackgroundColor, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents CloseButton As System.Windows.Forms.Button
   Friend WithEvents TextForegroundColorButton As System.Windows.Forms.Button
   Friend WithEvents TextBackgroundColorButton As System.Windows.Forms.Button
   Friend WithEvents TextForegroundColorBox As System.Windows.Forms.PictureBox
   Friend WithEvents TextBackgroundColor As System.Windows.Forms.PictureBox
End Class
