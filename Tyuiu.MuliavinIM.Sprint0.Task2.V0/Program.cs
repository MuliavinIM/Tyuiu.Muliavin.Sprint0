using Tyuiu.MuliavinIM.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MuliavinIM.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Иван"));
            Console.ReadKey();
        }
    }
}