namespace Tyuiu.GoryaevTT.Sprint6.Task7.V19
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            buttonSave_GTT = new Button();
            buttonInfo_GTT = new Button();
            buttonTry_GTT = new Button();
            buttonLoad_GTT = new Button();
            groupTask_GTT = new GroupBox();
            textBox1 = new TextBox();
            panel2 = new Panel();
            groupData_GTT = new GroupBox();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            groupResult_GTT = new GroupBox();
            dataGridViewIn = new DataGridView();
            openFileDialogChoice_GTT = new OpenFileDialog();
            saveFileDialogData_GTT = new SaveFileDialog();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            groupTask_GTT.SuspendLayout();
            panel2.SuspendLayout();
            groupData_GTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            groupResult_GTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSave_GTT);
            panel1.Controls.Add(buttonInfo_GTT);
            panel1.Controls.Add(buttonTry_GTT);
            panel1.Controls.Add(buttonLoad_GTT);
            panel1.Controls.Add(groupTask_GTT);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1169, 204);
            panel1.TabIndex = 0;
            // 
            // buttonSave_GTT
            // 
            buttonSave_GTT.Enabled = false;
            buttonSave_GTT.Location = new Point(324, 120);
            buttonSave_GTT.Name = "buttonSave_GTT";
            buttonSave_GTT.Size = new Size(99, 67);
            buttonSave_GTT.TabIndex = 2;
            buttonSave_GTT.Text = "Save";
            buttonSave_GTT.UseVisualStyleBackColor = true;
            buttonSave_GTT.Click += Save;
            // 
            // buttonInfo_GTT
            // 
            buttonInfo_GTT.Location = new Point(997, 118);
            buttonInfo_GTT.Name = "buttonInfo_GTT";
            buttonInfo_GTT.Size = new Size(112, 68);
            buttonInfo_GTT.TabIndex = 1;
            buttonInfo_GTT.Text = "Info";
            buttonInfo_GTT.UseVisualStyleBackColor = true;
            buttonInfo_GTT.Click += Help;
            // 
            // buttonTry_GTT
            // 
            buttonTry_GTT.Enabled = false;
            buttonTry_GTT.Location = new Point(169, 119);
            buttonTry_GTT.Name = "buttonTry_GTT";
            buttonTry_GTT.Size = new Size(112, 68);
            buttonTry_GTT.TabIndex = 1;
            buttonTry_GTT.Text = "Try";
            buttonTry_GTT.UseVisualStyleBackColor = true;
            buttonTry_GTT.Click += Done;
            // 
            // buttonLoad_GTT
            // 
            buttonLoad_GTT.Location = new Point(32, 119);
            buttonLoad_GTT.Name = "buttonLoad_GTT";
            buttonLoad_GTT.Size = new Size(112, 68);
            buttonLoad_GTT.TabIndex = 1;
            buttonLoad_GTT.Text = "Load";
            buttonLoad_GTT.UseVisualStyleBackColor = true;
            buttonLoad_GTT.Click += OpenFileChoice;
            // 
            // groupTask_GTT
            // 
            groupTask_GTT.Controls.Add(textBox1);
            groupTask_GTT.Location = new Point(12, 12);
            groupTask_GTT.Name = "groupTask_GTT";
            groupTask_GTT.Size = new Size(1145, 101);
            groupTask_GTT.TabIndex = 0;
            groupTask_GTT.TabStop = false;
            groupTask_GTT.Text = "УСЛОВИЕ:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 34);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(1091, 66);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panel2
            // 
            panel2.Controls.Add(groupData_GTT);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 204);
            panel2.Name = "panel2";
            panel2.Size = new Size(537, 449);
            panel2.TabIndex = 1;
            // 
            // groupData_GTT
            // 
            groupData_GTT.Controls.Add(dataGridView1);
            groupData_GTT.Location = new Point(32, 28);
            groupData_GTT.Name = "groupData_GTT";
            groupData_GTT.Size = new Size(471, 390);
            groupData_GTT.TabIndex = 0;
            groupData_GTT.TabStop = false;
            groupData_GTT.Text = "ВВОД:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(418, 331);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupResult_GTT);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(537, 204);
            panel3.Name = "panel3";
            panel3.Size = new Size(632, 449);
            panel3.TabIndex = 2;
            // 
            // groupResult_GTT
            // 
            groupResult_GTT.Controls.Add(dataGridViewIn);
            groupResult_GTT.Location = new Point(53, 28);
            groupResult_GTT.Name = "groupResult_GTT";
            groupResult_GTT.Size = new Size(567, 390);
            groupResult_GTT.TabIndex = 0;
            groupResult_GTT.TabStop = false;
            groupResult_GTT.Text = "ВЫВОД:";
            // 
            // dataGridViewIn
            // 
            dataGridViewIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn.Location = new Point(32, 34);
            dataGridViewIn.Name = "dataGridViewIn";
            dataGridViewIn.RowHeadersWidth = 62;
            dataGridViewIn.Size = new Size(487, 331);
            dataGridViewIn.TabIndex = 0;
            dataGridViewIn.CellContentClick += dataGridView2_CellContentClick;
            // 
            // openFileDialogChoice_GTT
            // 
            openFileDialogChoice_GTT.FileName = "openFileDialogChoice_GTT";
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 653);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Спринт6|Таск7|Вариант19|Горяев.Т.Т";
            panel1.ResumeLayout(false);
            groupTask_GTT.ResumeLayout(false);
            groupTask_GTT.PerformLayout();
            panel2.ResumeLayout(false);
            groupData_GTT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            groupResult_GTT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupTask_GTT;
        private Panel panel2;
        private TextBox textBox1;
        private GroupBox groupData_GTT;
        private Panel panel3;
        private GroupBox groupResult_GTT;
        private Button buttonInfo_GTT;
        private Button buttonTry_GTT;
        private Button buttonLoad_GTT;
        private DataGridView dataGridView1;
        private Button buttonSave_GTT;
        private OpenFileDialog openFileDialogChoice_GTT;
        private DataGridView dataGridViewIn;
        private SaveFileDialog saveFileDialogData_GTT;
        private ToolTip toolTip1;
    }
}
