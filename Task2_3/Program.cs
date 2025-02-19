namespace Task2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inch = Convert.ToDouble(Console.ReadLine());
            double mm = inch * 25.4;
            int m = (int)mm / 1000;
            int sm = (int)mm % 1000 / 10;
            mm %= 10;
            Console.WriteLine("{0} m {1} sm {2} mm", m, sm, mm);
            Console.ReadKey();
        }
    }
}
