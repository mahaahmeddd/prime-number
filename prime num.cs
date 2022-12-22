namespace prime_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Start number : ");
            int X = int.Parse(Console.ReadLine());

            Console.Write("Enter the end number : ");
            int Y = int.Parse(Console.ReadLine());

            for (int a = X; a <= Y; a++)
            {
                int c = 0;
                for (int b = 1; b <= a; b++)
                {
                    if (b == 1 || a == b)
                        c++;

                    else if (a % b == 0)
                        break;

                }
                if (c == 2)
                    Console.WriteLine("{0} is prime Number", a);
            }
        }
    }
}
        