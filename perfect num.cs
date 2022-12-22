namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int X, Y;
            Console.Write("Enter the Start Number : ");
            X=int.Parse(Console.ReadLine());
            Console.Write("Enter the End number");
            Y = int.Parse(Console.ReadLine());
            for (int a = X; a < Y; a++)
            {
                int sum = 0;
            for (int b = 1; b < a; b++)
             {
                    if ( a % b == 0)
                        sum = sum + b;
                }
                if (sum == 0)
                    continue;
              if( a == sum)
                    
                        Console.WriteLine("{0} is Perfect Number",a);



            }

        }
    }
}