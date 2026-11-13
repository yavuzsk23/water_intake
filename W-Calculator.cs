using System;

class Program
{
    static void Main()
    {
        Console.Write("enter your weight (kg) ");
        double weight = double.Parse(Console.ReadLine());

        double water = weight * 0.033;

        Console.WriteLine("You should drink about " + water + " liters of water per day ");
    }
}
