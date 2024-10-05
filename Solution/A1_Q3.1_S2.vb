Module Module1

    Sub Main()

        ' Generate Pattern 1
        Console.WriteLine("Pattern 1:")

        For i As Integer = 5 To 1 Step -1
            For j As Integer = 1 To i
                Console.Write(j)
            Next
            Console.WriteLine()
        Next
        Console.ReadKey()
    End Sub

End Module
