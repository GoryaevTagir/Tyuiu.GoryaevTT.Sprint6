using Tyuiu.GoryaevTT.Sprint6.Task6.V12.Lib;

namespace Tyuiu.GoryaevTT.Sprint6.Task6.V12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Class1 ds = new Class1();
        string path = @"C:\DataSprint6\InPutDataFileTask6V12.txt";
        private void Done(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                textBox1.Clear();
            }
            textBox1.Text = ds.CollectTextFromFile(path);
        }
        private void Help(object sender, EventArgs e)
        {
            AboutBox1 inf = new AboutBox1();
            inf.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox2.Text = File.ReadAllText(openFileDialog1.FileName);
            button2.Enabled = true;
        }
    }
}
