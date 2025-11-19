using System.Security.AccessControl;
using Tyuiu.GoryaevTT.Sprint6.Task0.V26.Lib;
namespace Tyuiu.GoryaevTT.Sprint6.Task0.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void getResult_Click(object sender, EventArgs e)
        {
            Class1 ds = new Class1();
            try
            {
                Answer_GTT.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(DataX_GTT.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void try_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск0 выполнил Горяев Тагир ПИНб-25-1", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
