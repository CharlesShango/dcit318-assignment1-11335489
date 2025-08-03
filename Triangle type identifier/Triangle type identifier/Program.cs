using System;

class Program
{
    static void Main()
    {
        // Prompt the user for the three sides
        Console.Write("Enter side 1: ");
        bool s1Ok = double.TryParse(Console.ReadLine(), out double side1);

        Console.Write("Enter side 2: ");
        bool s2Ok = double.TryParse(Console.ReadLine(), out double side2);

        Console.Write("Enter side 3: ");
        bool s3Ok = double.TryParse(Console.ReadLine(), out double side3);

        // Basic input validation
        if (!s1Ok || !s2Ok || !s3Ok || side1 <= 0 || side2 <= 0 || side3 <= 0)
        {
            Console.WriteLine("Invalid input. All sides must be positive numbers.");
            Pause();
            return;
        }

        // Triangle-inequality check
        bool isTriangle = side1 + side2 > side3 &&
                          side1 + side3 > side2 &&
                          side2 + side3 > side1;

        if (!isTriangle)
        {
            Console.WriteLine("The lengths entered cannot form a valid triangle.");
            Pause();
            return;
        }

        // Determine the type
        string triangleType;
        if (side1 == side2 && side2 == side3)
        {
            triangleType = "Equilateral";
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            triangleType = "Isosceles";
        }
        else
        {
            triangleType = "Scalene";
        }

        Console.WriteLine($"The triangle is: {triangleType}");
        Pause();
    }

    /// <summary>
    /// Keeps the console window open until the user presses a key.
    /// </summary>
    static void Pause()
    {
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
