using ConsoleApp1;
using NUnit;
using NUnit.Framework;

namespace MyNUnit
{
    [TestFixture]
    public class Class1
    {
        
        [Test]
        public void Test___ConsoleApp1_Calculate_getSum2()
        {
            Calculate calculate = new Calculate();
            Calculate calculate2 = calculate;
            Assert.AreEqual(5, calculate.getSum(2, 3));
            Assert.AreNotEqual(6, calculate.getSum(2, 3));
            Assert.IsTrue(calculate.getSum(2, 3) == 5);
            Assert.AreSame(calculate, calculate2);
            Assert.DoesNotThrow(() => calculate.getSum(11, 6));            
        }
    }
}