using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GoryaevTT.Sprint6.Task6.V12.Lib
{
    public class Class1 : ISprint6Task6V12
    {
        public string CollectTextFromFile(string path)
        {
            string res = "";
            using (StreamReader read = new StreamReader(path))
            {
                string line;
                while ((line = read.ReadLine()) != null)
                {
                    if (line.Contains(" "))
                    {
                        line.Split(" ");
                        foreach (string part in line.Split())
                        {
                            if (part.Contains("w"))
                            {
                                
                                res += part ;
                            }
                        }
                    }
                }
            }
            return res;
        }
    }
}
