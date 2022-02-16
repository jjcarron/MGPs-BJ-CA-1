Imports Microsoft.Office.Interop
Imports BJ_CA.BJCAShared
Imports System.Text.RegularExpressions
Public Class GameHistoryFile
    Dim Open As Boolean
    Dim xlApp As Excel.Application
    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet
    Public Function OpenFile(name As String) As Boolean
        xlApp = New Excel.ApplicationClass
        Try
            xlWorkBook = xlApp.Workbooks.Open(name)
            xlWorkSheet = xlWorkBook.Worksheets("Data")
            Open = True
        Catch
            Open = False
        End Try
        OpenFile = Open
    End Function
    Public Function fileOpen() As Boolean
        fileOpen = Open
    End Function
    Public Function SaveCloseFile(name As String) As Boolean
        If Open Then
            Try
                xlWorkBook.SaveAs(name)
                xlWorkBook.Close()
                xlApp = Nothing
                Open = False
            Catch ex As Exception
                MsgBox("The file " + name + " cannot be saved", vbOKOnly, "Warning")
            End Try
        End If
        xlWorkBook.Close()
    End Function


    Public Function getline(row As Long, ByRef Table As String, ByRef shoeCode As Long, ByRef RoundId As Long, cards As MatchCollection) As Boolean
        Try
            Table = xlWorkSheet.Cells(row, 1).text
            shoeCode = xlWorkSheet.Cells(row, 2).value2
            RoundId = xlWorkSheet.Cells(row, 3).value2
            cards = Regex.Matches(xlWorkSheet.Cells(row, 4).text, "(\'[CDSH][0-9QKAJ]{1,2}\'\,)", RegexOptions.IgnoreCase)
            getline = True
        Catch ex As Exception
            getline = False
        End Try
    End Function
End Class
