using CalcJun.Classes;
namespace CalcJun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calculator calculator = new Calculator();
            calculator.InputAndCalculate();
            Console.ReadLine();
        }
    }
}