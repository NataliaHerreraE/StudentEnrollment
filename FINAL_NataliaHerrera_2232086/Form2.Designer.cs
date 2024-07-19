namespace FINAL_NataliaHerrera_2232086
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_midterm = new System.Windows.Forms.Label();
            this.txtMidterm = new System.Windows.Forms.TextBox();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.label_Project = new System.Windows.Forms.Label();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.label_Final = new System.Windows.Forms.Label();
            this.txtGradeMidterm = new System.Windows.Forms.TextBox();
            this.label_gradeMid = new System.Windows.Forms.Label();
            this.txtGradeProject = new System.Windows.Forms.TextBox();
            this.label_gradeProject = new System.Windows.Forms.Label();
            this.txtGradeFinal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFinalGrade = new System.Windows.Forms.TextBox();
            this.label_total = new System.Windows.Forms.Label();
            this.txtGradeLetter = new System.Windows.Forms.TextBox();
            this.label_gradeNumber = new System.Windows.Forms.Label();
            this.label_PerMidterm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnWriteTxt = new System.Windows.Forms.Button();
            this.btnWriteXml = new System.Windows.Forms.Button();
            this.btnReadXml = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_midterm
            // 
            this.label_midterm.AutoSize = true;
            this.label_midterm.Location = new System.Drawing.Point(29, 46);
            this.label_midterm.Name = "label_midterm";
            this.label_midterm.Size = new System.Drawing.Size(73, 13);
            this.label_midterm.TabIndex = 0;
            this.label_midterm.Text = "Midterm Exam";
            // 
            // txtMidterm
            // 
            this.txtMidterm.Location = new System.Drawing.Point(126, 42);
            this.txtMidterm.Name = "txtMidterm";
            this.txtMidterm.Size = new System.Drawing.Size(100, 20);
            this.txtMidterm.TabIndex = 1;
            this.txtMidterm.Text = "0";
            this.txtMidterm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProject
            // 
            this.txtProject.Location = new System.Drawing.Point(126, 84);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(100, 20);
            this.txtProject.TabIndex = 3;
            this.txtProject.Text = "0";
            this.txtProject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Project
            // 
            this.label_Project.AutoSize = true;
            this.label_Project.Location = new System.Drawing.Point(29, 88);
            this.label_Project.Name = "label_Project";
            this.label_Project.Size = new System.Drawing.Size(40, 13);
            this.label_Project.TabIndex = 2;
            this.label_Project.Text = "Project";
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(126, 130);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(100, 20);
            this.txtFinal.TabIndex = 5;
            this.txtFinal.Text = "0";
            this.txtFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Final
            // 
            this.label_Final.AutoSize = true;
            this.label_Final.Location = new System.Drawing.Point(29, 134);
            this.label_Final.Name = "label_Final";
            this.label_Final.Size = new System.Drawing.Size(29, 13);
            this.label_Final.TabIndex = 4;
            this.label_Final.Text = "Final";
            // 
            // txtGradeMidterm
            // 
            this.txtGradeMidterm.Location = new System.Drawing.Point(361, 42);
            this.txtGradeMidterm.Name = "txtGradeMidterm";
            this.txtGradeMidterm.ReadOnly = true;
            this.txtGradeMidterm.Size = new System.Drawing.Size(100, 20);
            this.txtGradeMidterm.TabIndex = 7;
            this.txtGradeMidterm.Text = "0";
            this.txtGradeMidterm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGradeMidterm.TextChanged += new System.EventHandler(this.textGradeMid_TextChanged);
            // 
            // label_gradeMid
            // 
            this.label_gradeMid.AutoSize = true;
            this.label_gradeMid.Location = new System.Drawing.Point(264, 46);
            this.label_gradeMid.Name = "label_gradeMid";
            this.label_gradeMid.Size = new System.Drawing.Size(82, 13);
            this.label_gradeMid.TabIndex = 6;
            this.label_gradeMid.Text = "(grade 0 to 100)";
            // 
            // txtGradeProject
            // 
            this.txtGradeProject.Location = new System.Drawing.Point(361, 85);
            this.txtGradeProject.Name = "txtGradeProject";
            this.txtGradeProject.ReadOnly = true;
            this.txtGradeProject.Size = new System.Drawing.Size(100, 20);
            this.txtGradeProject.TabIndex = 9;
            this.txtGradeProject.Text = "0";
            this.txtGradeProject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGradeProject.TextChanged += new System.EventHandler(this.txtGradeProject_TextChanged);
            // 
            // label_gradeProject
            // 
            this.label_gradeProject.AutoSize = true;
            this.label_gradeProject.Location = new System.Drawing.Point(264, 89);
            this.label_gradeProject.Name = "label_gradeProject";
            this.label_gradeProject.Size = new System.Drawing.Size(82, 13);
            this.label_gradeProject.TabIndex = 8;
            this.label_gradeProject.Text = "(grade 0 to 100)";
            // 
            // txtGradeFinal
            // 
            this.txtGradeFinal.Location = new System.Drawing.Point(361, 131);
            this.txtGradeFinal.Name = "txtGradeFinal";
            this.txtGradeFinal.ReadOnly = true;
            this.txtGradeFinal.Size = new System.Drawing.Size(100, 20);
            this.txtGradeFinal.TabIndex = 11;
            this.txtGradeFinal.Text = "0";
            this.txtGradeFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGradeFinal.TextChanged += new System.EventHandler(this.txtGradeFinal_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "(grade 0 to 100)";
            // 
            // txtFinalGrade
            // 
            this.txtFinalGrade.Location = new System.Drawing.Point(361, 180);
            this.txtFinalGrade.Name = "txtFinalGrade";
            this.txtFinalGrade.ReadOnly = true;
            this.txtFinalGrade.Size = new System.Drawing.Size(100, 20);
            this.txtFinalGrade.TabIndex = 13;
            this.txtFinalGrade.Text = "0";
            this.txtFinalGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFinalGrade.TextChanged += new System.EventHandler(this.txtFinalGrade_TextChanged);
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Location = new System.Drawing.Point(264, 184);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(34, 13);
            this.label_total.TabIndex = 12;
            this.label_total.Text = "Total:";
            // 
            // txtGradeLetter
            // 
            this.txtGradeLetter.Location = new System.Drawing.Point(361, 217);
            this.txtGradeLetter.Name = "txtGradeLetter";
            this.txtGradeLetter.ReadOnly = true;
            this.txtGradeLetter.Size = new System.Drawing.Size(100, 20);
            this.txtGradeLetter.TabIndex = 15;
            this.txtGradeLetter.Text = "F";
            this.txtGradeLetter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGradeLetter.TextChanged += new System.EventHandler(this.txtGradeLetter_TextChanged);
            // 
            // label_gradeNumber
            // 
            this.label_gradeNumber.AutoSize = true;
            this.label_gradeNumber.Location = new System.Drawing.Point(264, 221);
            this.label_gradeNumber.Name = "label_gradeNumber";
            this.label_gradeNumber.Size = new System.Drawing.Size(82, 13);
            this.label_gradeNumber.TabIndex = 14;
            this.label_gradeNumber.Text = "(grade 0 to 100)";
            // 
            // label_PerMidterm
            // 
            this.label_PerMidterm.AutoSize = true;
            this.label_PerMidterm.Location = new System.Drawing.Point(481, 46);
            this.label_PerMidterm.Name = "label_PerMidterm";
            this.label_PerMidterm.Size = new System.Drawing.Size(54, 13);
            this.label_PerMidterm.TabIndex = 16;
            this.label_PerMidterm.Text = "(0 to 30%)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "(0 to 30%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "(0 to 40%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "(60-100 to pass)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(481, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "A, B, C, D or F";
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(32, 278);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(116, 53);
            this.btnValidate.TabIndex = 21;
            this.btnValidate.Text = "&Validate-Calculate\r\nData";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnWriteTxt
            // 
            this.btnWriteTxt.Location = new System.Drawing.Point(170, 278);
            this.btnWriteTxt.Name = "btnWriteTxt";
            this.btnWriteTxt.Size = new System.Drawing.Size(116, 53);
            this.btnWriteTxt.TabIndex = 22;
            this.btnWriteTxt.Text = "&Write / Add \r\nstudent\r\ndata into Final.txt";
            this.btnWriteTxt.UseVisualStyleBackColor = true;
            this.btnWriteTxt.Click += new System.EventHandler(this.btnWriteTxt_Click);
            // 
            // btnWriteXml
            // 
            this.btnWriteXml.Location = new System.Drawing.Point(308, 278);
            this.btnWriteXml.Name = "btnWriteXml";
            this.btnWriteXml.Size = new System.Drawing.Size(116, 53);
            this.btnWriteXml.TabIndex = 23;
            this.btnWriteXml.Text = "&Create / Write Xml\r\nFinal.xml file from\r\ntxt file";
            this.btnWriteXml.UseVisualStyleBackColor = true;
            this.btnWriteXml.Click += new System.EventHandler(this.btnWriteXml_Click);
            // 
            // btnReadXml
            // 
            this.btnReadXml.Location = new System.Drawing.Point(446, 278);
            this.btnReadXml.Name = "btnReadXml";
            this.btnReadXml.Size = new System.Drawing.Size(116, 53);
            this.btnReadXml.TabIndex = 24;
            this.btnReadXml.Text = "&Read Xml\r\nFinal.xml\r\nfile and display";
            this.btnReadXml.UseVisualStyleBackColor = true;
            this.btnReadXml.Click += new System.EventHandler(this.btnReadXml_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(126, 356);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "R&eset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(398, 356);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(594, 391);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnReadXml);
            this.Controls.Add(this.btnWriteXml);
            this.Controls.Add(this.btnWriteTxt);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_PerMidterm);
            this.Controls.Add(this.txtGradeLetter);
            this.Controls.Add(this.label_gradeNumber);
            this.Controls.Add(this.txtFinalGrade);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.txtGradeFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGradeProject);
            this.Controls.Add(this.label_gradeProject);
            this.Controls.Add(this.txtGradeMidterm);
            this.Controls.Add(this.label_gradeMid);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.label_Final);
            this.Controls.Add(this.txtProject);
            this.Controls.Add(this.label_Project);
            this.Controls.Add(this.txtMidterm);
            this.Controls.Add(this.label_midterm);
            this.Name = "Form2";
            this.Text = "Natalia Andrea Herrea Espinosa - 2232086 - 2023/12/18";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_midterm;
        private System.Windows.Forms.TextBox txtMidterm;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.Label label_Project;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Label label_Final;
        private System.Windows.Forms.TextBox txtGradeMidterm;
        private System.Windows.Forms.Label label_gradeMid;
        private System.Windows.Forms.TextBox txtGradeProject;
        private System.Windows.Forms.Label label_gradeProject;
        private System.Windows.Forms.TextBox txtGradeFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFinalGrade;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.TextBox txtGradeLetter;
        private System.Windows.Forms.Label label_gradeNumber;
        private System.Windows.Forms.Label label_PerMidterm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnWriteTxt;
        private System.Windows.Forms.Button btnWriteXml;
        private System.Windows.Forms.Button btnReadXml;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}