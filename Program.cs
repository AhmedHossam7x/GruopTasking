namespace GruopTasking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //=======(>>>>Q4<<<<) Write a program that receives a three-digit number and prints if the number in the last digit is even or odd.
            int x = int.Parse(Console.ReadLine());
            if(x < 1000 && x >= 100)
            {
                var r = x / 100;
                if (r % 2 == 0)
                    Console.WriteLine("even");
                else
                    Console.WriteLine("odd");
            }
            else
                Console.WriteLine("Invaild number");
        }
    }
}
