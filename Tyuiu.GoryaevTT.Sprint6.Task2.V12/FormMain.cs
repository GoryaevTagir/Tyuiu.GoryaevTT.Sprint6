using Tyuiu.GoryaevTT.Sprint6.Task2.V12.Lib;
namespace WinFormsAppChart
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        Class1 ds = new Class1();
        private void getHelp()
        {
            MessageBox.Show("Выполнил Тагир Горяев", "Инфа");
        }
        private void getResult()
        {
            try
            {
                int start = Convert.ToInt32(textBox1.Text);
                int end = Convert.ToInt32(textBox2.Text);
                this.chartResult.Titles.Add("График функции y");
                this.chartResult.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult.ChartAreas[0].AxisY.Title = "Ось Y";

                double[] values = ds.GetMassFunction(start, end);
                for (int i = 0; i < values.Length; i++)
                {
                    this.dataGridViewFunc.Rows.Add(Convert.ToString(start), Convert.ToString(values[i]));
                    this.chartResult.Series[0].Points.AddXY(start, values[i]);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("dasd", "daa");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
