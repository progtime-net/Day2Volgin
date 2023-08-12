using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcJun.Interfaces;

namespace CalcJun.Classes
{
    internal class OperationDel : IOperation
    {
        private string name = "/";
        public string Name { get { return name; } }

        public float Execute(float a, float b)
        {
            return a / b;
        }
    }
}
