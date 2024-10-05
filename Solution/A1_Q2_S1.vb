Module MOdule1
    Sub Main()
        ' Step 2: Define a variable marks of Integer data type
        Dim marks As Integer
        ' Step 3: Define a variable grade of String data type
        Dim grade As String
        Dim validInput As Boolean

        ' Step 4: Use a Do While loop to check for valid integer input
        Do
            Console.Write("Enter your marks (0-100): ")
            validInput = Integer.TryParse(Console.ReadLine(), marks)

            If Not validInput OrElse marks < 0 OrElse marks > 100 Then
                Console.WriteLine("Invalid input. Please enter an integer between 0 and 100.")
            End If
        Loop While Not validInput OrElse marks < 0 OrElse marks > 100

        ' Step 5: Use the Select-Case statement to assign a grade
        Select Case marks
            Case 90 To 100
                grade = "A+"
            Case 85 To 89
                grade = "A"
            Case 80 To 84
                grade = "A-"
            Case 77 To 79
                grade = "B+"
            Case 73 To 76
                grade = "B"
            Case 70 To 72
                grade = "B-"
            Case 67 To 69
                grade = "C+"
            Case 63 To 66
                grade = "C"
            Case 60 To 62
                grade = "C-"
            Case 50 To 59
                grade = "D"
            Case 0 To 49
                grade = "F"
        End Select

        ' Step 6: Display the marks and the corresponding grade
        Console.WriteLine("Marks: " & marks & ", Grade: " & grade)

        ' Prevent the console from closing immediately
        Console.ReadLine()
    End Sub
End Module
