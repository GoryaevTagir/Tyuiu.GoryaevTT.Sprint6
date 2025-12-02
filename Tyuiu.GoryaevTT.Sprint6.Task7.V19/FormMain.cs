using Tyuiu.GoryaevTT.Sprint6.Task7.V19.Lib;
namespace Tyuiu.GoryaevTT.Sprint6.Task7.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        static int rows;
        static int columns;
        static string path;

        public static int[,] LoadFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            rows = lines.Length;
            columns = lines[0].Split(";").Length;
            int[,] ar = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] line = lines[i].Split(";");
                for (int j = 0; j < columns; j++)
                {
                    ar[i, j] = int.Parse(line[j]);
                }
            }
            return ar;
        }

        private void Help(object sender, EventArgs e)
        {
            AboutGTT at = new AboutGTT();
            at.ShowDialog();
        }

        private void OpenFileChoice(object sender, EventArgs e)
        {
            openFileDialogChoice_GTT.ShowDialog();
            path = openFileDialogChoice_GTT.FileName;
            int[,] arra = new int[rows, columns];
            arra = LoadFile(path);

            dataGridViewIn.ColumnCount = columns;
            dataGridViewIn.RowCount = rows;
            dataGridView1.ColumnCount = columns;
            dataGridView1.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridView1.Columns[0].Width = 25;
                dataGridView1.Columns[0].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridView1.Rows[0].Cells[0].Value = arra[i, j];
                }
            }
            arra = ds.GetMatrix(path);
            buttonTry_GTT.Enabled = true;
        }
        private void Done(object sender, EventArgs e)
        {
            int[,] arra = new int[rows, columns];
            arra = ds.GetMatrix(path);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewIn.Rows[0].Cells[0].Value = arra[i, j];
                }
            }
            buttonSave_GTT.Enabled = true;
        }
        private void Save(object sender, EventArgs e)
        {
            saveFileDialogData_GTT.FileName = "OutPutFileTask7.csv";
            saveFileDialogData_GTT.InitialDirectory = @"C:\DataSprint6";
            saveFileDialogData_GTT.ShowDialog();
            string path = saveFileDialogData_GTT.FileName;
            FileInfo info = new FileInfo(path);
            bool exist = info.Exists;
            if (exist)
            {
                File.Delete(path);
            }
            int rows = dataGridViewIn.Rows.Count;
            int columns = dataGridViewIn.Columns.Count;
            string str = "";
            for (int i = 0;i < rows;i++)
            {
                for (int j = 0;j < columns; j++)
                {
                    {
                        if (j != columns - 1)
                        {
                            str += dataGridViewIn.Rows[0].Cells[0].Value + ";";
                        }
                        else
                        {
                            str += dataGridViewIn.Rows[0].Cells[0].Value;
                        }
                    }
                    File.AppendAllText(path, str + Environment.NewLine);
                    str = "";
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
