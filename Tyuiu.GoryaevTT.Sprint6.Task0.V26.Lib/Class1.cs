using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GoryaevTT.Sprint6.Task0.V26.Lib
{
    public class Class1 : ISprint6Task0V26
    {
        public double Calculate(int x)
        {
            double y = (Math.Pow(x, 2) + 1) / (3 * x + 4);
            return Math.Round(y, 3);
        }
    }
}
