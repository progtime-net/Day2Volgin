using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcJun.Interfaces;
using CalcJun.Classes;

namespace CalcJun.Classes
{
    public class Calculator : ICalculator
    {
        public float ExecuteOperation(string operation, float a, float b)
        {
            if (operation == "+")
            {
                OperationPlus operationPlus = new OperationPlus();
                return operationPlus.Execute(a, b);
            }
            else if (operation == "-")
            {
                OperationMinus operationMinus = new OperationMinus();
                return operationMinus.Execute(a, b);
            }
            else if (operation == "*")
            {
                OperationUmn operationUmn = new OperationUmn();
                return operationUmn.Execute(a, b);
            }
            else if (operation == "/")
            {
                OperationDel operationDel = new OperationDel();
                return operationDel.Execute(a, b);
            }
            return 0;
        }

        public void InputAndCalculate()
        {
            string z = Console.ReadLine();
            float a = float.Parse(z.Split(" ")[0]);
            float b = float.Parse(z.Split(" ")[2]);
            z = z.Split(" ")[1];
            Calculator calculator = new Calculator();
            Console.WriteLine(ExecuteOperation(z, a, b));
        }
    }
}
