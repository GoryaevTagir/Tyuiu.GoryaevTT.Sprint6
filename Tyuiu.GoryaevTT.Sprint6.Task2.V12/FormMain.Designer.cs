namespace WinFormsAppChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunc = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)chartResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunc).BeginInit();
            SuspendLayout();
            // 
            // chartResult
            // 
            chartArea1.Name = "ChartArea1";
            chartResult.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartResult.Legends.Add(legend1);
            chartResult.Location = new Point(796, 88);
            chartResult.Margin = new Padding(5, 6, 5, 6);
            chartResult.Name = "chartResult";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartResult.Series.Add(series1);
            chartResult.Size = new Size(496, 368);
            chartResult.TabIndex = 0;
            chartResult.Text = "chart1";
            // 
            // dataGridViewFunc
            // 
            dataGridViewFunc.AllowUserToDeleteRows = false;
            dataGridViewFunc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunc.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewFunc.Location = new Point(438, 88);
            dataGridViewFunc.Name = "dataGridViewFunc";
            dataGridViewFunc.RowHeadersVisible = false;
            dataGridViewFunc.RowHeadersWidth = 62;
            dataGridViewFunc.Size = new Size(302, 468);
            dataGridViewFunc.TabIndex = 1;
            // 
            // X
            // 
            X.HeaderText = "DataX";
            X.MinimumWidth = 8;
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 150;
            // 
            // Y
            // 
            Y.HeaderText = "DataY";
            Y.MinimumWidth = 8;
            Y.Name = "Y";
            Y.ReadOnly = true;
            Y.Width = 150;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 35);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(231, 109);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 35);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(118, 390);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 794);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridViewFunc);
            Controls.Add(chartResult);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chartResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult;
        private DataGridView dataGridViewFunc;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}
