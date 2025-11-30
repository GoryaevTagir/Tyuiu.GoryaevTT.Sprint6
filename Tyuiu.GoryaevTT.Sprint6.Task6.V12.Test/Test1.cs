using Tyuiu.GoryaevTT.Sprint6.Task6.V12.Lib;
namespace Tyuiu.GoryaevTT.Sprint6.Task6.V12.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            string path = @"C:\DataSprint6\InPutDataFileTask6V12.txt";
            string lin = "iKDOjtfsPmw";
            Assert.AreEqual(lin, ds.CollectTextFromFile(path));
        }
    }
}
