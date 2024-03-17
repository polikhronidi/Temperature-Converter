using System;

public class TemperatureConverter
{
    // Method to convert temperature from Celsius to Fahrenheit
    public static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    // Method to convert temperature from Fahrenheit to Celsius
    public static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    // Main method
    public static void Main(string[] args)
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Convert from Celsius to Fahrenheit");
        Console.WriteLine("2. Convert from Fahrenheit to Celsius");

        int option;
        double temperature;
        double result;

        if (int.TryParse(Console.ReadLine(), out option))
        {
            switch (option)
            {
                case 1:
                    Console.Write("Enter the temperature in Celsius: ");
                    if (double.TryParse(Console.ReadLine(), out temperature))
                    {
                        result = CelsiusToFahrenheit(temperature);
                        Console.WriteLine($"{temperature} degrees Celsius = {result} degrees Fahrenheit");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    break;
                case 2:
                    Console.Write("Enter the temperature in Fahrenheit: ");
                    if (double.TryParse(Console.ReadLine(), out temperature))
                    {
                        result = FahrenheitToCelsius(temperature);
                        Console.WriteLine($"{temperature} degrees Fahrenheit = {result} degrees Celsius");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid option input!");
        }
    }
}
