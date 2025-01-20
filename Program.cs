namespace GruopTasking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //=======(>>>>Q1<<<<) Write a program that receives two numbers and prints the larger one, but a multiple.
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(x, y) * 2);
        }
    }
}
