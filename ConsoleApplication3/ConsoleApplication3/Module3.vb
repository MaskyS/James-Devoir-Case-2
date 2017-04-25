Module Module3
    Sub Main()
        Dim money, amnt As Integer
        Console.WriteLine("input money")
        money = Console.ReadLine()
        amnt = money / 42.34
        Select Case amnt
            Case 0 To 10 : Console.WriteLine("One quarter tank")
            Case 11 To 18 : Console.WriteLine("Half tank")
            Case 19 To 28 : Console.WriteLine("Three quarter tank")
            Case Else
                If amnt > 28 Then
                    Console.WriteLine("Full tank")
                End If
        End Select
    End Sub
End Module
