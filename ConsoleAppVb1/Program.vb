

Imports System

Module Program
    Sub Main(args As String())

        'C# taki "string sFirstName = string.Empty;"  Vb karşılığı nedir?
        Dim firstName As String = String.Empty
        Dim lastName As String = String.Empty
        Dim sFilePath As String = String.Empty

        'C# taki ""firstName = "Ahmet""  Vb karşılığı nedir?
        firstName = "Ahmet"
        lastName = "Dizioglu"
        sFilePath = "C:\Temp\Demo"

        ' C#'daki "Console.WriteLine(firstName);" ifadesinin VB karşılığı nedir?
        Console.WriteLine(firstName)
        Console.WriteLine(firstName + " " + lastName)

        ' C#'daki "Console.WriteLine($"Merhaba {sFirstName} {sLastName}");" ifadesinin VB karşılığı nedir?
        Console.WriteLine($"Merhaba {firstName} {lastName}")

        Console.WriteLine(sFilePath)


    End Sub
End Module
