Module Module1
    Sub Main()
        ' Step 2: Write VB.NET code to generate the pattern
        Dim letters As String = "_ABCDEFGHIJKLMNOPQRSTUVWXYZ" ' The alphabet string for the pattern

        ' Degree can different than 5
        Dim degree As Integer = 5
        'Dim degree As Integer = 10

        ' Outer loop to control the number of rows
        For i As Integer = 1 To degree

            'Display String
            Dim tmpString As String = String.Empty

            ' Print ascending letters
            For k As Integer = 1 To i
                tmpString &= letters(k)
            Next

            ' Print descending letters
            For l As Integer = i - 1 To 1 Step -1
                tmpString &= letters(l)
            Next

            ' Output String, Left-pad the pattern with spaces to center it
            Console.WriteLine(tmpString.PadLeft(degree + i - 1))
        Next

        ' Prevent the console from closing immediately
        Console.ReadLine()
    End Sub
End Module
