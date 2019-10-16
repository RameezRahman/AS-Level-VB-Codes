Module Module1

    Sub Main()
        Dim WORDSTRING1, WORDSTRING2, CH1, CH2, NEXTCHAR As String
        Dim COUNTER As Integer

        WORDSTRING1 = " "
        WORDSTRING2 = " "
        CH1 = " "
        CH2 = " "
        NEXTCHAR = " "
        COUNTER = 0

        Console.Write("Enter a String: ")
        WORDSTRING1 = Console.ReadLine

        Console.Write("Enter the character that you want to remove from your above string: ")
        Ch1 = Console.ReadLine

        Console.Write("Enter the character you want to replace that with: ")
        Ch2 = Console.ReadLine

        For COUNTER = 1 To Len(WORDSTRING1)
            NEXTCHAR = Mid(WORDSTRING1, COUNTER, 1)
            If NEXTCHAR = CH1 Then
                NEXTCHAR = CH2
            End If
            WORDSTRING2 = WORDSTRING2 & NEXTCHAR
        Next


        Console.WriteLine("Final String = " & WORDSTRING2)
        Console.ReadKey()
    End Sub

End Module
