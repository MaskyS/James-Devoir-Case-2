Module Module4
    Sub Main()
        Dim team As String, season As Integer
        Console.WriteLine("Input team")
        team = Console.ReadLine()
        Console.WriteLine("Input season")
        season = Console.ReadLine()

        Select Case team
            Case "Manchester" : Select Case season
                    Case 1 : Console.WriteLine(50)
                    Case 2 : Console.WriteLine(70)
                    Case 3 : Console.WriteLine(65)
                    Case 4 : Console.WriteLine(80)
                End Select



            Case "Liverpool" : Select Case season
                    Case 1 : Console.WriteLine(20)
                    Case 2 : Console.WriteLine(25)
                    Case 3 : Console.WriteLine(26)
                    Case 4 : Console.WriteLine(22)
                End Select



            Case "Arsenal" : Select Case season
                    Case 1 : Console.WriteLine(18)
                    Case 2 : Console.WriteLine(17)
                    Case 3 : Console.WriteLine(16)
                    Case 4 : Console.WriteLine(15)
                End Select


            Case "Chealsea" : Select Case season
                    Case 1 : Console.WriteLine(2)
                    Case 2 : Console.WriteLine(3)
                    Case 3 : Console.WriteLine(4)
                    Case 4 : Console.WriteLine(5)
                End Select

        End Select
    End Sub
End Module
