using Tyuiu.GoryaevTT.Sprint6.Task1.V1.Lib;
namespace Tyuiu.GoryaevTT.Sprint6.Task1.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        Class1 ds = new Class1();
        private void getResult(object sender, EventArgs e)
        {
            try
            { 
                int start = Convert.ToInt32(DataX1_GTT.Text);
                int end = Convert.ToInt32(DataX2_GTT.Text);
                double[] values = ds.GetMassFunction(start, end);
                Result_GTT.Text = "";
                Result_GTT.AppendText("+-----+-----+" + Environment.NewLine);
                Result_GTT.AppendText("|  F  |  x  |" + Environment.NewLine);
                Result_GTT.AppendText("+-----|-----+" + Environment.NewLine);
                for (int i = 0; i < values.Length ; i++)
                {
                    Result_GTT.AppendText(string.Format("|{0,5:d} | {1, 5:f2} |", start, values[i]));
                    start++;
                }
                Result_GTT.AppendText("+-----+-----+" + Environment.NewLine);
            }
            catch 
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void getHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Таск выполнил Тагир Горяев ПИНб", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
