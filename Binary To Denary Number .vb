Module Module1

    Sub Main()
        Dim BinaryNumber As String
        Dim Counter As Integer
        Dim ValidBinaryNumber As Boolean
        Dim NEXTCHAR As String
        Dim String1 As String
        Dim Denrynumber As String
        Dim String2 As String
        Dim Num1 As Integer

        num1 = 0
        string2 = ""
        denrynumber = 0
        nextchar = ""
        string1 = ""
        BinaryNumber = ""
        counter = 0
        ValidBinaryNumber = True

        Console.WriteLine("Enter The Binary number: ")
        BinaryNumber = Console.ReadLine

        If Len(BinaryNumber) <= 8 Then
        End If
        For counter = 1 To Len(BinaryNumber)
            nextchar = Mid(BinaryNumber, counter, 1)
            If nextchar <> 1 And nextchar <> 0 Then
                ValidBinaryNumber = False
            End If

        Next
        If ValidBinaryNumber = False Then
            Console.WriteLine("It's not a valid binary number ")
            Console.ReadKey()

        End If

        If ValidBinaryNumber = True Then

        End If

        For Counter = 1 To Len(BinaryNumber)
            String2 = Mid(BinaryNumber, Counter, 1) & String2

        Next

        For Counter = 1 To Len(String2)
            NEXTCHAR = Mid(String2, Counter, 1)
            Num1 = 0
            If NEXTCHAR = "1" Then
                Num1 = 1

            End If

            If Counter = 1 Then
                Denrynumber = Denrynumber + Num1 * 2 ^ 0

            End If

            If Counter = 2 Then
                Denrynumber = Denrynumber + Num1 * 2 ^ 1

            End If

            If Counter = 3 Then
                Denrynumber = Denrynumber + Num1 * 2 ^ 2

            End If

            If Counter = 4 Then
                Denrynumber = Denrynumber + Num1 * 2 ^ 3

            End If

            If Counter = 5 Then
                Denrynumber = Denrynumber + Num1 * 2 ^ 4

            End If

            If Counter = 6 Then
                Denrynumber = Denrynumber + Num1 * 2 ^ 5

            End If

            If Counter = 7 Then
                Denrynumber = Denrynumber + Num1 * 2 ^ 6

            End If

            If Counter = 8 Then
                Denrynumber = Denrynumber + Num1 * 2 ^ 7

            End If

        Next

        Console.WriteLine(BinaryNumber & " = " & denrynumber)
        Console.ReadKey()
    End Sub

End Module
