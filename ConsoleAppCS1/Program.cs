// string tanımlama
string sFirstName = string.Empty;
string sLastName = string.Empty;
string sFilePath = string.Empty;

// string değer ata
sFirstName = "Ahmet";
sLastName = "Dizioglu";
sFilePath = "C:\\Temp\\Demo";
sFilePath = @"C:\Temp\Demo";

// Console ekranını string yazdırma
Console.WriteLine(sFirstName);

//C# how srting interpolation
Console.WriteLine($"Merhaba {sFirstName} {sLastName}");

Console.WriteLine(sFilePath);