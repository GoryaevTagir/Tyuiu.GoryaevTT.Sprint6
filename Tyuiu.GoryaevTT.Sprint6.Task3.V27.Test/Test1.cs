using Tyuiu.GoryaevTT.Sprint6.Task3.V27.Lib;
namespace Tyuiu.GoryaevTT.Sprint6.Task3.V27.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            int[,] res = new int[,] { {9 , 13, -14 , 23 ,1 }, {15, -17 , 21 , 25 , 23 }, { -4 , 29, -20, -10,  14 } , {27 , 33 , 12 , 33 , -12 },{ 18, -9, -5,   6,   3 } };
            int[,] ser = new int[,] { { 9, 13, -14, -10, 1 }, { 15, -17, 21, 6, 23 }, { -4, 29, -20, 23, 14 }, { 27, 33, 12, 25, -12 }, { 18, -9, -5, 33, 3 } };
            CollectionAssert.AreEqual(ser, ds.Calculate(res));
        }
    }
}
