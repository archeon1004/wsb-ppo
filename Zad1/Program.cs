// See https://aka.ms/new-console-template for more information
Console.WriteLine("Zadanie pierwsze - Kalkulator");
Console.WriteLine("Podaj liczbe a: ");
var numA = Console.ReadLine();
Console.WriteLine("Podaj liczbe b: ");
var numB = Console.ReadLine();
Console.WriteLine("Podaj symbol operacji: + - / * ");
var operand = Console.ReadLine();
try
{
    if (operand == "+")
    {
        Console.WriteLine($"Suma {numA} oraz {numB} to: {double.Parse(numA) + double.Parse(numB)}");
    }
    else if(operand == "-")
    {
        Console.WriteLine($"Roznica {numA} oraz {numB} to: {double.Parse(numA) - double.Parse(numB)}");
    }
    else if(operand == "*")
    {
        Console.WriteLine($"Iloczyn {numA} oraz {numB} to: {double.Parse(numA) * double.Parse(numB)}");
    }
    else if(operand == "/")
    {
        if(double.Parse(numB) == 0)
        {
            throw new ArithmeticException("Blad dzielenia przez 0");
        }
        Console.WriteLine($"Iloraz {numA} oraz {numB} to: {double.Parse(numA) / double.Parse(numB)}");
    }
    else
    {
        throw new InvalidOperationException("Niepoprawny operand działania");
    }
}
catch (Exception e)
{
    Console.WriteLine($"Wystapil blad. Niepoprawne dzialanie badz nie poprawne dane wejsciowe! Sprawdz czy podajesz liczby oraz poprawny operand dzialania.\n{e.Message}");
}
