
namespace ÜçgenÇiz
{
    // Kullanıcıdan veri alma sorumluluğu
    public static class InputHandler
    {
        public static int GetTriangleSize()
        {
            int size;
            Console.Write("Üçgenin boyutunu girin: ");
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Lütfen geçerli bir pozitif sayı girin.");
                Console.Write("Üçgenin boyutunu girin: ");
            }
            return size;
        }
    }

    // Üçgen çizme sorumluluğu
    public static class TriangleDrawer
    {
        public static void DrawTriangle(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                PrintSpaces(size - i);
                PrintStars(i);
                Console.WriteLine();
            }
        }

        private static void PrintSpaces(int count)
        {
            Console.Write(new string(' ', count));
        }

        private static void PrintStars(int count)
        {
            Console.Write(new string('*', count * 2 - 1));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int size = InputHandler.GetTriangleSize();
            TriangleDrawer.DrawTriangle(size);

            Console.WriteLine("\nÜçgen çizimi tamamlandı. Çıkmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
