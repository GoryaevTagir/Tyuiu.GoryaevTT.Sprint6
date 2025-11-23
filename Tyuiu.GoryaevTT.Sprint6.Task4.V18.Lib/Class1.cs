using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GoryaevTT.Sprint6.Task4.V18.Lib
{
    public class Class1 : ISprint6Task4V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[stopValue - startValue + 1];
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                result[count] = Math.Round(((2 * i - 3) / (Math.Cos(i) + i)) + 5, 2);
                count++;
            }
            return result;
        }
    }
}
