namespace deliverable5;
class Program
{
    static void Main(string[] args)

    {
        int[] numbers = new int[10];
        Random rand = new Random();

        for (int i = 0; i <numbers.Length; i++)
        {
            numbers[i] = rand.Next(10, 51);
        }

        Console.WriteLine("Randomly generated numbers:");
        foreach(int num in numbers)
        {
            Console.Write(num + "");
        }
        Console.WriteLine();

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine("Sum of all elements in the array: " + sum);

    }

}

