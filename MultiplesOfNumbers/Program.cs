namespace MultiplesOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new();

            int minMultiplyer = 10;
            int maxMultiplyer = 25;
            int minNumber = 50;
            int maxNumber = 150;

            int numbersCount = 0;
            int multiplyer = random.Next(minMultiplyer, maxMultiplyer + 1);

            for (int i = 0; i <= maxNumber; i+= multiplyer)
            {
                if (i >= minNumber && i <= maxNumber)
                {
                    numbersCount++;
                }
            }

            Console.WriteLine($"Количество чисел кратных {multiplyer} = {numbersCount}");
            Console.ReadKey();
        }
    }
}
