using SampleTest;

namespace TestMathOp
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MathOp mth = new MathOp();
            int res = mth.Add(20, 20);
            Assert.AreEqual(res,40);
        }

        [TestMethod]
        public void TestMethodSub()
        {
            MathOp mth = new MathOp();
            int res = mth.Sub(50,20);
            Assert.AreEqual(res, 30);
            //int res2 = mth.Sub(60, 20);
            //Assert.AreEqual(res2, 40);
        }
        [TestMethod]
        public void TestMethodSub2()
        {
            MathOp mth = new MathOp();
            int res2 = mth.Sub(60, 20);
            Assert.AreEqual(res2, 50); //failed test case
        }
        [TestMethod]
        public void TestMethodProd()
        {
            MathOp mth = new MathOp();
            int res = mth.Mul(50, 40);
            Assert.AreEqual(res, 2000);
        }

    }
}
