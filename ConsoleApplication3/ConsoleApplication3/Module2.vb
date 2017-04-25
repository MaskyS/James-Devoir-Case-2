Module Module2
    Sub Main()
        Dim name As String
        Console.WriteLine("Input name")
        name = Console.ReadLine()
        Select Case name
            Case "KFC", "MC DO" : Console.WriteLine("Fast Food")
            Case "SAMSUNG", "CASH & CARRY" : Console.WriteLine("Electronics")
            Case "TFP", "COURTS" : Console.WriteLine("Furniture")
            Case "LEXPRESS", "DEFIMEDIA" : Console.WriteLine("News")
            Case Else
                Console.WriteLine("Undefined")
        End Select


    End Sub
End Module
