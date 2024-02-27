namespace Exam_Task
{
    internal class Program
    {
        public static void Main()
        {
            Console.Write("Input X: ");
            int X = int.Parse(Console.ReadLine());
            double Y = Math.Log(X);
            Console.WriteLine($"Y = {Y}");
            Console.ReadKey();
        }
    }
}
