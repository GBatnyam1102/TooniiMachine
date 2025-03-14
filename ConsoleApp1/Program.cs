using Calculator;
using Calculator.MainCalculator;

namespace Undsen
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCalculator baseCalculator = new BaseCalculator();
            baseCalculator.add(13);
            baseCalculator.subtruct(14);
            Console.WriteLine(baseCalculator.Result);
            baseCalculator.MS();
        }
    }
}