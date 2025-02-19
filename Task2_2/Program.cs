namespace Task2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d = Convert.ToDouble(Console.ReadLine());
            double m = Convert.ToDouble(Console.ReadLine());
            double s = Convert.ToDouble(Console.ReadLine());
            double rad = (d + m / 60 + s / 3600) * Math.PI / 180;
            Console.WriteLine(rad);
            Console.ReadKey();
        }
    }
}
