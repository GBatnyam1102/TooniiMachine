using Calculator.MainCalculator;

namespace TestProject
{
    [TestClass]
    public sealed class CreateTests
    {
        [TestMethod]
        public void BaseCalculatorTests()
        {
            BaseCalculator baseCalculator = new BaseCalculator();
            baseCalculator.subtruct(90);
            baseCalculator.add(12);
            Assert.AreEqual(-78, baseCalculator.Result);
            baseCalculator.ClearResult();
            Assert.AreEqual(0, baseCalculator.Result);
        }
        [TestMethod]
        public void MemorySaveAndRemoveTests()
        {
            BaseCalculator calculator = new BaseCalculator();
            calculator.Result = -36;
            calculator.MS();
                
            calculator.memory.OneItemRemove(40);
            Assert.AreEqual(1, calculator.memory.memoryItems.Count);

            calculator.memory.OneItemRemove(-36);
            Assert.AreEqual(0, calculator.memory.memoryItems.Count);
        }
    }
}
