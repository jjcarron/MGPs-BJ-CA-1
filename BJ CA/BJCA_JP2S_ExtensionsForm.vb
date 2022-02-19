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

End Class