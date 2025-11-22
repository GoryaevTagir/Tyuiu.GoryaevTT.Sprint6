using Tyuiu.GoryaevTT.Sprint6.Task1.V1.Lib;
namespace Tyuiu.GoryaevTT.Sprint6.Task1.V1.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            double[] doubles = new double[] { };
            CollectionAssert.AreEqual(doubles, ds.GetMassFunction(-5, 5));
        }
    }
}
