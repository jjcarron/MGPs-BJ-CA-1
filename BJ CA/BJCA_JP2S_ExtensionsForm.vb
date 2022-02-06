Imports BJ_CA.BJCAShared

Public Class BJCA_JP2S_ExtensionsForm

    Const JP2S_SUBPATH As String = "\JP2S"
    Dim jp2s_Path As String

    Public Function Exists() As Boolean
        jp2s_Path = CurDir() + JP2S_SUBPATH
        Exists = My.Computer.FileSystem.DirectoryExists(jp2s_Path)
    End Function
    Private Sub Ok_Click(sender As Object, e As EventArgs) Handles Ok.Click
        Me.Close()
    End Sub
End Class