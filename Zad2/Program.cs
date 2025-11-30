// See https://aka.ms/new-console-template for more information
Console.WriteLine("Zadanie Drugie - konwerter temperatur");
Console.WriteLine("Wybierz kierunek konwersji temperatury\nC (Celsjusz -> Fahrenheit) lub F (Fahrenheit -> Celsjusz)");
var choice = Console.ReadLine();
Console.WriteLine("Podaj wartość temperatury do konwersji:");
var temp = Console.ReadLine();
try
{
    if (choice == "C")
    {
        double inputCelsius = double.Parse(temp);
        double fahrenheit = (inputCelsius * 9 / 5) + 32;
        Console.WriteLine($"{inputCelsius}°C to {Math.Round(fahrenheit,2)}°F");
    }
    else if (choice == "F")
    {
        double inputFahrenheit = double.Parse(temp);
        double celsius = (inputFahrenheit - 32) * 5 / 9;
        Console.WriteLine($"{inputFahrenheit}°F to {Math.Round(celsius,2)}°C");
    }
    else
    {
        Console.WriteLine("Nieprawidłowy wybór lub wartość temperatury.");
    }
}
catch (Exception)
{
	Console.WriteLine("Nieprawidlowy wybor lub wartosc temperatury.");
}


