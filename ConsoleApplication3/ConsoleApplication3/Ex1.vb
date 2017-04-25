Module Module1

    Sub Main()
        Dim temp As Integer
        Console.WriteLine("Input temperature")
        temp = Console.ReadLine()
        Select Case temp
            Case 0 To 10 : Console.WriteLine("Too cold")
            Case 15 To 18 : Console.WriteLine("Cold")
            Case 24 To 28 : Console.WriteLine("Good")
            Case 30 To 38 : Console.WriteLine("Hot")
            Case Else
                Console.WriteLine("Not valid")
        End Select

    End Sub

End Module
