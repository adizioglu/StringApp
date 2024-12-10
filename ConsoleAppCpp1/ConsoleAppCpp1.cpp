#include <iostream>
#include <string>

int main()
{
    // C#'daki "string sFirstName = string.Empty;" ifadesinin C++ karşılığı nedir?
    std::string sFirstName = ""; // Initialize sFirstName
    std::string sLastName = ""; // Initialize sLastName
	std::string sFilePath = ""; // Initialize sFullName

    // C#'daki "firstName = "Ahmet";" ifadesinin C++ karşılığı nedir?
    sFirstName = "Ahmet"; // Correctly assign value to sFirstName
    sLastName = "Dizioglu"; // Correctly assign value to sLastName
	sFilePath = "C:\\Temp\\Demo"; // Correctly assign value to sFilePath
 
    // C#'daki "Console.WriteLine(firstName);" ifadesinin C++ karşılığı nedir?
    std::cout << sFirstName << std::endl; // Print sFirstName to console

    // C#'daki "Console.WriteLine(firstName + " " + lastName);" ifadesinin C++ karşılığı nedir?
    std::cout << sFirstName << " " << sLastName << std::endl; // Print full name to console

    // C#'daki "Console.WriteLine($"Merhaba {sFirstName} {sLastName}");" ifadesinin C++ karşılığı nedir?
    std::cout << "Merhaba " << sFirstName << " " << sLastName << std::endl; // Print full name to console

	std::cout << "File Path: " << sFilePath << std::endl; // Print file path to console    

    return 0;
}

