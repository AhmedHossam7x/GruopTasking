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
            //=======(>>>>Q2<<<<) Write a program that receives two numbers and prints all the numbers between them.
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            for (int i = Math.Min(x1, y1); i <= Math.Max(x1, y1); i++)
                Console.Write(i + " ");
        }
    }
}
