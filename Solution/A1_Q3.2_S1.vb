Module Module1
    Sub main()

        Console.WriteLine("Pattern 2:")
        Dim rows As Integer = 5
        For i As Integer = 0 To rows - 1

            'Spaces
            For j As Integer = 0 To rows - i - 2
                Console.Write(" ")
            Next

            'Ascending Order Letters
            For j As Integer = 0 To i
                Console.Write(Chr(65 + j))
            Next

            'Descending Order Letters
            For j As Integer = i - 1 To 0 Step -1
                Console.Write(Chr(65 + j))
            Next
            Console.WriteLine()

            'ASCII Chr (65) is A
        Next
        Console.ReadKey()
    End Sub
End Module
