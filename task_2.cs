using System;

class task_2
{
    static void Main()
    {
        double price = 250;
        double discount = 0.15;

        double finalPrice = price - (price * discount);

        Console.WriteLine("Final Price: " + finalPrice);
    }
}
