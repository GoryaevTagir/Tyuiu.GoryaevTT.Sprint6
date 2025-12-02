namespace Tyuiu.GoryaevTT.Sprint6.Task7.V19
{
    partial class AboutGTT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutGTT));
            tableLayoutPanel = new TableLayoutPanel();
            buttonClose = new Button();
            pictureBox1 = new PictureBox();
            textAuthor_GTT = new TextBox();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 438F));
            tableLayoutPanel.Controls.Add(buttonClose, 1, 1);
            tableLayoutPanel.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel.Controls.Add(textAuthor_GTT, 1, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(18, 21);
            tableLayoutPanel.Margin = new Padding(6, 7, 6, 7);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableLayoutPanel.Size = new Size(834, 611);
            tableLayoutPanel.TabIndex = 0;
            tableLayoutPanel.Paint += tableLayoutPanel_Paint;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonClose.Location = new Point(399, 553);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(432, 55);
            buttonClose.TabIndex = 0;
            buttonClose.Text = "OK";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += Close;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(390, 544);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textAuthor_GTT
            // 
            textAuthor_GTT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textAuthor_GTT.Location = new Point(399, 3);
            textAuthor_GTT.Multiline = true;
            textAuthor_GTT.Name = "textAuthor_GTT";
            textAuthor_GTT.Size = new Size(432, 544);
            textAuthor_GTT.TabIndex = 2;
            textAuthor_GTT.Text = "Автор таска: Тагир Горяев группа ПИНб-25-1.";
            // 
            // AboutGTT
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 653);
            Controls.Add(tableLayoutPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(6, 7, 6, 7);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutGTT";
            Padding = new Padding(18, 21, 18, 21);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "AboutGTT";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private Button buttonClose;
        private PictureBox pictureBox1;
        private TextBox textAuthor_GTT;
    }
}
