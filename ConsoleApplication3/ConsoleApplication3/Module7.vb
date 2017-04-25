Module Module7
    Sub Main()
        Dim amnt, tax As Integer
        Console.WriteLine("Input amount")
        amnt = Console.ReadLine()

        Select Case amnt
            Case 0 To 100000 : tax = amnt * 0.05
            Case 100001 To 300000 : tax = amnt * 0.08
            Case 300001 To 700000 : tax = amnt * 0.12
            Case 700001 To 900000 : tax = amnt * 0.15
            Case Else
                If amnt > 900000 Then
                    tax = amnt * 0.2
                End If
        End Select
    End Sub
End Module
