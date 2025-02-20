namespace Task2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = (int)a / 100 % 10;
            int c = a % 10;
            Console.WriteLine(a - b * 99 + c * 99);
        }
    }
}
