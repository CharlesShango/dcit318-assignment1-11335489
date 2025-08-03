using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int age))
        {
            double ticketPrice;

            if (age <= 12 || age >= 65)
                ticketPrice = 7.00;
            else
                ticketPrice = 10.00;

            Console.WriteLine($"Your ticket price is: GHC{ticketPrice}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
