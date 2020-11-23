using NUnit.Framework;
using SomeBusinessLib;

namespace NUnitTestProject
{
    public class Tests
    {
        private MyService _myService;

        [SetUp]
        public void Setup()
        {
            _myService = new MyService();
        }

        [Test]
        public void Test_Sum_Service()
        {
            int val1 = 10;
            int val2 = 20;
            int result = 30;

            Assert.AreEqual(result, _myService.Sum(val1, val2));
        }

        [Test]
        [TestCase(5)]
        [TestCase(10)]
        public void Test_Square_Service(int v)
        {
            Assert.AreEqual(v * v, _myService.Square(v));
        }
    }
}