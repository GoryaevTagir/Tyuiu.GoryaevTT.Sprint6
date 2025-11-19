namespace Tyuiu.GoryaevTT.Sprint6.Task0.V26
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupDataX_GTT = new GroupBox();
            DataX_GTT = new TextBox();
            groupTask_GTT = new GroupBox();
            Task_GTT = new TextBox();
            groupResult_GTT = new GroupBox();
            Info_GTT = new Button();
            getResult_GTT = new Button();
            Answer_GTT = new TextBox();
            pictureBox1 = new PictureBox();
            groupDataX_GTT.SuspendLayout();
            groupTask_GTT.SuspendLayout();
            groupResult_GTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupDataX_GTT
            // 
            groupDataX_GTT.Controls.Add(DataX_GTT);
            groupDataX_GTT.Location = new Point(40, 275);
            groupDataX_GTT.Name = "groupDataX_GTT";
            groupDataX_GTT.Size = new Size(300, 150);
            groupDataX_GTT.TabIndex = 0;
            groupDataX_GTT.TabStop = false;
            groupDataX_GTT.Text = "Введите значение x:";
            // 
            // DataX_GTT
            // 
            DataX_GTT.Location = new Point(29, 53);
            DataX_GTT.Name = "DataX_GTT";
            DataX_GTT.Size = new Size(150, 35);
            DataX_GTT.TabIndex = 1;
            // 
            // groupTask_GTT
            // 
            groupTask_GTT.Controls.Add(Task_GTT);
            groupTask_GTT.Location = new Point(40, 91);
            groupTask_GTT.Name = "groupTask_GTT";
            groupTask_GTT.Size = new Size(300, 150);
            groupTask_GTT.TabIndex = 1;
            groupTask_GTT.TabStop = false;
            groupTask_GTT.Text = "УСЛОВИЕ:";
            // 
            // Task_GTT
            // 
            Task_GTT.Location = new Point(29, 52);
            Task_GTT.Multiline = true;
            Task_GTT.Name = "Task_GTT";
            Task_GTT.Size = new Size(242, 76);
            Task_GTT.TabIndex = 0;
            Task_GTT.Text = "Найти значение заданной функции.";
            // 
            // groupResult_GTT
            // 
            groupResult_GTT.Controls.Add(Info_GTT);
            groupResult_GTT.Controls.Add(getResult_GTT);
            groupResult_GTT.Controls.Add(Answer_GTT);
            groupResult_GTT.Location = new Point(434, 275);
            groupResult_GTT.Name = "groupResult_GTT";
            groupResult_GTT.Size = new Size(300, 150);
            groupResult_GTT.TabIndex = 2;
            groupResult_GTT.TabStop = false;
            groupResult_GTT.Text = "Результат:";
            // 
            // Info_GTT
            // 
            Info_GTT.FlatStyle = FlatStyle.Flat;
            Info_GTT.Location = new Point(211, 66);
            Info_GTT.Name = "Info_GTT";
            Info_GTT.Size = new Size(44, 34);
            Info_GTT.TabIndex = 2;
            Info_GTT.Text = "?";
            Info_GTT.UseVisualStyleBackColor = true;
            Info_GTT.TextChanged += buttonInfo_Click;
            Info_GTT.Click += buttonInfo_Click;
            // 
            // getResult_GTT
            // 
            getResult_GTT.Location = new Point(29, 110);
            getResult_GTT.Name = "getResult_GTT";
            getResult_GTT.Size = new Size(150, 34);
            getResult_GTT.TabIndex = 1;
            getResult_GTT.Text = "Ответ";
            getResult_GTT.UseVisualStyleBackColor = true;
            getResult_GTT.TextChanged += getResult_Click;
            getResult_GTT.Click += getResult_Click;
            // 
            // Answer_GTT
            // 
            Answer_GTT.Location = new Point(29, 53);
            Answer_GTT.Name = "Answer_GTT";
            Answer_GTT.ReadOnly = true;
            Answer_GTT.Size = new Size(150, 35);
            Answer_GTT.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(491, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(groupResult_GTT);
            Controls.Add(groupTask_GTT);
            Controls.Add(groupDataX_GTT);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6|Таск 0|Вариант 6|Горяев Т.Т.";
            groupDataX_GTT.ResumeLayout(false);
            groupDataX_GTT.PerformLayout();
            groupTask_GTT.ResumeLayout(false);
            groupTask_GTT.PerformLayout();
            groupResult_GTT.ResumeLayout(false);
            groupResult_GTT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupDataX_GTT;
        private GroupBox groupTask_GTT;
        private GroupBox groupResult_GTT;
        private TextBox DataX_GTT;
        private TextBox Task_GTT;
        private Button Info_GTT;
        private Button getResult_GTT;
        private TextBox Answer_GTT;
        private PictureBox pictureBox1;
    }
}
