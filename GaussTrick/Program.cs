class GaussTrick
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToArray();

        List<int> sequence = new List<int>();

        int iterations = numbers.Length / 2;

       
        for (int i = 0; i < iterations; i++)
        {
            int firstNumber=numbers[i];
            int secondNumber = numbers[numbers.Length - 1 - i];
            int sum=firstNumber+secondNumber;
            sequence.Add(sum);
            
        }

        if (numbers.Length % 2 != 0)
        {
            int index = numbers.Length / 2;
            sequence.Add(numbers[index]);
            
        }

        Console.WriteLine(string.Join(" ",sequence));
    }
}