using ConsoleApp1;
namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
        Calculate calculate;
        [TestInitialize]
        public void Init()
        {
            calculate = new Calculate();
        }

        [TestCleanup]
        public void Close()
        {
            calculate = null;
        }

        [TestMethod]
        public void Test___ConsoleApp1_Calculate_getSum()
        {
            //Calculate calculate = new Calculate();
            Calculate calculate2 = calculate;
            Assert.AreEqual(5, calculate.getSum(2,3));
            Assert.AreNotEqual(6, calculate.getSum(2, 3));
            Assert.IsTrue(calculate.getSum(2, 3) == 5);
            Assert.AreSame(calculate, calculate2);
        }

        [TestMethod]
        public void Test___ConsoleApp1_Calculate_getDivision()
        {
            //Calculate calculate = new Calculate();            
            Assert.AreEqual(5, calculate.getDivision(10, 2).result);
            Assert.AreEqual(ResultEnum.ERROR, calculate.getDivision(10, 0).resultEnum);
            Assert.IsTrue(calculate.getDivision(10, 0).error.Length > 0);
            Assert.IsNotNull(calculate.getDivision(10, 2).result);

            var result = calculate.getDivision(10, 2);
            Assert.AreEqual(5, result.result);
            Assert.AreNotEqual("", result.error);
            Assert.AreNotEqual("", result.resultEnum);
        }
    }
}