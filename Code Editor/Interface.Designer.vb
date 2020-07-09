<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InterfaceWindow
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
      Me.components = New System.ComponentModel.Container()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InterfaceWindow))
      Me.MenuBar = New System.Windows.Forms.MenuStrip()
      Me.FileMainMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.NewMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.FileMainMenuSeparator1 = New System.Windows.Forms.ToolStripSeparator()
      Me.OpenMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.SaveMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.SaveAsMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.FileMainMenuSeparator2 = New System.Windows.Forms.ToolStripSeparator()
      Me.PrintMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.FileMainMenuSeparator3 = New System.Windows.Forms.ToolStripSeparator()
      Me.QuitMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.EditMainMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.UndoMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.RedoMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.EditMainMenuSeparator1 = New System.Windows.Forms.ToolStripSeparator()
      Me.CutMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.CopyMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.PasteMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.EditMainMenuSeparator2 = New System.Windows.Forms.ToolStripSeparator()
      Me.SelectAllMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.EditMainMenuSeparator3 = New System.Windows.Forms.ToolStripSeparator()
      Me.FindAndReplaceMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
      Me.ConvertSpacesToTabsMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.ConvertTabsToSpacesMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.TrimEndOfLinesMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.TrimStartOfLinesMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.OptionsMainMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.IndentationMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.OptionsMainMenuSeparator1 = New System.Windows.Forms.ToolStripSeparator()
      Me.ExternalMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.CaptureOutputMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.ExternalArgumentsMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.ExternalProgramMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.ShowOutputMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.ShowErrorsMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.HighlightingMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.CreateTemplateMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.HighlightCodeMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.LoadTemplateMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.HighlightingSelectColorsMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.StopHighlightingMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.OptionsMainMenuSeparator2 = New System.Windows.Forms.ToolStripSeparator()
      Me.InterfaceSelectColorsMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.SelectFontMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.ExternalMainMenu = New System.Windows.Forms.ToolStripMenuItem()
      Me.LaunchProgramMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenWithShellMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformationMainMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusBar = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.InterfacePanel = New System.Windows.Forms.Panel()
        Me.DocumentOutputSplitterBox = New System.Windows.Forms.SplitContainer()
        Me.TextBox = New System.Windows.Forms.RichTextBox()
        Me.OutputErrorSplitterBox = New System.Windows.Forms.SplitContainer()
        Me.OutputBox = New System.Windows.Forms.TextBox()
        Me.ErrorBox = New System.Windows.Forms.TextBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuBar.SuspendLayout()
        Me.StatusBar.SuspendLayout()
        Me.InterfacePanel.SuspendLayout()
        CType(Me.DocumentOutputSplitterBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentOutputSplitterBox.Panel1.SuspendLayout()
        Me.DocumentOutputSplitterBox.Panel2.SuspendLayout()
        Me.DocumentOutputSplitterBox.SuspendLayout()
        CType(Me.OutputErrorSplitterBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OutputErrorSplitterBox.Panel1.SuspendLayout()
        Me.OutputErrorSplitterBox.Panel2.SuspendLayout()
        Me.OutputErrorSplitterBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuBar
        '
        Me.MenuBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMainMenu, Me.EditMainMenu, Me.OptionsMainMenu, Me.ExternalMainMenu, Me.InformationMainMenu})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuBar.Size = New System.Drawing.Size(1145, 28)
        Me.MenuBar.TabIndex = 1
        '
        'FileMainMenu
        '
        Me.FileMainMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewMenu, Me.FileMainMenuSeparator1, Me.OpenMenu, Me.SaveMenu, Me.SaveAsMenu, Me.FileMainMenuSeparator2, Me.PrintMenu, Me.FileMainMenuSeparator3, Me.QuitMenu})
        Me.FileMainMenu.Name = "FileMainMenu"
        Me.FileMainMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.FileMainMenu.Size = New System.Drawing.Size(37, 24)
        Me.FileMainMenu.Text = "&File"
        '
        'NewMenu
        '
        Me.NewMenu.Name = "NewMenu"
        Me.NewMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewMenu.Size = New System.Drawing.Size(154, 22)
        Me.NewMenu.Text = "&New"
        '
        'FileMainMenuSeparator1
        '
        Me.FileMainMenuSeparator1.Name = "FileMainMenuSeparator1"
        Me.FileMainMenuSeparator1.Size = New System.Drawing.Size(151, 6)
        '
        'OpenMenu
        '
        Me.OpenMenu.Name = "OpenMenu"
        Me.OpenMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenMenu.Size = New System.Drawing.Size(154, 22)
        Me.OpenMenu.Text = "&Open"
        '
        'SaveMenu
        '
        Me.SaveMenu.Name = "SaveMenu"
        Me.SaveMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveMenu.Size = New System.Drawing.Size(154, 22)
        Me.SaveMenu.Text = "&Save"
        '
        'SaveAsMenu
        '
        Me.SaveAsMenu.Name = "SaveAsMenu"
        Me.SaveAsMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.SaveAsMenu.Size = New System.Drawing.Size(154, 22)
        Me.SaveAsMenu.Text = "Save &As"
        '
        'FileMainMenuSeparator2
        '
        Me.FileMainMenuSeparator2.Name = "FileMainMenuSeparator2"
        Me.FileMainMenuSeparator2.Size = New System.Drawing.Size(151, 6)
        '
        'PrintMenu
        '
        Me.PrintMenu.Name = "PrintMenu"
        Me.PrintMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintMenu.Size = New System.Drawing.Size(154, 22)
        Me.PrintMenu.Text = "&Print"
        '
        'FileMainMenuSeparator3
        '
        Me.FileMainMenuSeparator3.Name = "FileMainMenuSeparator3"
        Me.FileMainMenuSeparator3.Size = New System.Drawing.Size(151, 6)
        '
        'QuitMenu
        '
        Me.QuitMenu.Name = "QuitMenu"
        Me.QuitMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.QuitMenu.Size = New System.Drawing.Size(154, 22)
        Me.QuitMenu.Text = "&Quit"
        '
        'EditMainMenu
        '
        Me.EditMainMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoMenu, Me.RedoMenu, Me.EditMainMenuSeparator1, Me.CutMenu, Me.CopyMenu, Me.PasteMenu, Me.EditMainMenuSeparator2, Me.SelectAllMenu, Me.EditMainMenuSeparator3, Me.FindAndReplaceMenu, Me.ToolStripSeparator4, Me.ConvertSpacesToTabsMenu, Me.ConvertTabsToSpacesMenu, Me.TrimEndOfLinesMenu, Me.TrimStartOfLinesMenu})
        Me.EditMainMenu.Name = "EditMainMenu"
        Me.EditMainMenu.Size = New System.Drawing.Size(39, 24)
        Me.EditMainMenu.Text = "&Edit"
        '
        'UndoMenu
        '
        Me.UndoMenu.Name = "UndoMenu"
        Me.UndoMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoMenu.Size = New System.Drawing.Size(291, 22)
        Me.UndoMenu.Text = "&Undo"
        '
        'RedoMenu
        '
        Me.RedoMenu.Name = "RedoMenu"
        Me.RedoMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoMenu.Size = New System.Drawing.Size(291, 22)
        Me.RedoMenu.Text = "&Redo"
        '
        'EditMainMenuSeparator1
        '
        Me.EditMainMenuSeparator1.Name = "EditMainMenuSeparator1"
        Me.EditMainMenuSeparator1.Size = New System.Drawing.Size(288, 6)
        '
        'CutMenu
        '
        Me.CutMenu.Name = "CutMenu"
        Me.CutMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutMenu.Size = New System.Drawing.Size(291, 22)
        Me.CutMenu.Text = "Cu&t"
        '
        'CopyMenu
        '
        Me.CopyMenu.Name = "CopyMenu"
        Me.CopyMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyMenu.Size = New System.Drawing.Size(291, 22)
        Me.CopyMenu.Text = "&Copy"
        '
        'PasteMenu
        '
        Me.PasteMenu.Name = "PasteMenu"
        Me.PasteMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteMenu.Size = New System.Drawing.Size(291, 22)
        Me.PasteMenu.Text = "&Paste"
        '
        'EditMainMenuSeparator2
        '
        Me.EditMainMenuSeparator2.Name = "EditMainMenuSeparator2"
        Me.EditMainMenuSeparator2.Size = New System.Drawing.Size(288, 6)
        '
        'SelectAllMenu
        '
        Me.SelectAllMenu.Name = "SelectAllMenu"
        Me.SelectAllMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SelectAllMenu.Size = New System.Drawing.Size(291, 22)
        Me.SelectAllMenu.Text = "Select &All"
        '
        'EditMainMenuSeparator3
        '
        Me.EditMainMenuSeparator3.Name = "EditMainMenuSeparator3"
        Me.EditMainMenuSeparator3.Size = New System.Drawing.Size(288, 6)
        '
        'FindAndReplaceMenu
        '
        Me.FindAndReplaceMenu.Name = "FindAndReplaceMenu"
        Me.FindAndReplaceMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FindAndReplaceMenu.Size = New System.Drawing.Size(291, 22)
        Me.FindAndReplaceMenu.Text = "&Find and Replace"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(288, 6)
        '
        'ConvertSpacesToTabsMenu
        '
        Me.ConvertSpacesToTabsMenu.Name = "ConvertSpacesToTabsMenu"
        Me.ConvertSpacesToTabsMenu.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.ConvertSpacesToTabsMenu.Size = New System.Drawing.Size(291, 22)
        Me.ConvertSpacesToTabsMenu.Text = "Convert &Spaces to Tabs"
        '
        'ConvertTabsToSpacesMenu
        '
        Me.ConvertTabsToSpacesMenu.Name = "ConvertTabsToSpacesMenu"
        Me.ConvertTabsToSpacesMenu.ShortcutKeys = CType((((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.ConvertTabsToSpacesMenu.Size = New System.Drawing.Size(291, 22)
        Me.ConvertTabsToSpacesMenu.Text = "Convert &Tabs To Spaces"
        '
        'TrimEndOfLinesMenu
        '
        Me.TrimEndOfLinesMenu.Name = "TrimEndOfLinesMenu"
        Me.TrimEndOfLinesMenu.ShortcutKeys = CType((((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.TrimEndOfLinesMenu.Size = New System.Drawing.Size(291, 22)
        Me.TrimEndOfLinesMenu.Text = "Trim &End of Lines"
        '
        'TrimStartOfLinesMenu
        '
        Me.TrimStartOfLinesMenu.Name = "TrimStartOfLinesMenu"
        Me.TrimStartOfLinesMenu.ShortcutKeys = CType((((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.TrimStartOfLinesMenu.Size = New System.Drawing.Size(291, 22)
        Me.TrimStartOfLinesMenu.Text = "Trim &Start of Lines"
        '
        'OptionsMainMenu
        '
        Me.OptionsMainMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IndentationMenu, Me.OptionsMainMenuSeparator1, Me.ExternalMenu, Me.HighlightingMenu, Me.OptionsMainMenuSeparator2, Me.InterfaceSelectColorsMenu, Me.SelectFontMenu})
        Me.OptionsMainMenu.Name = "OptionsMainMenu"
        Me.OptionsMainMenu.Size = New System.Drawing.Size(61, 24)
        Me.OptionsMainMenu.Text = "&Options"
        '
        'IndentationMenu
        '
        Me.IndentationMenu.Name = "IndentationMenu"
        Me.IndentationMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.IndentationMenu.Size = New System.Drawing.Size(184, 22)
        Me.IndentationMenu.Text = "&Indentation"
        '
        'OptionsMainMenuSeparator1
        '
        Me.OptionsMainMenuSeparator1.Name = "OptionsMainMenuSeparator1"
        Me.OptionsMainMenuSeparator1.Size = New System.Drawing.Size(181, 6)
        '
        'ExternalMenu
        '
        Me.ExternalMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CaptureOutputMenu, Me.ExternalArgumentsMenu, Me.ExternalProgramMenu, Me.ShowOutputMenu, Me.ShowErrorsMenu})
        Me.ExternalMenu.Name = "ExternalMenu"
        Me.ExternalMenu.Size = New System.Drawing.Size(184, 22)
        Me.ExternalMenu.Text = "&External"
        '
        'CaptureOutputMenu
        '
        Me.CaptureOutputMenu.Name = "CaptureOutputMenu"
        Me.CaptureOutputMenu.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CaptureOutputMenu.Size = New System.Drawing.Size(243, 22)
        Me.CaptureOutputMenu.Text = "&Capture Output"
        '
        'ExternalArgumentsMenu
        '
        Me.ExternalArgumentsMenu.Name = "ExternalArgumentsMenu"
        Me.ExternalArgumentsMenu.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ExternalArgumentsMenu.Size = New System.Drawing.Size(243, 22)
        Me.ExternalArgumentsMenu.Text = "External &Arguments"
        '
        'ExternalProgramMenu
        '
        Me.ExternalProgramMenu.Name = "ExternalProgramMenu"
        Me.ExternalProgramMenu.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExternalProgramMenu.Size = New System.Drawing.Size(243, 22)
        Me.ExternalProgramMenu.Text = "External &Program"
        '
        'ShowOutputMenu
        '
        Me.ShowOutputMenu.Name = "ShowOutputMenu"
        Me.ShowOutputMenu.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.ShowOutputMenu.Size = New System.Drawing.Size(243, 22)
        Me.ShowOutputMenu.Text = "Show &Output"
        '
        'ShowErrorsMenu
        '
        Me.ShowErrorsMenu.Name = "ShowErrorsMenu"
        Me.ShowErrorsMenu.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ShowErrorsMenu.Size = New System.Drawing.Size(243, 22)
        Me.ShowErrorsMenu.Text = "Show &Errors"
        '
        'HighlightingMenu
        '
        Me.HighlightingMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateTemplateMenu, Me.HighlightCodeMenu, Me.LoadTemplateMenu, Me.HighlightingSelectColorsMenu, Me.StopHighlightingMenu})
        Me.HighlightingMenu.Name = "HighlightingMenu"
        Me.HighlightingMenu.Size = New System.Drawing.Size(184, 22)
        Me.HighlightingMenu.Text = "&Highlighting"
        '
        'CreateTemplateMenu
        '
        Me.CreateTemplateMenu.Name = "CreateTemplateMenu"
        Me.CreateTemplateMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.CreateTemplateMenu.Size = New System.Drawing.Size(243, 22)
        Me.CreateTemplateMenu.Text = "&Create Template"
        '
        'HighlightCodeMenu
        '
        Me.HighlightCodeMenu.Name = "HighlightCodeMenu"
        Me.HighlightCodeMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.HighlightCodeMenu.Size = New System.Drawing.Size(243, 22)
        Me.HighlightCodeMenu.Text = "&Highlight Code"
        '
        'LoadTemplateMenu
        '
        Me.LoadTemplateMenu.Name = "LoadTemplateMenu"
        Me.LoadTemplateMenu.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LoadTemplateMenu.Size = New System.Drawing.Size(243, 22)
        Me.LoadTemplateMenu.Text = "&Load Template"
        '
        'HighlightingSelectColorsMenu
        '
        Me.HighlightingSelectColorsMenu.Name = "HighlightingSelectColorsMenu"
        Me.HighlightingSelectColorsMenu.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.HighlightingSelectColorsMenu.Size = New System.Drawing.Size(243, 22)
        Me.HighlightingSelectColorsMenu.Text = "&Select Colors"
        '
        'StopHighlightingMenu
        '
        Me.StopHighlightingMenu.Name = "StopHighlightingMenu"
        Me.StopHighlightingMenu.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.StopHighlightingMenu.Size = New System.Drawing.Size(243, 22)
        Me.StopHighlightingMenu.Text = "&Stop Highlighting"
        '
        'OptionsMainMenuSeparator2
        '
        Me.OptionsMainMenuSeparator2.Name = "OptionsMainMenuSeparator2"
        Me.OptionsMainMenuSeparator2.Size = New System.Drawing.Size(181, 6)
        '
        'InterfaceSelectColorsMenu
        '
        Me.InterfaceSelectColorsMenu.Name = "InterfaceSelectColorsMenu"
        Me.InterfaceSelectColorsMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.InterfaceSelectColorsMenu.Size = New System.Drawing.Size(184, 22)
        Me.InterfaceSelectColorsMenu.Text = "Select &Colors"
        '
        'SelectFontMenu
        '
        Me.SelectFontMenu.Name = "SelectFontMenu"
        Me.SelectFontMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.SelectFontMenu.Size = New System.Drawing.Size(184, 22)
        Me.SelectFontMenu.Text = "Select &Font"
        '
        'ExternalMainMenu
        '
        Me.ExternalMainMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaunchProgramMenu, Me.OpenWithShellMenu})
        Me.ExternalMainMenu.Name = "ExternalMainMenu"
        Me.ExternalMainMenu.Size = New System.Drawing.Size(61, 24)
        Me.ExternalMainMenu.Text = "&External"
        '
        'LaunchProgramMenu
        '
        Me.LaunchProgramMenu.Name = "LaunchProgramMenu"
        Me.LaunchProgramMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LaunchProgramMenu.Size = New System.Drawing.Size(254, 22)
        Me.LaunchProgramMenu.Text = "&Launch Program"
        '
        'OpenWithShellMenu
        '
        Me.OpenWithShellMenu.Name = "OpenWithShellMenu"
        Me.OpenWithShellMenu.ShortcutKeys = CType((((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.OpenWithShellMenu.Size = New System.Drawing.Size(254, 22)
        Me.OpenWithShellMenu.Text = "Open With &Shell"
        '
        'InformationMainMenu
        '
        Me.InformationMainMenu.Name = "InformationMainMenu"
        Me.InformationMainMenu.Size = New System.Drawing.Size(82, 24)
        Me.InformationMainMenu.Text = "&Information"
        '
        'StatusBar
        '
        Me.StatusBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel})
        Me.StatusBar.Location = New System.Drawing.Point(0, 531)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Padding = New System.Windows.Forms.Padding(19, 0, 1, 0)
        Me.StatusBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusBar.Size = New System.Drawing.Size(1145, 22)
        Me.StatusBar.TabIndex = 1
        '
        'StatusLabel
        '
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StatusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'InterfacePanel
        '
        Me.InterfacePanel.BackColor = System.Drawing.SystemColors.Control
        Me.InterfacePanel.Controls.Add(Me.DocumentOutputSplitterBox)
        Me.InterfacePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InterfacePanel.Location = New System.Drawing.Point(0, 23)
        Me.InterfacePanel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.InterfacePanel.Name = "InterfacePanel"
        Me.InterfacePanel.Size = New System.Drawing.Size(859, 409)
        Me.InterfacePanel.TabIndex = 3
        '
        'DocumentOutputSplitterBox
        '
        Me.DocumentOutputSplitterBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DocumentOutputSplitterBox.Location = New System.Drawing.Point(0, 0)
        Me.DocumentOutputSplitterBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DocumentOutputSplitterBox.Name = "DocumentOutputSplitterBox"
        Me.DocumentOutputSplitterBox.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'DocumentOutputSplitterBox.Panel1
        '
        Me.DocumentOutputSplitterBox.Panel1.Controls.Add(Me.TextBox)
        '
        'DocumentOutputSplitterBox.Panel2
        '
        Me.DocumentOutputSplitterBox.Panel2.Controls.Add(Me.OutputErrorSplitterBox)
        Me.DocumentOutputSplitterBox.Panel2Collapsed = True
        Me.DocumentOutputSplitterBox.Size = New System.Drawing.Size(859, 409)
        Me.DocumentOutputSplitterBox.SplitterDistance = 381
        Me.DocumentOutputSplitterBox.SplitterWidth = 3
        Me.DocumentOutputSplitterBox.TabIndex = 0
        '
        'TextBox
        '
        Me.TextBox.AcceptsTab = True
        Me.TextBox.DetectUrls = False
        Me.TextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox.EnableAutoDragDrop = True
        Me.TextBox.HideSelection = False
        Me.TextBox.Location = New System.Drawing.Point(0, 0)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.TextBox.ShortcutsEnabled = False
        Me.TextBox.Size = New System.Drawing.Size(859, 409)
        Me.TextBox.TabIndex = 0
        Me.TextBox.Text = ""
        Me.ToolTip.SetToolTip(Me.TextBox, "Contains the current document.")
        Me.TextBox.WordWrap = False
        '
        'OutputErrorSplitterBox
        '
        Me.OutputErrorSplitterBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OutputErrorSplitterBox.Location = New System.Drawing.Point(0, 0)
        Me.OutputErrorSplitterBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.OutputErrorSplitterBox.Name = "OutputErrorSplitterBox"
        Me.OutputErrorSplitterBox.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'OutputErrorSplitterBox.Panel1
        '
        Me.OutputErrorSplitterBox.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.OutputErrorSplitterBox.Panel1.Controls.Add(Me.OutputBox)
        '
        'OutputErrorSplitterBox.Panel2
        '
        Me.OutputErrorSplitterBox.Panel2.Controls.Add(Me.ErrorBox)
        Me.OutputErrorSplitterBox.Panel2Collapsed = True
        Me.OutputErrorSplitterBox.Size = New System.Drawing.Size(112, 50)
        Me.OutputErrorSplitterBox.SplitterDistance = 25
        Me.OutputErrorSplitterBox.TabIndex = 0
        '
        'OutputBox
        '
        Me.OutputBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OutputBox.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputBox.Location = New System.Drawing.Point(0, 0)
        Me.OutputBox.Multiline = True
        Me.OutputBox.Name = "OutputBox"
        Me.OutputBox.ReadOnly = True
        Me.OutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.OutputBox.Size = New System.Drawing.Size(150, 50)
        Me.OutputBox.TabIndex = 1
        Me.ToolTip.SetToolTip(Me.OutputBox, "Contains the most recent output generated by an external program.")
        Me.OutputBox.WordWrap = False
        '
        'ErrorBox
        '
        Me.ErrorBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ErrorBox.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorBox.Location = New System.Drawing.Point(0, 0)
        Me.ErrorBox.Multiline = True
        Me.ErrorBox.Name = "ErrorBox"
        Me.ErrorBox.ReadOnly = True
        Me.ErrorBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ErrorBox.Size = New System.Drawing.Size(150, 46)
        Me.ErrorBox.TabIndex = 2
        Me.ToolTip.SetToolTip(Me.ErrorBox, "Contains the most recent errors generated by an external program.")
        Me.ErrorBox.WordWrap = False
        '
        'InterfaceWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 449)
        Me.Controls.Add(Me.InterfacePanel)
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.MenuBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuBar
        Me.Name = "InterfaceWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.StatusBar.ResumeLayout(False)
        Me.StatusBar.PerformLayout()
        Me.InterfacePanel.ResumeLayout(False)
        Me.DocumentOutputSplitterBox.Panel1.ResumeLayout(False)
        Me.DocumentOutputSplitterBox.Panel2.ResumeLayout(False)
        CType(Me.DocumentOutputSplitterBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentOutputSplitterBox.ResumeLayout(False)
        Me.OutputErrorSplitterBox.Panel1.ResumeLayout(False)
        Me.OutputErrorSplitterBox.Panel1.PerformLayout()
        Me.OutputErrorSplitterBox.Panel2.ResumeLayout(False)
        Me.OutputErrorSplitterBox.Panel2.PerformLayout()
        CType(Me.OutputErrorSplitterBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OutputErrorSplitterBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuBar As System.Windows.Forms.MenuStrip
   Friend WithEvents FileMainMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents NewMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents OpenMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents SaveAsMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents QuitMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents FileMainMenuSeparator2 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents FileMainMenuSeparator1 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents OptionsMainMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents IndentationMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ExternalMainMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents LaunchProgramMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ExternalMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ExternalProgramMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents CaptureOutputMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents StatusBar As System.Windows.Forms.StatusStrip
   Friend WithEvents StatusLabel As System.Windows.Forms.ToolStripStatusLabel
   Friend WithEvents SaveMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents HighlightingMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents LoadTemplateMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents StopHighlightingMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents HighlightCodeMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents HighlightingSelectColorsMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents CreateTemplateMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents EditMainMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents UndoMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents EditMainMenuSeparator1 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents CutMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents CopyMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents PasteMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents EditMainMenuSeparator2 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents SelectAllMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents RedoMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents EditMainMenuSeparator3 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents TrimEndOfLinesMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents TrimStartOfLinesMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents OptionsMainMenuSeparator1 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents OptionsMainMenuSeparator2 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents SelectFontMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents InformationMainMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents FindAndReplaceMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents InterfaceSelectColorsMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ConvertSpacesToTabsMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ConvertTabsToSpacesMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents PrintMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents FileMainMenuSeparator3 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents ExternalArgumentsMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents InterfacePanel As System.Windows.Forms.Panel
   Friend WithEvents DocumentOutputSplitterBox As System.Windows.Forms.SplitContainer
   Friend WithEvents TextBox As System.Windows.Forms.RichTextBox
   Friend WithEvents OutputErrorSplitterBox As System.Windows.Forms.SplitContainer
   Friend WithEvents OutputBox As System.Windows.Forms.TextBox
   Friend WithEvents ErrorBox As System.Windows.Forms.TextBox
   Friend WithEvents ShowOutputMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ShowErrorsMenu As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
   Friend WithEvents OpenWithShellMenu As System.Windows.Forms.ToolStripMenuItem
End Class
