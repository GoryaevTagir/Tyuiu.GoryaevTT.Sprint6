using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GoryaevTT.Sprint6.Task7.V19.Lib
{
    public class Class1 : ISprint6Task7V19
    {
        public int[,] GetMatrix(string path)
        {
            int[,] ans = new int[10,10];
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                int count = 0;
                while((line = reader.ReadLine()) != null)
                {
                    string[] tum = line.Split(";");
                    if (count == 1)
                    {
                        for (int i = 0; i < 10 ;i++)
                        {
                            if (Convert.ToInt32(tum[i]) % 2 == 0)
                            {
                                tum[i] = "2";
                            }
                        }
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        ans[count,i] = Convert.ToInt32(tum[i]); 
                    }
                    count++;
                }
            }
            return ans;
        }
    }
}
