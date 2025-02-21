using System.Runtime.CompilerServices;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            Console.WriteLine(Console.ReadLine());
            Print(n);
        }
        public static void Print(int n)
        {
            Console.WriteLine($"{n++}{Console.Read()}");
        }
    }
}
