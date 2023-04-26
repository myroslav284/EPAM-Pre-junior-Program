Console.WriteLine("Write number with 3 digit:");
int num = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[3];

int digit1 = num % 10;
int digit2 = (num / 10) % 10;
int digit3 = num / 100;

numbers[0] = digit1;
numbers[1] = digit2;
numbers[2] = digit3;

Array.Sort(numbers);

Console.WriteLine("{2}{1}{0}", numbers[0], numbers[1], numbers[2]);