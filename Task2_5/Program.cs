namespace Task2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Round(l, MidpointRounding.ToPositiveInfinity));
        }
    }
}
