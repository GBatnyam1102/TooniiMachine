using Calculator.MainCalculator;

namespace TestProject
{
    [TestClass]
    public sealed class BaseCalculatorTests
    {
        [TestMethod]
        public void ZeroAdd()
        {
            BaseCalculator baseCalculator = new BaseCalculator();
            baseCalculator.add(0);
            Assert.AreEqual(0, baseCalculator.Result);
        }
        [TestMethod]
        public void ZeroSub()
        {
            BaseCalculator baseCalculator = new BaseCalculator();
            baseCalculator.subtruct(0);
            Assert.AreEqual(0, baseCalculator.Result);
        }

        [TestMethod]
        public void ZeroSubPositiveValue()
        {
            BaseCalculator baseCalculator = new BaseCalculator();
            baseCalculator.subtruct(25);
            Assert.AreEqual(-25, baseCalculator.Result);
        }
        [TestMethod]
        public void ZeroSubNegativeValue()
        {
            BaseCalculator baseCalculator = new BaseCalculator();
            baseCalculator.subtruct(-2);
            Assert.AreEqual(2, baseCalculator.Result);
        }
        [TestMethod]
        public void AddOverRangePos()
        {
            BaseCalculator baseCalculator = new BaseCalculator();
            baseCalculator.add(2147483647);
            Assert.AreEqual(2147483647, baseCalculator.Result);
        }
        [TestMethod]
        public void AddOverRangeNega()
        {
            BaseCalculator calc = new BaseCalculator();
            calc.add(-2147483648);
            Assert.AreEqual(-2147483648, calc.Result);
        }
        [TestMethod]
        public void SubOverRangePos()
        {
            BaseCalculator calc = new BaseCalculator();
            calc.subtruct(2147483647);
            Assert.AreEqual(-2147483647, calc.Result);
        }
        [TestMethod]
        public void SubOverRangeNega()
        {
            BaseCalculator calc = new BaseCalculator();
            calc.subtruct(-2147483648);
            long too = -2147483648;
            Assert.AreEqual(too, calc.Result);
        }
        [TestMethod]
        public void SubNextAdd()
        {
            BaseCalculator calc = new BaseCalculator();
            calc.subtruct(9800);
            calc.add(900);
            Assert.AreEqual(-8900, calc.Result);
        }
        [TestMethod]
        public void AddNextSub()
        {
            BaseCalculator calc = new BaseCalculator();
            calc.add(9000);
            calc.subtruct(8900);
            Assert.AreEqual(100, calc.Result);
        }
        [TestMethod]
        public void ManyAddNextSub()
        {
            BaseCalculator calc = new BaseCalculator();
            calc.add(90);
            calc.add(921);
            calc.add(87);
            calc.add(123);
            calc.add(8);
            calc.subtruct(21);
            Assert.AreEqual(1208, calc.Result);
        }
        [TestMethod]
        public void ManySubNextAdd()
        {
            BaseCalculator calc = new BaseCalculator();
            calc.subtruct(234);
            calc.subtruct(66);
            calc.subtruct(-98);
            calc.subtruct(-65);
            calc.subtruct(65);
            calc.subtruct(9); ;
            calc.add(900);
            Assert.AreEqual(689, calc.Result);
        }
        [TestMethod]
        public void ManySubZero()
        {
            BaseCalculator calc = new BaseCalculator();
            calc.subtruct(0);
            calc.subtruct(0);
            calc.subtruct(0);
            calc.subtruct(0);
            calc.subtruct(0);
            Assert.AreEqual(0, calc.Result);
        }
        [TestMethod]
        public void ManyAddZero()
        {
            BaseCalculator calc = new BaseCalculator();
            calc.add(0);
            calc.add(0);
            calc.add(0);
            calc.add(0);
            calc.add(0);
            Assert.AreEqual(0, calc.Result);
        }
        [TestMethod]
        public void ManyNegaValueAdd()
        {
            BaseCalculator calc = new BaseCalculator();
            calc.add(-900);
            calc.add(-89);
            calc.add(-25);
            calc.add(-124);
            calc.add(-36);
            calc.add(-24);
            calc.add(-0);
            Assert.AreEqual(-1198, calc.Result);
        }
        [TestMethod]
        public void ManyPosValueSub()
        {
            BaseCalculator calc = new BaseCalculator();
            calc.subtruct(-123);
            calc.subtruct(-123);
            calc.subtruct(-123);
            calc.subtruct(-123);
            calc.subtruct(-123);
            calc.subtruct(-123);
            Assert.AreEqual(738, calc.Result);
        }
        [TestMethod]
        public void ClearResulttest()
        {
            BaseCalculator calc = new BaseCalculator();
            calc.Result = 900;
            calc.ClearResult();
            Assert.AreEqual(0, calc.Result);
        }
    }
    [TestClass]
    public sealed class MemoryTest()
    {
        [TestMethod]
        public void PosValueSave()
        {
            BaseCalculator calc = new BaseCalculator();
            calc.Result = 900;
            calc.MS();
            Assert.AreEqual(900, calc.memory.memoryItems[0].Value);
        }
        [TestMethod]
        public void NegValueSave()
        {
            BaseCalculator calc = new BaseCalculator();
            calc.Result = -980;
            calc.MS();
            Assert.AreEqual(-980, calc.memory.memoryItems[0].Value);
        }
        [TestMethod]
        public void ZeroValueSave()
        {
            BaseCalculator calc = new BaseCalculator();
            calc.MS();
            Assert.AreEqual(0, calc.memory.memoryItems[0].Value);  
        }
        [TestMethod]
        public void ManyNegValueSave()
        {
            BaseCalculator calc = new BaseCalculator();
            calc.Result = -98;
            calc.MS();
            calc.Result = -7;
            calc.MS();
            calc.Result = -235;
            calc.MS();
            calc.Result = -25;
            calc.MS();
            calc.Result = -65;
            calc.MS();
            calc.Result = -12;
            calc.MS();
            int[] toonuud = { -98, -7, -235, -25, -65, -12 };
            CollectionAssert.Equals(toonuud, calc.memory.memoryItems.ToArray());
        }
        [TestMethod]
        public void ManyPosValueSave()
        {
            BaseCalculator calc = new BaseCalculator();
            calc.Result = 900;
            calc.MS();
            calc.Result = 250;
            calc.MS();
            calc.Result = 14;
            calc.MS();
            calc.Result = 60;
            calc.MS();
            calc.Result = 700;
            calc.MS();
            int[] toonuud = { 900, 250, 14, 60, 700 };
            CollectionAssert.Equals(toonuud, calc.memory.memoryItems.ToArray());

        }
        [TestMethod]
        public void ManyZeroPosValue()
        {
            BaseCalculator calc = new BaseCalculator();
            calc.MS();
            calc.MS();
            calc.MS();
            calc.MS();
            calc.MS(); 
            calc.MS();
            int[] too = { 0, 0, 0, 0, 0, 0 };
            CollectionAssert.Equals(too, calc.memory.memoryItems.ToArray());
        }
        [TestMethod]
        public void ManyValuesSave()
        {
            BaseCalculator calc = new BaseCalculator();
            calc.MS();
            calc.Result = 900;
            calc.MS();
            calc.Result = -89;
            calc.MS();
            calc.Result = 9887654;
            calc.MS();
            calc.Result = -98765;
            calc.MS();
            int[] toonuud = { 0, 900, -89, 9887654, -98765 };
            CollectionAssert.Equals(toonuud, calc.memory.memoryItems.ToArray());
        }
        [TestMethod]
        public void CorrectMemoryOneItemRemove()
        {
            BaseCalculator calc = new BaseCalculator();
            calc.MS();
            calc.Result = 900;
            calc.MS();
            calc.Result = -99;
            calc.MS();
            calc.memory.OneItemRemove(900);
            int[] toonud = { 0, -99 };
            CollectionAssert.Equals(toonud, calc.memory.memoryItems.ToArray());
        }

