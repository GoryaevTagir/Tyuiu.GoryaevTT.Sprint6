using Tyuiu.GoryaevTT.Sprint6.Task3.V27.Lib;    
namespace Tyuiu.GoryaevTT.Sprint6.Task3.V27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Class1 DataService = new Class1();
        int[,] mat = new int[,] { { 9, 13, -14, 23, 1 }, { 15, -17, 21, 25, 23 }, { -4, 29, -20, -10, 14 }, { 27, 33, 12, 33, -12 }, { 18, -9, -5, 6, 3 } };
        private void Load_Base(object sender, EventArgs e)
        {
            int rows = mat.GetUpperBound(0) + 1;
            int cols = mat.Length / rows;
            dataGridView1.ColumnCount = cols;
            dataGridView1.RowCount = rows;
            for (int i = 0; i < cols; i++)
            {
                dataGridView1.Columns[i].Width = 50;
            }
            for (int i = 0;i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(mat[i,j]);
                }
            }
        } 
    }
}
