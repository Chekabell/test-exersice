internal class Program
{
    private static void Main(string[] args)
    {
        long sum = 0;

        Console.Write("Enter numbers: ");
        while (true) 
        {
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                break;
            }
            if (long.TryParse(input, out long number)) {
                sum += number;
            }
        }

        Console.WriteLine("Sum of numbers = " + sum);
    }
}