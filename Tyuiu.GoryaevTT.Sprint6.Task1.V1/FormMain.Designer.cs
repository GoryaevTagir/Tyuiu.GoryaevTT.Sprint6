namespace Tyuiu.GoryaevTT.Sprint6.Task1.V1
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
            groupResult_GTT = new GroupBox();
            getResult_GTT = new Button();
            Info_GTT = new Button();
            Result_GTT = new TextBox();
            groupData_GTT = new GroupBox();
            DataX2_GTT = new TextBox();
            DataX1_GTT = new TextBox();
            groupTask_GTT = new GroupBox();
            Task_GTT = new TextBox();
            groupResult_GTT.SuspendLayout();
            groupData_GTT.SuspendLayout();
            groupTask_GTT.SuspendLayout();
            SuspendLayout();
            // 
            // groupResult_GTT
            // 
            groupResult_GTT.Controls.Add(getResult_GTT);
            groupResult_GTT.Controls.Add(Info_GTT);
            groupResult_GTT.Controls.Add(Result_GTT);
            resources.ApplyResources(groupResult_GTT, "groupResult_GTT");
            groupResult_GTT.Name = "groupResult_GTT";
            groupResult_GTT.TabStop = false;
            // 
            // getResult_GTT
            // 
            resources.ApplyResources(getResult_GTT, "getResult_GTT");
            getResult_GTT.Name = "getResult_GTT";
            getResult_GTT.UseVisualStyleBackColor = true;
            getResult_GTT.Click += getResult;
            // 
            // Info_GTT
            // 
            resources.ApplyResources(Info_GTT, "Info_GTT");
            Info_GTT.Name = "Info_GTT";
            Info_GTT.UseVisualStyleBackColor = true;
            Info_GTT.Click += getHelp;
            // 
            // Result_GTT
            // 
            resources.ApplyResources(Result_GTT, "Result_GTT");
            Result_GTT.Name = "Result_GTT";
            Result_GTT.ReadOnly = true;
            // 
            // groupData_GTT
            // 
            groupData_GTT.Controls.Add(DataX2_GTT);
            groupData_GTT.Controls.Add(DataX1_GTT);
            resources.ApplyResources(groupData_GTT, "groupData_GTT");
            groupData_GTT.Name = "groupData_GTT";
            groupData_GTT.TabStop = false;
            // 
            // DataX2_GTT
            // 
            resources.ApplyResources(DataX2_GTT, "DataX2_GTT");
            DataX2_GTT.Name = "DataX2_GTT";
            // 
            // DataX1_GTT
            // 
            resources.ApplyResources(DataX1_GTT, "DataX1_GTT");
            DataX1_GTT.Name = "DataX1_GTT";
            // 
            // groupTask_GTT
            // 
            groupTask_GTT.Controls.Add(Task_GTT);
            resources.ApplyResources(groupTask_GTT, "groupTask_GTT");
            groupTask_GTT.Name = "groupTask_GTT";
            groupTask_GTT.TabStop = false;
            // 
            // Task_GTT
            // 
            resources.ApplyResources(Task_GTT, "Task_GTT");
            Task_GTT.Name = "Task_GTT";
            Task_GTT.ReadOnly = true;
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupTask_GTT);
            Controls.Add(groupData_GTT);
            Controls.Add(groupResult_GTT);
            MaximizeBox = false;
            Name = "FormMain";
            groupResult_GTT.ResumeLayout(false);
            groupResult_GTT.PerformLayout();
            groupData_GTT.ResumeLayout(false);
            groupData_GTT.PerformLayout();
            groupTask_GTT.ResumeLayout(false);
            groupTask_GTT.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupResult_GTT;
        private GroupBox groupData_GTT;
        private GroupBox groupTask_GTT;
        private TextBox DataX1_GTT;
        private TextBox Result_GTT;
        private TextBox Task_GTT;
        private TextBox DataX2_GTT;
        private Button getResult_GTT;
        private Button Info_GTT;
    }
}
