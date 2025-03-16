using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Interface;
using Calculator.SanahOi;
namespace Calculator.MainCalculator
{
    public class BaseCalculator : Calculator, IOperation
    {
        public Memory memory;
        public BaseCalculator()
        {
            memory = new Memory();
            Result = 0;
        }
        public void ClearResult()
        {
            Result = 0;
        }
        public int add(int value)
        {
            return Result += value;
        }
        public int subtruct(int value)
        {
            return Result -= value;
        }
        public void MS()
        {
            memory.Save(Result);
        }
    }
}
