using System;
using System.Diagnostics;

class Program
{

    static void Main(String[] args)
    {
        Console.WriteLine("Här är en enkel räknare");

        Console.Write("Ange de första talet: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ange de andra talet: ");

        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Välj operator: ");
        Console.WriteLine("1.Addition (+)");
        Console.WriteLine("2.Subtraktion (-)");
        Console.WriteLine("3.Multiplikation(*)");
        Console.WriteLine("4.Division (/)");

        Console.Write("Ditt val (1-4): ");

        int val = Convert.ToInt32(Console.ReadLine());

        double result;


        switch (val)
        {
            case 1:
                result = num1 + num2;
                Console.WriteLine($"Resultat av {num1} + {num2} = {result}");
                break;
            case 2:
                result = num1 - num2;
                Console.WriteLine($"Resultat av {num1} - {num2} = {result}");
                break;
            case 3:
                result = num1 * num2;
                Console.WriteLine($"Resultat av {num1} * {num2} = {result}");
                break;
            case 4:
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"Resultat av {num1} / {num2} = {result}");
                }
                else
                {
                    Console.WriteLine("Fel: Kan inte divideras med noll");
                }
                break;
            default:
                Console.WriteLine("Ogiltligt val");
                break;
        
        }
        Console.WriteLine("Tryck på en tangent för att avsluta");
        Console.ReadKey();

    }
}

