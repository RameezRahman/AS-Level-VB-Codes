Module Module1

    Private Property Aplhabet As String

    Sub Main()
        Dim Aplhabet, Str1, Pangram As String
        Dim Count As Integer
        Dim Ispangram As Boolean

        Aplhabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        str1 = ""
        count = 0
        Ispangram = False

        Console.Write('PANGRAM CHECKER AT YOUR SERVICE!') 

        Console.WriteLine("Enter The Suspected Sentence To Check Whether It's A Pangram Or Not")
        Str1 = Console.ReadLine
        Str1 = Console.ReadLine
        Str1 = UCase(Str1)
        If Len(Str1) >= 26 Then
            Ispangram = True
            For Count = 1 To 26
                If InStr(Str1, Mid(Aplhabet, Count, 1)) = 0 Then
                    Ispangram = False

                End If
            Next
        End If

        If Ispangram = True Then

            Console.WriteLine("the suspected sentence is indeed a pangram")
        Else
            Console.WriteLine("the entered string is not a pangram")
        End If
    End Sub

End Module
