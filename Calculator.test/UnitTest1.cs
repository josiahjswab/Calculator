using NUnit.Framework;


namespace Calculator.test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        
        }

        [Test]
        public void TestBarCalc()
        {
            int foo = FooCalc.BarCalc(120, 60, 2);

            Assert.AreEqual(14400, foo);
        }
    }
}
