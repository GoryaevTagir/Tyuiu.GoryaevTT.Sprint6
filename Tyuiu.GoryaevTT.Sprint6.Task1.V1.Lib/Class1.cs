using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GoryaevTT.Sprint6.Task1.V1.Lib
{
    public class Class1 : ISprint6Task1V1
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[stopValue - startValue + 1];
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                result[count] = Math.Round((Math.Cos(2*i)+(Math.Sin(i))/(i + 2.5)+ 2*i), 2);
                count++;
            }
            return result;
        }
    }
}
