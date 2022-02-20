Imports BJ_CA.BJCAShared
Imports BJ_CA.GameHistoryFile
Public Class BJCA_JP2S_ExtensionsForm

    Const JP2S_SUBPATH As String = "\JP2S"
    Dim jp2s_Path As String
    Dim ghf As New GameHistoryFile
    Dim fileOK As Boolean
    Dim Aborted As Boolean
    Dim Shoe As Long
    Dim Row As Long
    Dim CanClose As Boolean
    Dim InProgress As Boolean

    Dim ExtensionResult As eExtensions

    Public Enum eExtensions
        undefined = 0
        ignoreExtensions = 1
        processHistoryFile = 2
        Abort = 3
    End Enum
    Public Function Exists() As Boolean
        jp2s_Path = CurDir() + JP2S_SUBPATH
        Exists = My.Computer.FileSystem.DirectoryExists(jp2s_Path)
    End Function
    Private Sub Ok_Click(sender As Object, e As EventArgs) Handles Ok.Click
        ExtensionResult = eExtensions.ignoreExtensions
        Close()
    End Sub

    Private Sub Read_Click(sender As Object, e As EventArgs) Handles Read.Click
        ExtensionResult = eExtensions.processHistoryFile
        StartProcessing()
        'wait for selection
        Do While InProgress
            ' wait for answer
            Threading.Thread.Sleep(100)
            Application.DoEvents()
        Loop
        EndProcessing()
    End Sub

    Private Sub Abort_Click(sender As Object, e As EventArgs) Handles Abort.Click
        Aborted = True
        Abort.Enabled = False
        ExtensionResult = eExtensions.Abort
    End Sub

    Public ReadOnly Property HistoryFile As GameHistoryFile
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

    Public ReadOnly Property Result As eExtensions
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
        ExtensionResult = eExtensions.undefined
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
    End Sub

    Public Sub updateStatusBar(ByRef filePath As String, Row As Long, Table As String, Shoe As Long, RoundId As Long, CountStrategy As String, RunningCount As Long, TrueCount As Double, Strategy As String, NetEV As Double)
        FileValue.Text = filePath
        RowValue.Text = Row
        If Table.Length > 0 Then TableValue.Text = Table
        If Shoe > 0 Then ShoeValue.Text = Shoe
        RoundIdValue.Text = RoundId
        CountStrategyValue.Text = CountStrategy
        RunningCountValue.Text = RunningCount
        TrueCountValue.Text = TrueCount
        StrategyLabel.Text = Strategy
        NetEVValue.Text = NetEV
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

    Public ReadOnly Property firstRow As Long
        Get
            Dim row As Long
            row = Convert.ToInt64(FisrtRowValue.Text)
            If row < 2 Then row = 2
            Return row
        End Get
    End Property

    Public ReadOnly Property NumberOfShoe As Long
        Get
            Dim n As Long
            n = Convert.ToInt64(NumberOfShoes.Text)
            If n < 1 Then n = 1
            Return n
        End Get
    End Property



End Class