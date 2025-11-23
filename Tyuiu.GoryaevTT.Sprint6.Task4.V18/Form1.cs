using Tyuiu.GoryaevTT.Sprint6.Task4.V18.Lib;
namespace Tyuiu.GoryaevTT.Sprint6.Task4.V18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Class1 ds = new Class1();
        private void ButtonDone(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBox1.Text);
                int end = Convert.ToInt32(textBox2.Text);
                double[] values = ds.GetMassFunction(start, end);
                this.chart1.ChartAreas[0].AxisX.Title = "X";
                this.chart1.ChartAreas[0].AxisY.Title = "Y";
                textBox3.Text = "";
                chart1.Series[0].Points.Clear();
                for (int i = 0; i < values.Length; i++)
                {
                    this.chart1.Series[0].Points.AddXY(start,values[i]);
                    textBox3.AppendText(values[i] + Environment.NewLine);
                    start++;
                }
            }
            catch { MessageBox.Show("Wrong Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void ButtonSave(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBox3.Text);
                DialogResult dia = MessageBox.Show("Файл" + path + "успешно сохранен! \n Открыть его?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dia == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch { MessageBox.Show("Wrong Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
