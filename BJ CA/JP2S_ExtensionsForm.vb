Imports BJ_CA.BJCAShared
Imports BJ_CA.JP2S_GameHistoryFile
Imports BJ_CA.JP2S_CardCounter

<Serializable()> Public Class JP2S_ExtensionsForm

    Const JP2S_SUBPATH As String = "\JP2S"
    Dim jp2s_Path As String
    Dim ghf As New JP2S_GameHistoryFile
    Dim fileOK As Boolean
    Dim Aborted As Boolean
    Dim Shoe As Long
    Dim Row As Long
    Dim CanClose As Boolean
    Dim InProgress As Boolean
    Dim ExtensionResult As Extensions
    Public CountStrategies As Count_Strategies
    Public FirstRow As Long
    Public NumberOfShoe As Long

    Dim FileText As String
    Dim RowVal As Long
    Dim TableText As String
    Dim ShoeId As Long
    Dim RoundId As Long
    Dim CountStrategyText As String
    Dim RunningCountVal As Long
    Dim TrueCountVal As Double
    Dim StrategyText As String
    Dim NetEVVal As Double

    Public Enum Extensions
        undefined
        ignoreExtensions
        processHistoryFile
        Abort
    End Enum
    Public Function Exists() As Boolean
        jp2s_Path = CurDir() + JP2S_SUBPATH
        Exists = My.Computer.FileSystem.DirectoryExists(jp2s_Path)
    End Function
    Private Sub Ok_Click(sender As Object, e As EventArgs) Handles Ok.Click
        ExtensionResult = Extensions.ignoreExtensions
        Close()
    End Sub

    Private Sub Read_Click(sender As Object, e As EventArgs) Handles Read.Click
        If Not InProgress Then
            ExtensionResult = Extensions.processHistoryFile
            StartProcessing()
            ReadExtensionsParamers()
            'wait for selection
            Do While InProgress
                ' wait for answer
                Threading.Thread.Sleep(20)
                If RowVal > 0 Then updateStatusbar() ' ensure that the process is started
                Application.DoEvents()
            Loop
            EndProcessing()
        End If
    End Sub

    Private Sub Abort_Click(sender As Object, e As EventArgs) Handles Abort.Click
        Aborted = True
        Abort.Enabled = False
        ExtensionResult = Extensions.Abort
    End Sub

    Public ReadOnly Property HistoryFile As JP2S_GameHistoryFile
        Get
            If fileOK Then
                Return ghf
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public ReadOnly Property AbortProcess As Boolean
        Get
            Return Aborted
        End Get
    End Property

    Public ReadOnly Property Result As Extensions
        Get
            Return ExtensionResult
        End Get
    End Property

    Private Sub BJCA_JP2S_ExtensionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Abort.Enabled = False
        CanClose = True
        CountOnly.Checked = True
    End Sub

    Private Sub EndProcessing()
        CanClose = True
        Close_Button.Enabled = True
        Abort.Enabled = False
        Read.Enabled = True
        Ok.Enabled = True
        ExtensionResult = Extensions.undefined
    End Sub

    Private Sub StartProcessing()
        InProgress = True
        CanClose = False
        Close_Button.Enabled = False
        Abort.Enabled = True
        Read.Enabled = False
        Ok.Enabled = False
    End Sub

    Public Function openHistoryFile(fullPath As String) As Boolean
        openHistoryFile = ghf.OpenFile(fullPath)
    End Function
    Private Sub Close_Button_Click(sender As Object, e As EventArgs) Handles Close_Button.Click
        Close()
    End Sub

    Public Sub EndOfProcessing()
        InProgress = False
        ExtensionResult = Extensions.undefined
    End Sub

    Public Sub updateStatusBarValues(ByRef filePath As String, Row As Long, Table As String, Shoe As Long, Round As Long, CountStrategy As String, RunningCount As Long, TrueCount As Double, Strategy As String, NetEV As Double)
        FileText = filePath
        RowVal = Row
        TableText = Table
        ShoeId = Shoe
        RoundId = Round
        CountStrategyText = CountStrategy
        RunningCountVal = RunningCount
        TrueCountVal = TrueCount
        StrategyText = Strategy
        NetEVVal = NetEV
    End Sub
    Private Sub updateStatusbar()
        FileValue.Text = FileText
        RowValue.Text = RowVal
        If TableText.Length > 0 Then TableValue.Text = TableText
        If ShoeId > 0 Then ShoeValue.Text = ShoeId
        RoundIdValue.Text = RoundId
        CountStrategyValue.Text = CountStrategyText
        RunningCountValue.Text = RunningCountVal
        TrueCountValue.Text = TrueCountVal
        StrategyLabel.Text = StrategyText
        NetEVValue.Text = NetEVVal
    End Sub
    Private Sub Select_Button_Click(sender As Object, e As EventArgs) Handles Select_Button.Click
        HILO_CheckBox.CheckState = CheckState.Checked
        KO_CheckBox.CheckState = CheckState.Checked
        HIOpt1_CheckBox.CheckState = CheckState.Checked
        HIOpt2_CheckBox.CheckState = CheckState.Checked
        Halves_CheckBox.CheckState = CheckState.Checked
        Omega2_CheckBox.CheckState = CheckState.Checked
        RedSeven_CheckBox.CheckState = CheckState.Checked
        Zen_CheckBox.CheckState = CheckState.Checked
    End Sub

    Private Sub Clear_Button_Click(sender As Object, e As EventArgs) Handles Clear_Button.Click
        HILO_CheckBox.CheckState = CheckState.Unchecked
        KO_CheckBox.CheckState = CheckState.Unchecked
        HIOpt1_CheckBox.CheckState = CheckState.Unchecked
        HIOpt2_CheckBox.CheckState = CheckState.Unchecked
        Halves_CheckBox.CheckState = CheckState.Unchecked
        Omega2_CheckBox.CheckState = CheckState.Unchecked
        RedSeven_CheckBox.CheckState = CheckState.Unchecked
        Zen_CheckBox.CheckState = CheckState.Unchecked
    End Sub

    Private Sub CountOnly_CheckedChanged(sender As Object, e As EventArgs) Handles CountOnly.CheckedChanged
        Strategy_GroupBox.Enabled = False
        CountingStrategy_GroupBox.Enabled = True
    End Sub

    Private Sub EVOnly_CheckedChanged(sender As Object, e As EventArgs) Handles EVOnly.CheckedChanged
        Strategy_GroupBox.Enabled = True
        CountingStrategy_GroupBox.Enabled = False
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Strategy_GroupBox.Enabled = True
        CountingStrategy_GroupBox.Enabled = True
    End Sub

    Private Sub ReadExtensionsParamers()
        CountStrategies = 0
        If HILO_CheckBox.Checked Then CountStrategies += Count_Strategies_Flags.Hi_Lo
        If KO_CheckBox.Checked Then CountStrategies += Count_Strategies_Flags.K_O
        If HIOpt1_CheckBox.Checked Then CountStrategies += Count_Strategies_Flags.Hi_Opt1
        If HIOpt2_CheckBox.Checked Then CountStrategies += Count_Strategies_Flags.Hi_Opt2
        If Halves_CheckBox.Checked Then CountStrategies += Count_Strategies_Flags.Halves
        If Omega2_CheckBox.Checked Then CountStrategies += Count_Strategies_Flags.Omega_2
        If RedSeven_CheckBox.Checked Then CountStrategies += Count_Strategies_Flags.Red_Seven
        If Zen_CheckBox.Checked Then CountStrategies += Count_Strategies_Flags.Zen
        FirstRow = Convert.ToInt64(FisrtRowValue.Text)
        NumberOfShoe = Convert.ToInt64(NumberOfShoes.Text)
        If NumberOfShoe < 1 Then NumberOfShoe = 1
    End Sub

    Private Sub FisrtRowValue_Leave(sender As Object, e As EventArgs) Handles FisrtRowValue.Leave
        FirstRow = Convert.ToInt64(FisrtRowValue.Text)
        If FirstRow < 2 Then FirstRow = 2
    End Sub

    Private Sub NumberOfShoes_Leave(sender As Object, e As EventArgs) Handles NumberOfShoes.Leave
        NumberOfShoe = Convert.ToInt64(NumberOfShoes.Text)
        If NumberOfShoe < 1 Then NumberOfShoe = 1
    End Sub

    Private Sub SaveExtensions_Click(sender As Object, e As EventArgs) Handles Save_Extensions.Click

    End Sub

    Private Sub LoadExtensions_Click(sender As Object, e As EventArgs) Handles er.Click

    End Sub

    Public ReadOnly Property CountOnlyAnalysis As Boolean
        Get
            Return CountOnly.Checked
        End Get
    End Property
End Class