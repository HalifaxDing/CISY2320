Module Module1

    Sub Main()

        ' Generate Pattern 1
        Console.WriteLine("Pattern 1:")

        Dim i As Integer = 12345
        Do While i > 0
            Console.WriteLine(i)

            'Whole number divide
            i \= 10

            'Regular dvide - Works the same
            'i /=10 
        Loop
        Console.ReadKey()
    End Sub

End Module
