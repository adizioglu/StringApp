//C# taki "string sFirstName = string.Empty;" F# karşılığı nedir?
let sFirstName = String.Empty
let sLastName = String.Empty
let sFilePath = String.Empty

//C# taki "firstName = "Ahmet";"  F#  karşılığı nedir?
let sFirstName = "Ahmet"
let sLastName = "Dizioglu"
let sFilePath = "C:\\Temp\\Demo"

// C#'daki "Console.WriteLine(firstName);" ifadesinin F# karşılığı nedir?
printfn "%s" sFirstName

// C#'daki "Console.WriteLine(firstName + " " + lastName);" ifadesinin F# karşılığı nedir?
printfn "%s %s" sFirstName sLastName

// C#'daki "Console.WriteLine($"Merhaba {sFirstName} {sLastName}");" ifadesinin F# karşılığı nedir?
printfn "Merhaba %s %s" sFirstName sLastName

printfn "%s" sFilePath









