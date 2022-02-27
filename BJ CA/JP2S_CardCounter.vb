Public Class JP2S_CardCounter

    Public Enum Count_Strategies As Integer
        Hi_Lo
        K_O
        Hi_Opt1
        Hi_Opt2
        Halves
        Omega_2
        Red_Seven
        Zen
        NbCountStrategies
    End Enum
    <Flags()> Public Enum Count_Strategies_Flags As Integer
        Hi_Lo = 2 ^ Count_Strategies.Hi_Lo
        K_O = 2 ^ Count_Strategies.K_O
        Hi_Opt1 = 2 ^ Count_Strategies.Hi_Opt1
        Hi_Opt2 = 2 ^ Count_Strategies.Hi_Opt2
        Halves = 2 ^ Count_Strategies.Halves
        Omega_2 = 2 ^ Count_Strategies.Omega_2
        Red_Seven = 2 ^ Count_Strategies.Red_Seven
        Zen = 2 ^ Count_Strategies.Zen
    End Enum

    Public ReadOnly CountStrategyName As String() = {"Hi-Lo", "K-O", "Hi Option I", "Hi Option II", "Halves", "Omega II", "Red Seven", "Zen"}

    Public ReadOnly CountTable As Array = New Double(Count_Strategies.NbCountStrategies - 1, 10) {
        {0, -1, 1, 1, 1, 1, 1, 0, 0, 0, -1},
        {0, -1, 1, 1, 1, 1, 1, 1, 0, 0, -1},
        {0, 0, 0, 1, 1, 1, 1, 0, 0, 0, -1},
        {0, 0, 1, 1, 2, 2, 1, 1, 0, 0, -2},
        {0, -1, 0.5, 1, 1, 1.5, 1, 0.5, 0, -0.5, -1},
        {0, 0, 1, 1, 2, 2, 2, 1, 0, -1, -2},
        {0, -1, 1, 1, 1, 1, 1, 0.5, 0, 0, -1},
        {0, -1, 1, 1, 2, 2, 2, 1, 0, 0, -2}
        }

    Public RunningCount(Count_Strategies.NbCountStrategies - 1) As Double

    Public Sub CounterReset()
        Array.Clear(RunningCount, 0, Count_Strategies.NbCountStrategies)
    End Sub

    Public Sub Count(cardValue As Long)
        Dim i As Integer
        For i = 0 To UBound(CountTable, 1)
            RunningCount(i) += CountTable(i, cardValue)
        Next
    End Sub


End Class