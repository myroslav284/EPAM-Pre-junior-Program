// See https://aka.ms/new-console-template for more information
Console.WriteLine("Notebook price:");
double notebookPrice = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Pen price:");
double penPrice = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Notebooks count:");

int notebookCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Pens count:");

int penCount = Convert.ToInt32(Console.ReadLine());

double sum = (notebookPrice * notebookCount) + (penPrice * penCount);

Console.WriteLine("All price: " + sum);