﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindWindow
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
      Me.FindBox = New System.Windows.Forms.TextBox()
      Me.FindLabel = New System.Windows.Forms.Label()
      Me.ForwardFindButton = New System.Windows.Forms.Button()
      Me.CaseSensitiveBox = New System.Windows.Forms.CheckBox()
      Me.WholeWordBox = New System.Windows.Forms.CheckBox()
      Me.BackwardFindButton = New System.Windows.Forms.Button()
      Me.ReplaceBox = New System.Windows.Forms.TextBox()
      Me.ReplaceLabel = New System.Windows.Forms.Label()
      Me.ReplaceButton = New System.Windows.Forms.Button()
      Me.ReplaceAllButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseButton.Location = New System.Drawing.Point(114, 119)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 4
        Me.CloseButton.Text = "C&lose"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'FindBox
        '
        Me.FindBox.Location = New System.Drawing.Point(69, 5)
        Me.FindBox.Name = "FindBox"
        Me.FindBox.Size = New System.Drawing.Size(283, 20)
        Me.FindBox.TabIndex = 0
        '
        'FindLabel
        '
        Me.FindLabel.AutoSize = True
        Me.FindLabel.Location = New System.Drawing.Point(33, 12)
        Me.FindLabel.Name = "FindLabel"
        Me.FindLabel.Size = New System.Drawing.Size(30, 13)
        Me.FindLabel.TabIndex = 5
        Me.FindLabel.Text = "Find:"
        '
        'ForwardFindButton
        '
        Me.ForwardFindButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ForwardFindButton.Location = New System.Drawing.Point(276, 119)
        Me.ForwardFindButton.Name = "ForwardFindButton"
        Me.ForwardFindButton.Size = New System.Drawing.Size(75, 23)
        Me.ForwardFindButton.TabIndex = 2
        Me.ForwardFindButton.Text = "&Find >>"
        Me.ForwardFindButton.UseVisualStyleBackColor = True
        '
        'CaseSensitiveBox
        '
        Me.CaseSensitiveBox.AutoSize = True
        Me.CaseSensitiveBox.Location = New System.Drawing.Point(69, 62)
        Me.CaseSensitiveBox.Name = "CaseSensitiveBox"
        Me.CaseSensitiveBox.Size = New System.Drawing.Size(96, 17)
        Me.CaseSensitiveBox.TabIndex = 7
        Me.CaseSensitiveBox.Text = "&Case Sensitive"
        Me.CaseSensitiveBox.UseVisualStyleBackColor = True
        '
        'WholeWordBox
        '
        Me.WholeWordBox.AutoSize = True
        Me.WholeWordBox.Location = New System.Drawing.Point(171, 62)
        Me.WholeWordBox.Name = "WholeWordBox"
        Me.WholeWordBox.Size = New System.Drawing.Size(83, 17)
        Me.WholeWordBox.TabIndex = 8
        Me.WholeWordBox.Text = "&WholeWord"
        Me.WholeWordBox.UseVisualStyleBackColor = True
        '
        'BackwardFindButton
        '
        Me.BackwardFindButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BackwardFindButton.Location = New System.Drawing.Point(195, 119)
        Me.BackwardFindButton.Name = "BackwardFindButton"
        Me.BackwardFindButton.Size = New System.Drawing.Size(75, 23)
        Me.BackwardFindButton.TabIndex = 3
        Me.BackwardFindButton.Text = "F&ind <<"
        Me.BackwardFindButton.UseVisualStyleBackColor = True
        '
        'ReplaceBox
        '
        Me.ReplaceBox.Location = New System.Drawing.Point(69, 36)
        Me.ReplaceBox.Name = "ReplaceBox"
        Me.ReplaceBox.Size = New System.Drawing.Size(283, 20)
        Me.ReplaceBox.TabIndex = 1
        '
        'ReplaceLabel
        '
        Me.ReplaceLabel.AutoSize = True
        Me.ReplaceLabel.Location = New System.Drawing.Point(13, 39)
        Me.ReplaceLabel.Name = "ReplaceLabel"
        Me.ReplaceLabel.Size = New System.Drawing.Size(50, 13)
        Me.ReplaceLabel.TabIndex = 7
        Me.ReplaceLabel.Text = "Replace:"
        '
        'ReplaceButton
        '
        Me.ReplaceButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReplaceButton.Location = New System.Drawing.Point(195, 90)
        Me.ReplaceButton.Name = "ReplaceButton"
        Me.ReplaceButton.Size = New System.Drawing.Size(75, 23)
        Me.ReplaceButton.TabIndex = 5
        Me.ReplaceButton.Text = "&Replace"
        Me.ReplaceButton.UseVisualStyleBackColor = True
        '
        'ReplaceAllButton
        '
        Me.ReplaceAllButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReplaceAllButton.Location = New System.Drawing.Point(277, 90)
        Me.ReplaceAllButton.Name = "ReplaceAllButton"
        Me.ReplaceAllButton.Size = New System.Drawing.Size(75, 23)
        Me.ReplaceAllButton.TabIndex = 6
        Me.ReplaceAllButton.Text = "Replace &All"
        Me.ReplaceAllButton.UseVisualStyleBackColor = True
        '
        'FindWindow
        '
        Me.AcceptButton = Me.ForwardFindButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CloseButton
        Me.ClientSize = New System.Drawing.Size(363, 154)
        Me.Controls.Add(Me.ReplaceAllButton)
        Me.Controls.Add(Me.ReplaceButton)
        Me.Controls.Add(Me.ReplaceLabel)
        Me.Controls.Add(Me.ReplaceBox)
        Me.Controls.Add(Me.BackwardFindButton)
        Me.Controls.Add(Me.WholeWordBox)
        Me.Controls.Add(Me.CaseSensitiveBox)
        Me.Controls.Add(Me.ForwardFindButton)
        Me.Controls.Add(Me.FindLabel)
        Me.Controls.Add(Me.FindBox)
        Me.Controls.Add(Me.CloseButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FindWindow"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Find and Replace"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CloseButton As System.Windows.Forms.Button
   Friend WithEvents FindBox As System.Windows.Forms.TextBox
   Friend WithEvents FindLabel As System.Windows.Forms.Label
   Friend WithEvents ForwardFindButton As System.Windows.Forms.Button
   Friend WithEvents CaseSensitiveBox As System.Windows.Forms.CheckBox
   Friend WithEvents WholeWordBox As System.Windows.Forms.CheckBox
   Friend WithEvents BackwardFindButton As System.Windows.Forms.Button
   Friend WithEvents ReplaceBox As System.Windows.Forms.TextBox
   Friend WithEvents ReplaceLabel As System.Windows.Forms.Label
   Friend WithEvents ReplaceButton As System.Windows.Forms.Button
   Friend WithEvents ReplaceAllButton As System.Windows.Forms.Button
End Class
