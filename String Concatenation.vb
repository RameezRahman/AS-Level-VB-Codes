Module Module1

    Sub Main()
        Dim WordString1, WordString2, WordString3, Firstword, Lastword As String
        Dim Xb As Integer


        WordString1 = " "
        WordString2 = " "
        WordString3 = " "
        Firstword = " "
        Lastword = " "
        Xb = 0


        Console.WriteLine("Enter The 1st string that contains only 2 words: ")
        WordString1 = Console.ReadLine


        Console.WriteLine("Enter The 2nd string that also contains only 2 words: ")
        WordString2 = Console.ReadLine

        Xb = InStr(WordString1, " ")
        Firstword = Left(WordString1, Xb - 1)

        Xb = InStr(WordString2, " ")
        Lastword = Right(WordString2, Len(WordString2) - Xb)


        WordString3 = Firstword & " " & Lastword
        Console.WriteLine("Your Final String is : " & WordString3)

        Console.ReadKey()
    End Sub

    Private Function LOCATE(ByVal WordString1 As String, ByVal p2 As String) As Integer
        Throw New NotImplementedException
    End Function

End Module
