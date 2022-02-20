Public Class JP2S_CardCounter
    <Flags()> Public Enum Count_Strategies As Integer
        Hi_Lo = 2 ^ 0
        K_O = 2 ^ 1
        Hi_Opt1 = 2 ^ 2
        Hi_Opt2 = 2 ^ 3
        Halves = 2 ^ 4
        Omega_2 = 2 ^ 5
        Red_Seven = 2 ^ 6
        Zen = 2 ^ 7
    End Enum


End Class
