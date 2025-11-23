
namespace OrtHesapla
{
    class FibonacciService
    {
        public static int[] Generate(int depth)
        {
            int[] series = new int[depth];

            if (depth >= 1) series[0] = 0;
            if (depth >= 2) series[1] = 1;

            for (int i = 2; i < depth; i++)
            {
                series[i] = series[i - 1] + series[i - 2];
            }

            return series;
        }
    }

    class AverageService
    {
        public static double Calculate(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
                sum += number;
            return (double)sum / numbers.Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Fibonacci derinliğini giriniz: ");
            int depth = int.Parse(Console.ReadLine());

            int[] series = FibonacciService.Generate(depth);
            double average = AverageService.Calculate(series);

            Console.WriteLine("\nFibonacci Serisi: " + string.Join(", ", series));
            Console.WriteLine("Ortalama: " + average);
        }
    }
}
