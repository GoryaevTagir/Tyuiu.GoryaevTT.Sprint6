using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GoryaevTT.Sprint6.Task5.V17.Lib
{
    public class Class1 : ISprint6Task5V17
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader read = new StreamReader(path)) 
            {
                string line;
                while ((line = read.ReadLine()) != null)
                {
                    len++;
                }
            }
            double[] data = new double[len];
            int index = 0;
            using (StreamReader read = new StreamReader(path))
            {
                string line;
                while ((line = read.ReadLine()) != null)
                {
                    if (line.Contains(","))
                    {
                        line.Replace(",", ".");
                        data[index] = Math.Round(Convert.ToDouble(line), 3);
                    }
                    else { data[index] = Convert.ToInt32(line); }
                    index++;
                }
            } 
            data = data.Where(val => val < 0).ToArray();
            return data;
        }   
    }
}
