Module Module1

    Sub Main()
        Dim WORDSTR1, WORDSTR2 As String
        Dim CH1, NEXTCHAR As Char
        Dim COUNT As Integer

        WORDSTR1 = " "
        WORDSTR2 = " "
        CH1 = " "
        NEXTCHAR = " "
        COUNT = 0

        Console.WriteLine("Enter The String")
        WORDSTR1 = Console.ReadLine

        Console.WriteLine("Enter The Character Which Is To Be Removed")
        CH1 = Console.ReadLine

        For COUNT = 1 To Len(WORDSTR1)
        Next
        NEXTCHAR = Mid(WORDSTR1, COUNT, 1)
        If NEXTCHAR <> CH1 Then

            WORDSTR2 = WORDSTR2 & NEXTCHAR
        End If

        Console.WriteLine("Final String = " & WORDSTR2)
        Console.ReadKey()


    End Sub

End Module
