Module Module1

    Function Fibonacci(ByVal n As Integer) As Integer
        Dim a As Integer = 0
        Dim b As Integer = 1

        ' Add up numbers.
        For i As Integer = 0 To n - 1
            Dim temp As Integer = a
            a = b
            b = temp + b
        Next

        Return a
    End Function

    Sub Main()

        While True

            ' Display first entered Fibonacci numbers.

            Console.WriteLine("Fibonacci")
            Console.WriteLine("Enter number of calculations: (Type 1337 to clear console)")
            Dim x As Integer = Console.ReadLine()

            Console.WriteLine()

            If x = 1337 Then

                Console.Clear()

            Else

                For i As Integer = 0 To x Step 1
                    Console.WriteLine(Fibonacci(i))
                Next

                Console.WriteLine()

            End If

        End While

    End Sub

End Module