namespace GruopTasking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //=======(>>>>Q5<<<<) Write a program that receives a 4-digit number and prints if the ones digit and the last digit are equal.
            int x = int.Parse(Console.ReadLine());
            if(x > 100)
            {
                int r = x % 10;
                while (x > 9)
                    x /= 10;
                if (r == x)
                    Console.WriteLine("Is equal");
                else
                    Console.WriteLine("Is not equal");
            } else
                Console.WriteLine("Invaild number");
        }
    }
}
