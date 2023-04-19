using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Pen price: ");

        double penPrice = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Notebook price: ");

        double notebookPrice = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Pens count: ");

        int penCount = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Notebooks count: ");

        int notebookCount = Convert.ToInt32(Console.ReadLine());


        double sum = (penCount * penPrice) + (notebookCount * notebookPrice);

        Console.WriteLine("All price: " + sum);


    }
}