using Tyuiu.GoryaevTT.Sprint6.Task5.V17.Lib;
namespace Tyuiu.GoryaevTT.Sprint6.Task5.V17.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            string path = @"C:\\DataSprint6\InPutDataFileTask5V17.txt";
            double[] res = new double[] {-17, -14.32, -7.84, -1.57, -3.64, -13.26, -8.91, -17.77, -9, -1.49, -7 };
            CollectionAssert.AreEqual(res, ds.LoadFromDataFile(path));
        }
    }
}
