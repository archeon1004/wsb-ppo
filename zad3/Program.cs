// See https://aka.ms/new-console-template for more information
Console.WriteLine("Zadanie 3 - srednia ocen");
Console.WriteLine("Podaj liczbe ocen do wprowadzenia:");
var inpuntNumberOfDegrees = Console.ReadLine();
bool isParsed = int.TryParse(inpuntNumberOfDegrees, out int numberOfDgrees);
double sum = 0;
try
{
    if (isParsed)
    {
        for (int i = 0; i < numberOfDgrees; i++)
        {
            Console.WriteLine("Podaj ocene:");
            var input = Console.ReadLine();
            double temp = double.Parse(input);
            if (temp < 1.0 || temp > 6.0)
            {
                Console.WriteLine("Niepoprawna ocena, podaj ocene ponownie:");
                i--;
                continue;
            }
            sum += temp;
        }
        Console.WriteLine($"debug sum {sum}");
        Console.WriteLine($"debug sum {numberOfDgrees}");
        Console.WriteLine($"Srednia ocen: {Math.Round((sum / (double)numberOfDgrees),2)}. Uczen zdal?: {(sum / (double)numberOfDgrees > 3.0 ? true : false)}");
    }
}
catch
{
    throw;
}

