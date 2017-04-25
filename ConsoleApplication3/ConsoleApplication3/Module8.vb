Module Module8
    Sub Main()
        Dim name As String
        Console.WriteLine("Input name")
        name = Console.ReadLine()
        Select Case name
            Case "Jumbo", "Shoprite" : WriteLine("Hypermarket")
            Case "Food lover", "sea lovers" : WriteLine("Minimarket")
            Case "4banane", "3papaye" : WriteLine("Tabagie")
            Case Else
                WriteLine("Supermarket")
        End Select

    End Sub
End Module
