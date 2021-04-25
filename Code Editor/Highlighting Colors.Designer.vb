<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HighlightingColorsWindow
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
      Me.CommentColorButton = New System.Windows.Forms.Button()
      Me.StringColorButton = New System.Windows.Forms.Button()
      Me.KeywordColorButton = New System.Windows.Forms.Button()
      Me.CommentColorBox = New System.Windows.Forms.PictureBox()
      Me.KeywordColorBox = New System.Windows.Forms.PictureBox()
      Me.StringColorBox = New System.Windows.Forms.PictureBox()
      CType(Me.CommentColorBox, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.KeywordColorBox, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.StringColorBox, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'CloseButton
      '
      Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.CloseButton.Location = New System.Drawing.Point(148, 122)
      Me.CloseButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      Me.CloseButton.Name = "CloseButton"
      Me.CloseButton.Size = New System.Drawing.Size(100, 28)
      Me.CloseButton.TabIndex = 3
      Me.CloseButton.Text = "C&lose"
      Me.CloseButton.UseVisualStyleBackColor = True
      '
      'CommentColorButton
      '
      Me.CommentColorButton.Location = New System.Drawing.Point(16, 15)
      Me.CommentColorButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      Me.CommentColorButton.Name = "CommentColorButton"
      Me.CommentColorButton.Size = New System.Drawing.Size(180, 28)
      Me.CommentColorButton.TabIndex = 0
      Me.CommentColorButton.Text = "&Comment Color"
      Me.CommentColorButton.UseVisualStyleBackColor = True
      '
      'StringColorButton
      '
      Me.StringColorButton.Location = New System.Drawing.Point(16, 86)
      Me.StringColorButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      Me.StringColorButton.Name = "StringColorButton"
      Me.StringColorButton.Size = New System.Drawing.Size(180, 28)
      Me.StringColorButton.TabIndex = 2
      Me.StringColorButton.Text = "&String Color"
      Me.StringColorButton.UseVisualStyleBackColor = True
      '
      'KeywordColorButton
      '
      Me.KeywordColorButton.Location = New System.Drawing.Point(16, 50)
      Me.KeywordColorButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      Me.KeywordColorButton.Name = "KeywordColorButton"
      Me.KeywordColorButton.Size = New System.Drawing.Size(180, 28)
      Me.KeywordColorButton.TabIndex = 1
      Me.KeywordColorButton.Text = "&Keyword Color"
      Me.KeywordColorButton.UseVisualStyleBackColor = True
      '
      'CommentColorBox
      '
      Me.CommentColorBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.CommentColorBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.CommentColorBox.Location = New System.Drawing.Point(205, 15)
      Me.CommentColorBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      Me.CommentColorBox.Name = "CommentColorBox"
      Me.CommentColorBox.Size = New System.Drawing.Size(41, 27)
      Me.CommentColorBox.TabIndex = 4
      Me.CommentColorBox.TabStop = False
      '
      'KeywordColorBox
      '
      Me.KeywordColorBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.KeywordColorBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.KeywordColorBox.Location = New System.Drawing.Point(205, 50)
      Me.KeywordColorBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      Me.KeywordColorBox.Name = "KeywordColorBox"
      Me.KeywordColorBox.Size = New System.Drawing.Size(41, 27)
      Me.KeywordColorBox.TabIndex = 5
      Me.KeywordColorBox.TabStop = False
      '
      'StringColorBox
      '
      Me.StringColorBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.StringColorBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.StringColorBox.Location = New System.Drawing.Point(205, 86)
      Me.StringColorBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      Me.StringColorBox.Name = "StringColorBox"
      Me.StringColorBox.Size = New System.Drawing.Size(41, 27)
      Me.StringColorBox.TabIndex = 6
      Me.StringColorBox.TabStop = False
      '
      'HighlightingColorsWindow
      '
      Me.AcceptButton = Me.CloseButton
      Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.CancelButton = Me.CloseButton
      Me.ClientSize = New System.Drawing.Size(267, 165)
      Me.Controls.Add(Me.StringColorBox)
      Me.Controls.Add(Me.KeywordColorBox)
      Me.Controls.Add(Me.CommentColorBox)
      Me.Controls.Add(Me.KeywordColorButton)
      Me.Controls.Add(Me.StringColorButton)
      Me.Controls.Add(Me.CommentColorButton)
      Me.Controls.Add(Me.CloseButton)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.KeyPreview = True
      Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "HighlightingColorsWindow"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = "Highlighting Colors"
      CType(Me.CommentColorBox, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.KeywordColorBox, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.StringColorBox, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents CloseButton As System.Windows.Forms.Button
   Friend WithEvents CommentColorButton As System.Windows.Forms.Button
   Friend WithEvents StringColorButton As System.Windows.Forms.Button
   Friend WithEvents KeywordColorButton As System.Windows.Forms.Button
   Friend WithEvents CommentColorBox As System.Windows.Forms.PictureBox
   Friend WithEvents KeywordColorBox As System.Windows.Forms.PictureBox
   Friend WithEvents StringColorBox As System.Windows.Forms.PictureBox
End Class
