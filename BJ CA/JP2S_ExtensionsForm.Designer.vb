<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JP2S_ExtensionsForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Ok = New System.Windows.Forms.Button()
        Me.Read = New System.Windows.Forms.Button()
        Me.Abort = New System.Windows.Forms.Button()
        Me.Close_Button = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TableLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TableValue = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ShoeLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ShoeValue = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RoundIdLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RoundIdValue = New System.Windows.Forms.ToolStripStatusLabel()
        Me.CountLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.CountStrategyValue = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RunninCountLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RunningCountValue = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TrueCountLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TrueCountValue = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StrategyLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.NetEVLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.NetEVValue = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.FileLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.FileValue = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RowLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RowValue = New System.Windows.Forms.ToolStripStatusLabel()
        Me.FisrtRowValue = New System.Windows.Forms.TextBox()
        Me.FirstRowLabel = New System.Windows.Forms.Label()
        Me.NbShoeLabel = New System.Windows.Forms.Label()
        Me.NumberOfShoes = New System.Windows.Forms.TextBox()
        Me.Data_GroupBox = New System.Windows.Forms.GroupBox()
        Me.TDS_CheckBox = New System.Windows.Forms.CheckBox()
        Me.TCS_CheckBox = New System.Windows.Forms.CheckBox()
        Me.FS_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Strategy_GroupBox = New System.Windows.Forms.GroupBox()
        Me.CountOnly = New System.Windows.Forms.RadioButton()
        Me.EVOnly = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Analysis_GroupBox = New System.Windows.Forms.GroupBox()
        Me.HILO_CheckBox = New System.Windows.Forms.CheckBox()
        Me.KO_CheckBox = New System.Windows.Forms.CheckBox()
        Me.HIOpt1_CheckBox = New System.Windows.Forms.CheckBox()
        Me.HIOpt2_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Halves_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Omega2_CheckBox = New System.Windows.Forms.CheckBox()
        Me.RedSeven_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Zen_CheckBox = New System.Windows.Forms.CheckBox()
        Me.CountingStrategy_GroupBox = New System.Windows.Forms.GroupBox()
        Me.Clear_Button = New System.Windows.Forms.Button()
        Me.Select_Button = New System.Windows.Forms.Button()
        Me.Save_Extensions = New System.Windows.Forms.Button()
        Me.er = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.StatusStrip2.SuspendLayout()
        Me.Data_GroupBox.SuspendLayout()
        Me.Strategy_GroupBox.SuspendLayout()
        Me.Analysis_GroupBox.SuspendLayout()
        Me.CountingStrategy_GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ok
        '
        Me.Ok.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ok.Location = New System.Drawing.Point(869, 58)
        Me.Ok.Name = "Ok"
        Me.Ok.Size = New System.Drawing.Size(137, 23)
        Me.Ok.TabIndex = 0
        Me.Ok.Text = "Ignore Extensions"
        Me.Ok.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Ok.UseVisualStyleBackColor = True
        '
        'Read
        '
        Me.Read.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Read.Location = New System.Drawing.Point(869, 105)
        Me.Read.Name = "Read"
        Me.Read.Size = New System.Drawing.Size(137, 23)
        Me.Read.TabIndex = 0
        Me.Read.Text = "Process History File"
        Me.Read.UseVisualStyleBackColor = True
        '
        'Abort
        '
        Me.Abort.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Abort.Location = New System.Drawing.Point(869, 152)
        Me.Abort.Name = "Abort"
        Me.Abort.Size = New System.Drawing.Size(137, 23)
        Me.Abort.TabIndex = 0
        Me.Abort.Text = "Abort File Processing"
        Me.Abort.UseVisualStyleBackColor = True
        '
        'Close_Button
        '
        Me.Close_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Close_Button.Location = New System.Drawing.Point(869, 362)
        Me.Close_Button.Name = "Close_Button"
        Me.Close_Button.Size = New System.Drawing.Size(137, 23)
        Me.Close_Button.TabIndex = 0
        Me.Close_Button.Text = "Close"
        Me.Close_Button.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TableLabel, Me.TableValue, Me.ShoeLabel, Me.ShoeValue, Me.RoundIdLabel, Me.RoundIdValue, Me.CountLabel, Me.CountStrategyValue, Me.RunninCountLabel, Me.RunningCountValue, Me.TrueCountLabel, Me.TrueCountValue, Me.StrategyLabel, Me.NetEVLabel, Me.NetEVValue})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1029, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TableLabel
        '
        Me.TableLabel.Name = "TableLabel"
        Me.TableLabel.Size = New System.Drawing.Size(43, 17)
        Me.TableLabel.Text = "Table : "
        '
        'TableValue
        '
        Me.TableValue.Name = "TableValue"
        Me.TableValue.Size = New System.Drawing.Size(57, 17)
        Me.TableValue.Text = "----------"
        Me.TableValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ShoeLabel
        '
        Me.ShoeLabel.Name = "ShoeLabel"
        Me.ShoeLabel.Size = New System.Drawing.Size(39, 17)
        Me.ShoeLabel.Text = "Shoe :"
        '
        'ShoeValue
        '
        Me.ShoeValue.Name = "ShoeValue"
        Me.ShoeValue.Size = New System.Drawing.Size(57, 17)
        Me.ShoeValue.Text = "----------"
        Me.ShoeValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RoundIdLabel
        '
        Me.RoundIdLabel.Name = "RoundIdLabel"
        Me.RoundIdLabel.Size = New System.Drawing.Size(52, 17)
        Me.RoundIdLabel.Text = "RoundId"
        '
        'RoundIdValue
        '
        Me.RoundIdValue.Name = "RoundIdValue"
        Me.RoundIdValue.Size = New System.Drawing.Size(57, 17)
        Me.RoundIdValue.Text = "----------"
        Me.RoundIdValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CountLabel
        '
        Me.CountLabel.Name = "CountLabel"
        Me.CountLabel.Size = New System.Drawing.Size(86, 17)
        Me.CountLabel.Text = "Count Strategy"
        '
        'CountStrategyValue
        '
        Me.CountStrategyValue.Name = "CountStrategyValue"
        Me.CountStrategyValue.Size = New System.Drawing.Size(57, 17)
        Me.CountStrategyValue.Text = "----------"
        Me.CountStrategyValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RunninCountLabel
        '
        Me.RunninCountLabel.Name = "RunninCountLabel"
        Me.RunninCountLabel.Size = New System.Drawing.Size(88, 17)
        Me.RunninCountLabel.Text = "Running Count"
        '
        'RunningCountValue
        '
        Me.RunningCountValue.Name = "RunningCountValue"
        Me.RunningCountValue.Size = New System.Drawing.Size(27, 17)
        Me.RunningCountValue.Text = "----"
        Me.RunningCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TrueCountLabel
        '
        Me.TrueCountLabel.Name = "TrueCountLabel"
        Me.TrueCountLabel.Size = New System.Drawing.Size(65, 17)
        Me.TrueCountLabel.Text = "True Count"
        '
        'TrueCountValue
        '
        Me.TrueCountValue.Name = "TrueCountValue"
        Me.TrueCountValue.Size = New System.Drawing.Size(40, 17)
        Me.TrueCountValue.Text = "---.---"
        Me.TrueCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'StrategyLabel
        '
        Me.StrategyLabel.Name = "StrategyLabel"
        Me.StrategyLabel.Size = New System.Drawing.Size(112, 17)
        Me.StrategyLabel.Text = "---------------------"
        Me.StrategyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NetEVLabel
        '
        Me.NetEVLabel.Name = "NetEVLabel"
        Me.NetEVLabel.Size = New System.Drawing.Size(42, 17)
        Me.NetEVLabel.Text = "Net EV"
        '
        'NetEVValue
        '
        Me.NetEVValue.Name = "NetEVValue"
        Me.NetEVValue.Size = New System.Drawing.Size(92, 17)
        Me.NetEVValue.Text = "-----------------"
        Me.NetEVValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'StatusStrip2
        '
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileLabel, Me.FileValue, Me.RowLabel, Me.RowValue})
        Me.StatusStrip2.Location = New System.Drawing.Point(0, 406)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(1029, 22)
        Me.StatusStrip2.TabIndex = 2
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'FileLabel
        '
        Me.FileLabel.Name = "FileLabel"
        Me.FileLabel.Size = New System.Drawing.Size(31, 17)
        Me.FileLabel.Text = "File: "
        '
        'FileValue
        '
        Me.FileValue.Name = "FileValue"
        Me.FileValue.Size = New System.Drawing.Size(897, 17)
        Me.FileValue.Spring = True
        Me.FileValue.Text = "-----"
        Me.FileValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RowLabel
        '
        Me.RowLabel.Name = "RowLabel"
        Me.RowLabel.Size = New System.Drawing.Size(39, 17)
        Me.RowLabel.Text = "Row : "
        '
        'RowValue
        '
        Me.RowValue.Name = "RowValue"
        Me.RowValue.Size = New System.Drawing.Size(47, 17)
        Me.RowValue.Text = "--------"
        Me.RowValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FisrtRowValue
        '
        Me.FisrtRowValue.Location = New System.Drawing.Point(121, 27)
        Me.FisrtRowValue.Name = "FisrtRowValue"
        Me.FisrtRowValue.Size = New System.Drawing.Size(100, 20)
        Me.FisrtRowValue.TabIndex = 3
        Me.FisrtRowValue.Text = "2"
        Me.FisrtRowValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FirstRowLabel
        '
        Me.FirstRowLabel.AutoSize = True
        Me.FirstRowLabel.Location = New System.Drawing.Point(1, 30)
        Me.FirstRowLabel.Name = "FirstRowLabel"
        Me.FirstRowLabel.Size = New System.Drawing.Size(51, 13)
        Me.FirstRowLabel.TabIndex = 4
        Me.FirstRowLabel.Text = "First Row"
        '
        'NbShoeLabel
        '
        Me.NbShoeLabel.AutoSize = True
        Me.NbShoeLabel.Location = New System.Drawing.Point(1, 70)
        Me.NbShoeLabel.Name = "NbShoeLabel"
        Me.NbShoeLabel.Size = New System.Drawing.Size(95, 13)
        Me.NbShoeLabel.TabIndex = 4
        Me.NbShoeLabel.Text = "Number of Schoes"
        '
        'NumberOfShoes
        '
        Me.NumberOfShoes.Location = New System.Drawing.Point(121, 67)
        Me.NumberOfShoes.Name = "NumberOfShoes"
        Me.NumberOfShoes.Size = New System.Drawing.Size(100, 20)
        Me.NumberOfShoes.TabIndex = 3
        Me.NumberOfShoes.Text = "2"
        Me.NumberOfShoes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Data_GroupBox
        '
        Me.Data_GroupBox.Controls.Add(Me.NbShoeLabel)
        Me.Data_GroupBox.Controls.Add(Me.FirstRowLabel)
        Me.Data_GroupBox.Controls.Add(Me.NumberOfShoes)
        Me.Data_GroupBox.Controls.Add(Me.FisrtRowValue)
        Me.Data_GroupBox.Location = New System.Drawing.Point(11, 32)
        Me.Data_GroupBox.Name = "Data_GroupBox"
        Me.Data_GroupBox.Size = New System.Drawing.Size(232, 95)
        Me.Data_GroupBox.TabIndex = 5
        Me.Data_GroupBox.TabStop = False
        Me.Data_GroupBox.Text = "Data"
        '
        'TDS_CheckBox
        '
        Me.TDS_CheckBox.AutoSize = True
        Me.TDS_CheckBox.Location = New System.Drawing.Point(6, 25)
        Me.TDS_CheckBox.Name = "TDS_CheckBox"
        Me.TDS_CheckBox.Size = New System.Drawing.Size(148, 17)
        Me.TDS_CheckBox.TabIndex = 6
        Me.TDS_CheckBox.Text = "Total Dependent Strategy"
        Me.TDS_CheckBox.UseVisualStyleBackColor = True
        '
        'TCS_CheckBox
        '
        Me.TCS_CheckBox.AutoSize = True
        Me.TCS_CheckBox.Location = New System.Drawing.Point(6, 54)
        Me.TCS_CheckBox.Name = "TCS_CheckBox"
        Me.TCS_CheckBox.Size = New System.Drawing.Size(104, 17)
        Me.TCS_CheckBox.TabIndex = 6
        Me.TCS_CheckBox.Text = "2-Cards Strategy"
        Me.TCS_CheckBox.UseVisualStyleBackColor = True
        '
        'FS_CheckBox
        '
        Me.FS_CheckBox.AutoSize = True
        Me.FS_CheckBox.Location = New System.Drawing.Point(6, 83)
        Me.FS_CheckBox.Name = "FS_CheckBox"
        Me.FS_CheckBox.Size = New System.Drawing.Size(101, 17)
        Me.FS_CheckBox.TabIndex = 6
        Me.FS_CheckBox.Text = "Forced Strategy"
        Me.FS_CheckBox.UseVisualStyleBackColor = True
        '
        'Strategy_GroupBox
        '
        Me.Strategy_GroupBox.Controls.Add(Me.FS_CheckBox)
        Me.Strategy_GroupBox.Controls.Add(Me.TCS_CheckBox)
        Me.Strategy_GroupBox.Controls.Add(Me.TDS_CheckBox)
        Me.Strategy_GroupBox.Location = New System.Drawing.Point(11, 266)
        Me.Strategy_GroupBox.Name = "Strategy_GroupBox"
        Me.Strategy_GroupBox.Size = New System.Drawing.Size(232, 119)
        Me.Strategy_GroupBox.TabIndex = 7
        Me.Strategy_GroupBox.TabStop = False
        Me.Strategy_GroupBox.Text = "Net EV Strategies"
        '
        'CountOnly
        '
        Me.CountOnly.AutoSize = True
        Me.CountOnly.Location = New System.Drawing.Point(6, 19)
        Me.CountOnly.Name = "CountOnly"
        Me.CountOnly.Size = New System.Drawing.Size(77, 17)
        Me.CountOnly.TabIndex = 8
        Me.CountOnly.TabStop = True
        Me.CountOnly.Text = "Count Only"
        Me.CountOnly.UseVisualStyleBackColor = True
        '
        'EVOnly
        '
        Me.EVOnly.AutoSize = True
        Me.EVOnly.Location = New System.Drawing.Point(6, 46)
        Me.EVOnly.Name = "EVOnly"
        Me.EVOnly.Size = New System.Drawing.Size(83, 17)
        Me.EVOnly.TabIndex = 8
        Me.EVOnly.TabStop = True
        Me.EVOnly.Text = "Net EV Only"
        Me.EVOnly.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 73)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(153, 17)
        Me.RadioButton3.TabIndex = 8
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Count And Net EV Analysis"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'Analysis_GroupBox
        '
        Me.Analysis_GroupBox.Controls.Add(Me.RadioButton3)
        Me.Analysis_GroupBox.Controls.Add(Me.EVOnly)
        Me.Analysis_GroupBox.Controls.Add(Me.CountOnly)
        Me.Analysis_GroupBox.Location = New System.Drawing.Point(11, 143)
        Me.Analysis_GroupBox.Name = "Analysis_GroupBox"
        Me.Analysis_GroupBox.Size = New System.Drawing.Size(232, 107)
        Me.Analysis_GroupBox.TabIndex = 9
        Me.Analysis_GroupBox.TabStop = False
        Me.Analysis_GroupBox.Text = "Analysis"
        '
        'HILO_CheckBox
        '
        Me.HILO_CheckBox.AutoSize = True
        Me.HILO_CheckBox.Location = New System.Drawing.Point(6, 31)
        Me.HILO_CheckBox.Name = "HILO_CheckBox"
        Me.HILO_CheckBox.Size = New System.Drawing.Size(51, 17)
        Me.HILO_CheckBox.TabIndex = 10
        Me.HILO_CheckBox.Text = "Hi-Lo"
        Me.HILO_CheckBox.UseVisualStyleBackColor = True
        '
        'KO_CheckBox
        '
        Me.KO_CheckBox.AutoSize = True
        Me.KO_CheckBox.Location = New System.Drawing.Point(6, 60)
        Me.KO_CheckBox.Name = "KO_CheckBox"
        Me.KO_CheckBox.Size = New System.Drawing.Size(44, 17)
        Me.KO_CheckBox.TabIndex = 10
        Me.KO_CheckBox.Text = "K-O"
        Me.KO_CheckBox.UseVisualStyleBackColor = True
        '
        'HIOpt1_CheckBox
        '
        Me.HIOpt1_CheckBox.AutoSize = True
        Me.HIOpt1_CheckBox.Location = New System.Drawing.Point(6, 89)
        Me.HIOpt1_CheckBox.Name = "HIOpt1_CheckBox"
        Me.HIOpt1_CheckBox.Size = New System.Drawing.Size(76, 17)
        Me.HIOpt1_CheckBox.TabIndex = 10
        Me.HIOpt1_CheckBox.Text = "Hi-Option I"
        Me.HIOpt1_CheckBox.UseVisualStyleBackColor = True
        '
        'HIOpt2_CheckBox
        '
        Me.HIOpt2_CheckBox.AutoSize = True
        Me.HIOpt2_CheckBox.Location = New System.Drawing.Point(6, 118)
        Me.HIOpt2_CheckBox.Name = "HIOpt2_CheckBox"
        Me.HIOpt2_CheckBox.Size = New System.Drawing.Size(79, 17)
        Me.HIOpt2_CheckBox.TabIndex = 10
        Me.HIOpt2_CheckBox.Text = "Hi-Option II"
        Me.HIOpt2_CheckBox.UseVisualStyleBackColor = True
        '
        'Halves_CheckBox
        '
        Me.Halves_CheckBox.AutoSize = True
        Me.Halves_CheckBox.Location = New System.Drawing.Point(6, 147)
        Me.Halves_CheckBox.Name = "Halves_CheckBox"
        Me.Halves_CheckBox.Size = New System.Drawing.Size(59, 17)
        Me.Halves_CheckBox.TabIndex = 10
        Me.Halves_CheckBox.Text = "Halves"
        Me.Halves_CheckBox.UseVisualStyleBackColor = True
        '
        'Omega2_CheckBox
        '
        Me.Omega2_CheckBox.AutoSize = True
        Me.Omega2_CheckBox.Location = New System.Drawing.Point(6, 176)
        Me.Omega2_CheckBox.Name = "Omega2_CheckBox"
        Me.Omega2_CheckBox.Size = New System.Drawing.Size(69, 17)
        Me.Omega2_CheckBox.TabIndex = 10
        Me.Omega2_CheckBox.Text = "Omega II"
        Me.Omega2_CheckBox.UseVisualStyleBackColor = True
        '
        'RedSeven_CheckBox
        '
        Me.RedSeven_CheckBox.AutoSize = True
        Me.RedSeven_CheckBox.Location = New System.Drawing.Point(6, 205)
        Me.RedSeven_CheckBox.Name = "RedSeven_CheckBox"
        Me.RedSeven_CheckBox.Size = New System.Drawing.Size(80, 17)
        Me.RedSeven_CheckBox.TabIndex = 10
        Me.RedSeven_CheckBox.Text = "Red Seven"
        Me.RedSeven_CheckBox.UseVisualStyleBackColor = True
        '
        'Zen_CheckBox
        '
        Me.Zen_CheckBox.AutoSize = True
        Me.Zen_CheckBox.Location = New System.Drawing.Point(6, 234)
        Me.Zen_CheckBox.Name = "Zen_CheckBox"
        Me.Zen_CheckBox.Size = New System.Drawing.Size(45, 17)
        Me.Zen_CheckBox.TabIndex = 10
        Me.Zen_CheckBox.Text = "Zen"
        Me.Zen_CheckBox.UseVisualStyleBackColor = True
        '
        'CountingStrategy_GroupBox
        '
        Me.CountingStrategy_GroupBox.Controls.Add(Me.Clear_Button)
        Me.CountingStrategy_GroupBox.Controls.Add(Me.Select_Button)
        Me.CountingStrategy_GroupBox.Controls.Add(Me.HILO_CheckBox)
        Me.CountingStrategy_GroupBox.Controls.Add(Me.Zen_CheckBox)
        Me.CountingStrategy_GroupBox.Controls.Add(Me.KO_CheckBox)
        Me.CountingStrategy_GroupBox.Controls.Add(Me.RedSeven_CheckBox)
        Me.CountingStrategy_GroupBox.Controls.Add(Me.HIOpt1_CheckBox)
        Me.CountingStrategy_GroupBox.Controls.Add(Me.Omega2_CheckBox)
        Me.CountingStrategy_GroupBox.Controls.Add(Me.HIOpt2_CheckBox)
        Me.CountingStrategy_GroupBox.Controls.Add(Me.Halves_CheckBox)
        Me.CountingStrategy_GroupBox.Location = New System.Drawing.Point(270, 32)
        Me.CountingStrategy_GroupBox.Name = "CountingStrategy_GroupBox"
        Me.CountingStrategy_GroupBox.Size = New System.Drawing.Size(200, 353)
        Me.CountingStrategy_GroupBox.TabIndex = 11
        Me.CountingStrategy_GroupBox.TabStop = False
        Me.CountingStrategy_GroupBox.Text = "Counting Strategies"
        '
        'Clear_Button
        '
        Me.Clear_Button.Location = New System.Drawing.Point(98, 271)
        Me.Clear_Button.Name = "Clear_Button"
        Me.Clear_Button.Size = New System.Drawing.Size(73, 33)
        Me.Clear_Button.TabIndex = 11
        Me.Clear_Button.Text = "Clear All"
        Me.Clear_Button.UseVisualStyleBackColor = True
        '
        'Select_Button
        '
        Me.Select_Button.Location = New System.Drawing.Point(8, 271)
        Me.Select_Button.Name = "Select_Button"
        Me.Select_Button.Size = New System.Drawing.Size(73, 33)
        Me.Select_Button.TabIndex = 11
        Me.Select_Button.Text = "Select All"
        Me.Select_Button.UseVisualStyleBackColor = True
        '
        'Save_Extensions
        '
        Me.Save_Extensions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Save_Extensions.Location = New System.Drawing.Point(869, 202)
        Me.Save_Extensions.Name = "Save_Extensions"
        Me.Save_Extensions.Size = New System.Drawing.Size(137, 23)
        Me.Save_Extensions.TabIndex = 0
        Me.Save_Extensions.Text = "Save Extensions"
        Me.Save_Extensions.UseVisualStyleBackColor = True
        '
        'er
        '
        Me.er.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.er.Location = New System.Drawing.Point(869, 246)
        Me.er.Name = "er"
        Me.er.Size = New System.Drawing.Size(137, 23)
        Me.er.TabIndex = 0
        Me.er.Text = "Load Extensions"
        Me.er.UseVisualStyleBackColor = True
        '
        'JP2S_ExtensionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 450)
        Me.Controls.Add(Me.Analysis_GroupBox)
        Me.Controls.Add(Me.Strategy_GroupBox)
        Me.Controls.Add(Me.Data_GroupBox)
        Me.Controls.Add(Me.StatusStrip2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Close_Button)
        Me.Controls.Add(Me.er)
        Me.Controls.Add(Me.Save_Extensions)
        Me.Controls.Add(Me.Abort)
        Me.Controls.Add(Me.Read)
        Me.Controls.Add(Me.Ok)
        Me.Controls.Add(Me.CountingStrategy_GroupBox)
        Me.Name = "JP2S_ExtensionsForm"
        Me.Text = "JP2S_Extensions"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        Me.Data_GroupBox.ResumeLayout(False)
        Me.Data_GroupBox.PerformLayout()
        Me.Strategy_GroupBox.ResumeLayout(False)
        Me.Strategy_GroupBox.PerformLayout()
        Me.Analysis_GroupBox.ResumeLayout(False)
        Me.Analysis_GroupBox.PerformLayout()
        Me.CountingStrategy_GroupBox.ResumeLayout(False)
        Me.CountingStrategy_GroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Ok As Button
    Friend WithEvents Read As Button
    Friend WithEvents Abort As Button
    Friend WithEvents Close_Button As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TableLabel As ToolStripStatusLabel
    Friend WithEvents TableValue As ToolStripStatusLabel
    Friend WithEvents ShoeLabel As ToolStripStatusLabel
    Friend WithEvents ShoeValue As ToolStripStatusLabel
    Friend WithEvents RoundIdLabel As ToolStripStatusLabel
    Friend WithEvents RoundIdValue As ToolStripStatusLabel
    Friend WithEvents CountLabel As ToolStripStatusLabel
    Friend WithEvents CountStrategyValue As ToolStripStatusLabel
    Friend WithEvents RunninCountLabel As ToolStripStatusLabel
    Friend WithEvents RunningCountValue As ToolStripStatusLabel
    Friend WithEvents TrueCountLabel As ToolStripStatusLabel
    Friend WithEvents TrueCountValue As ToolStripStatusLabel
    Friend WithEvents StatusStrip2 As StatusStrip
    Friend WithEvents FileLabel As ToolStripStatusLabel
    Friend WithEvents FileValue As ToolStripStatusLabel
    Friend WithEvents NetEVLabel As ToolStripStatusLabel
    Friend WithEvents NetEVValue As ToolStripStatusLabel
    Friend WithEvents RowLabel As ToolStripStatusLabel
    Friend WithEvents RowValue As ToolStripStatusLabel
    Friend WithEvents StrategyLabel As ToolStripStatusLabel
    Friend WithEvents FisrtRowValue As TextBox
    Friend WithEvents FirstRowLabel As Label
    Friend WithEvents NbShoeLabel As Label
    Friend WithEvents NumberOfShoes As TextBox
    Friend WithEvents Data_GroupBox As GroupBox
    Friend WithEvents TDS_CheckBox As CheckBox
    Friend WithEvents TCS_CheckBox As CheckBox
    Friend WithEvents FS_CheckBox As CheckBox
    Friend WithEvents Strategy_GroupBox As GroupBox
    Friend WithEvents CountOnly As RadioButton
    Friend WithEvents EVOnly As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Analysis_GroupBox As GroupBox
    Friend WithEvents HILO_CheckBox As CheckBox
    Friend WithEvents KO_CheckBox As CheckBox
    Friend WithEvents HIOpt1_CheckBox As CheckBox
    Friend WithEvents HIOpt2_CheckBox As CheckBox
    Friend WithEvents Halves_CheckBox As CheckBox
    Friend WithEvents Omega2_CheckBox As CheckBox
    Friend WithEvents RedSeven_CheckBox As CheckBox
    Friend WithEvents Zen_CheckBox As CheckBox
    Friend WithEvents CountingStrategy_GroupBox As GroupBox
    Friend WithEvents Clear_Button As Button
    Friend WithEvents Select_Button As Button
    Friend WithEvents Save_Extensions As Button
    Friend WithEvents er As Button
End Class
