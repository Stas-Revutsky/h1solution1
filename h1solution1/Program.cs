namespace h1solution1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());

            int calcutePerimeter(int a)
            {
                int sidesOfSquare = 4;
                int p = sidesOfSquare * a;
                return p;
            }
            int calculateArea(int a)
            {
                return (int)Math.Pow(a, 2);
            }

            Console.WriteLine(calcutePerimeter(a) + " " + calculateArea(a));

        }
    }
}