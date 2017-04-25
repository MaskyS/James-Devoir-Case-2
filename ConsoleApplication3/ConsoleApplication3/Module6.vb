Module Module6
    Sub Main()
        Dim speed As Integer, name As String
        Console.WriteLine("Input speed")
        speed = Console.ReadLine()
        Console.WriteLine("Input name")
        name = Console.ReadLine()
        Select Case speed
            Case 0 To 300 : Select Case name
                    Case "toyota" : Console.WriteLine("car 1")
                    Case "Honda" : Console.WriteLine("car 2")
                    Case "Volvo" : Console.WriteLine("car 3")
                End Select

            Case 301 To 600
                Select Case name
                    Case "moris express" : Console.WriteLine("train 1")
                    Case "Rodrigues train" : Console.WriteLine("train 2")
                    Case "Mada train" : Console.WriteLine("train 3")
                End Select

            Case 601 To 2000
                Select Case name
                    Case "air moris" : Console.WriteLine("plane 1")
                    Case "Air rodrigues" : Console.WriteLine("plane 2")
                    Case "Air comores" : Console.WriteLine("plane 3")
                End Select
        End Select

    End Sub
End Module
