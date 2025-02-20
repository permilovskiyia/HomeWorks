namespace Task2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            a += b * 10;
            b = a % 10;
            a = (int)a / 10;
            Console.WriteLine("a = {0}, b = {1}", a, b);
        }
    }
}
