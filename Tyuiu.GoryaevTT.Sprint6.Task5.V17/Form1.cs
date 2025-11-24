using Tyuiu.GoryaevTT.Sprint6.Task5.V17.Lib;
namespace Tyuiu.GoryaevTT.Sprint6.Task5.V17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Class1 ds = new Class1();
        string path = @"C:\\DataSprint6\InPutDataFileTask5V17.txt";
        private void getResult_B(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Width = 20;
            dataGridView1.Columns[1].Width = 50;
            this.chart1.ChartAreas[0].AxisX.Title = "Îñü X";
            this.chart1.ChartAreas[0].AxisY.Title = "Îñü Y";
            chart1.Series[0].Points.Clear();
            double[] nums = ds.LoadFromDataFile(path);
            for (int i = 0; i < nums.Length; i++)
            {
                dataGridView1.Rows.Add(Convert.ToString(i), Convert.ToString(nums[i]));
                chart1.Series[0].Points.AddXY(i,nums[i]);
            }
        }
        private void getShow(object sender, EventArgs e)
        {
            System.Diagnostics.Process ps = new System.Diagnostics.Process();
            ps.StartInfo.FileName = "notepad.exe";
            ps.StartInfo.Arguments = path;
            ps.Start();
        }
    }
}
