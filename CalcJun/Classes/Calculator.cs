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
        private IOperation[] operations = new IOperation[4];
        public Calculator()
        {
            operations[0] = new OperationPlus();
            operations[1] = new OperationMinus();
            operations[2] = new OperationUmn();
            operations[3] = new OperationDel();
        }
        public float ExecuteOperation(string operation, float a, float b)
        {
            foreach( var op in operations)
            {
                if (operation == op.Name)
                {
                    return op.Execute(a, b);
                }
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
