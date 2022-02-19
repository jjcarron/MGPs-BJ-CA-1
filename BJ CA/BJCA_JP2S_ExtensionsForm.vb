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
    End Sub

    Private Sub Read_Click(sender As Object, e As EventArgs) Handles Read.Click
        Dim ofd As New OpenFileDialog

        Abort.Enabled = True
        Ok.Enabled = False

        ofd.CheckFileExists = True
        ofd.CheckPathExists = True
        ofd.AddExtension = True
        ofd.DefaultExt = ".xlsx"
        ofd.FileName = "Games.xlsx"
        ofd.InitialDirectory = My.Computer.FileSystem.CurrentDirectory + "\JP2S\"
        ofd.Filter = "Game Files (*.xlsx)|*.xlsx"
        ofd.ValidateNames = True
        If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'load file here
            'MsgBox("The file: " + GetFileName(ofd.FileName) + " is a Game file.")

            fileOK = ghf.OpenFile(ofd.FileName)

            If fileOK Then
                'process file here
                'LoadFormForcedShoe()
            Else
                MsgBox("The file: " + GetFileName(ofd.FileName) + " is not a valid Forced Shoe file.")
            End If
        End If
        ofd.Dispose()
        ExtensionResult = eExtensions.processHistoryFile
    End Sub

    Private Sub Abort_Click(sender As Object, e As EventArgs) Handles Abort.Click
        Aborted = True
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
    End Sub
End Class