using Tyuiu.GoryaevTT.Sprint6.Task0.V26.Lib;
namespace Tyuiu.GoryaevTT.Sprint6.Task0.V26.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            Assert.AreEqual(2, ds.Calculate(-1));
        }
    }
}
