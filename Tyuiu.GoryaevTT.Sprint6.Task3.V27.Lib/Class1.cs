using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GoryaevTT.Sprint6.Task3.V27.Lib
{
    public class Class1 : ISprint6Task3V27
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[] data = new int[5];
            for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < matrix.Length/(matrix.GetUpperBound(0)+1); j++)
                {
                    if (j == 3)
                    {
                        data[i] = matrix[i,j];
                    }
                }
            }
            Array.Sort(data);
            for (int i = 0;i < matrix.GetUpperBound(0) + 1; i++)
            {
                matrix[i, 3] = data[i];
            } 
            return matrix;
        }
    }
}