        [TestMethod]
        public void FaultMemoryIneItemRemove()
        {
            BaseCalculator calc = new BaseCalculator();
            calc.MS();
            calc.Result = 900;
            calc.MS();
            calc.Result = 899;
            calc.MS();
            calc.memory.OneItemRemove(-9);
            int[] too = { 0, 900, 899 };
            CollectionAssert.Equals(too, calc.memory.memoryItems.ToArray());
        }

    }
    [TestClass]
    public sealed class BaseCalculatorAndMemoryLogic()
    {
        [TestMethod]
        public void AddNextMemorySave()
        {
            BaseCalculator calc = new BaseCalculator();
            calc.add(98);
            calc.add(78);
            calc.MS();
            Assert.AreEqual(176, calc.memory.memoryItems[0].Value);
           
        }

        [TestMethod]
        public void SubNextMemorySave()
        {
            BaseCalculator calc = new BaseCalculator();
            calc.subtruct(98);
            calc.subtruct(-100);
            calc.MS();
            Assert.AreEqual(2, calc.memory.memoryItems[0].Value);

        }
        [TestMethod]
        public void MemorySaveNextAdd()
        {
            BaseCalculator calc = new BaseCalculator();
            calc.Result = 90;
            calc.MS();
            calc.add(-90);
            calc.add(97);
            Assert.AreEqual(97, calc.Result);
        }
        [TestMethod]
        public void MemorySaveNextSub()
        {
            BaseCalculator calc = new BaseCalculator();
            calc.Result = 90;
            calc.MS();
            calc.subtruct(-90);
            calc.subtruct(-89);
            Assert.AreEqual(269, calc.Result);
        }

    }
}
