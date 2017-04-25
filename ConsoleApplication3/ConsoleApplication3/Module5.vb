Module Module5
    Sub Main()
        Dim l1, w1, l2, w2, diff As Integer, msg As String
        Console.WriteLine("Input length 1")
        l1 = Console.ReadLine()
        Console.WriteLine("Input width 1")
        w1 = Console.ReadLine()
        Console.WriteLine("Input length 2")
        l2 = Console.ReadLine()
        Console.WriteLine("Input width 2")
        w2 = Console.ReadLine()
        diff = l2 * w2 - l1 * w1
        Select Case diff
            Case 0 To 100 : msg = "ok"
            Case 101 To 150 : msg = "Discuss"
            Case 151 To 200 : msg = "Reconsider"
            Case Else
                If diff > 200 Then
                    msg = "Reject"
                End If
        End Select

        Console.WriteLine((l1 * w1), (l2 * w2), msg)


    End Sub
End Module
