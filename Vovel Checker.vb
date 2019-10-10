Module Module1

    Sub Main()

        Dim str, vovel As String
        Dim count, noOfVovels As Integer

        str = ""
        vovel = "AEIOU"
        count = 0
        noOfVovels = 0

        Console.Write("Enter the string to be checked: ")
        str = Console.ReadLine

        str = UCase(str)

        For count = 1 To Len(str)
            If InStr(vovel, Mid(str, count, 1)) > 0 Then
                noOfVovels = noOfVovels + 1
            End If
        Next

        Console.WriteLine("the nn of vovels in the entered string is: " & noOfVovels)
        Console.ReadKey()
    End Sub


End Module
