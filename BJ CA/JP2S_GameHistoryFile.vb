Imports Microsoft.Office.Interop
Imports BJ_CA.BJCAShared
Imports System.Text.RegularExpressions
Imports Microsoft.Office.Interop.Excel

Public Class JP2S_GameHistoryFile
    Dim Open As Boolean
    Dim xlApp As Excel.Application
    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet
    Public Function OpenFile(name As String) As Boolean
        xlApp = New Excel.Application
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
    Public Function SaveCloseFile(Optional name As String = "") As Boolean
        If Open Then
            Try
                If name = "" Then
                    xlWorkBook.Save()
                Else
                    xlWorkBook.SaveAs(name)
                End If
                xlApp = Nothing
                Open = False
            Catch ex As Exception
                MsgBox("The file " + name + " cannot be saved", vbOKOnly, "Warning")
            End Try
        End If
        xlWorkBook.Close()
    End Function


    Public Function getRow(Row As Long, ByRef Table As String, ByRef shoeCode As Long, ByRef RoundId As Long, ByRef cards As MatchCollection) As Boolean
        Try
            Table = xlWorkSheet.Cells(Row, 1).text
            shoeCode = xlWorkSheet.Cells(Row, 2).value2
            RoundId = xlWorkSheet.Cells(Row, 3).value2
            'cards = Regex.Matches(xlWorkSheet.Cells(row, 4).text, "(\'[CDSH][0-9QKAJ]{1,2}\'\,)", RegexOptions.IgnoreCase)
            cards = Regex.Matches(xlWorkSheet.Cells(Row, 4).text, "\'([CDSH])([0-9QKAJ]{1,2})\'\,", RegexOptions.IgnoreCase)
            getRow = True
        Catch ex As Exception
            getRow = False
        End Try
    End Function

    Private Const NetEVFirstColumn As Long = 7
    Private Const NetEVColumns As Long = 4
    Private Const CountFirstColumn As Long = NetEVFirstColumn + NetEVColumns + 1
    Public Sub WriteNetEVTitles(FirstcolumnTitle As String, Optional SecondColumnTitle As String = "", Optional thirdColumnTitle As String = "", Optional fourthColumnTitle As String = "")
        Dim column As Long

        column = NetEVFirstColumn

        xlWorkSheet.Cells(1, column).Value = FirstcolumnTitle
        column = column + 1
        xlWorkSheet.Cells(1, column).Value = SecondColumnTitle
        column = column + 1
        xlWorkSheet.Cells(1, column).Value = thirdColumnTitle
        column = column + 1
        xlWorkSheet.Cells(1, column).Value = fourthColumnTitle
    End Sub

    Public Sub WriteNetEV(Row As Long, FirstcolumnEV As Double, Optional SecondColumnEV As Double = 0, Optional thirdColumnEV As Double = 0, Optional fourthColumnEV As Double = 0)
        Dim column As Long
        column = NetEVFirstColumn
        xlWorkSheet.Cells(Row, column).value = FirstcolumnEV
        column = column + 1
        xlWorkSheet.Cells(Row, column).value = SecondColumnEV
        column = column + 1
        xlWorkSheet.Cells(Row, column).value = thirdColumnEV
        column = column + 1
        xlWorkSheet.Cells(Row, column).value = fourthColumnEV
    End Sub
    Public Sub WriteCountTitles(CardCounter As JP2S_CardCounter)
        Dim column As Long
        For column = CountFirstColumn To CountFirstColumn + JP2S_CardCounter.Count_Strategies.NbCountStrategies - 1
            xlWorkSheet.Cells(1, column).Value = CardCounter.CountStrategyName(column - CountFirstColumn)
        Next column
    End Sub

    Public Sub WriteRunningCount(Row As Long, CardCounter As JP2S_CardCounter)
        Dim column As Long
        For column = CountFirstColumn To CountFirstColumn + JP2S_CardCounter.Count_Strategies.NbCountStrategies - 1
            xlWorkSheet.Cells(Row, column).Value = CardCounter.RunningCount(column - CountFirstColumn)
        Next column
    End Sub

    Public Sub WriteTrueCount(Row As Long, CardCounter As JP2S_CardCounter, CardLeft As Integer, Optional CardsPerDeck As Integer = 52)
        Dim column As Long
        For column = CountFirstColumn To CountFirstColumn + JP2S_CardCounter.Count_Strategies.NbCountStrategies - 1
            xlWorkSheet.Cells(Row, column).Value = CardCounter.RunningCount(column - CountFirstColumn) / CardLeft / CardsPerDeck
        Next column
    End Sub
    Public ReadOnly Property FilePath() As String
        Get
            Return xlWorkBook.FullName
        End Get
    End Property
End Class
