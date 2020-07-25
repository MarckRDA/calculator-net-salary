namespace NetSalaryReajust
{
    partial class frmNetSalaryReajust
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMinimumWage = new System.Windows.Forms.TextBox();
            this.txtWorkedHours = new System.Windows.Forms.TextBox();
            this.gbWorkShift = new System.Windows.Forms.GroupBox();
            this.gbCategory = new System.Windows.Forms.GroupBox();
            this.lstInfo = new System.Windows.Forms.ListBox();
            this.txtBCategory = new System.Windows.Forms.TextBox();
            this.bttCalculate = new System.Windows.Forms.Button();
            this.rbnFreshman = new System.Windows.Forms.RadioButton();
            this.rbnVeteran = new System.Windows.Forms.RadioButton();
            this.rbnMorning = new System.Windows.Forms.RadioButton();
            this.rbnEvening = new System.Windows.Forms.RadioButton();
            this.rbnNocturnal = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbWorkShift.SuspendLayout();
            this.gbCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minimum Wage :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Worked hours :";
            // 
            // txtMinimumWage
            // 
            this.txtMinimumWage.Location = new System.Drawing.Point(105, 28);
            this.txtMinimumWage.Name = "txtMinimumWage";
            this.txtMinimumWage.Size = new System.Drawing.Size(100, 20);
            this.txtMinimumWage.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtMinimumWage, "Insert the current salary value");
            // 
            // txtWorkedHours
            // 
            this.txtWorkedHours.Location = new System.Drawing.Point(105, 57);
            this.txtWorkedHours.Name = "txtWorkedHours";
            this.txtWorkedHours.Size = new System.Drawing.Size(100, 20);
            this.txtWorkedHours.TabIndex = 3;
            // 
            // gbWorkShift
            // 
            this.gbWorkShift.Controls.Add(this.rbnNocturnal);
            this.gbWorkShift.Controls.Add(this.rbnEvening);
            this.gbWorkShift.Controls.Add(this.rbnMorning);
            this.gbWorkShift.Location = new System.Drawing.Point(269, 28);
            this.gbWorkShift.Name = "gbWorkShift";
            this.gbWorkShift.Size = new System.Drawing.Size(137, 124);
            this.gbWorkShift.TabIndex = 4;
            this.gbWorkShift.TabStop = false;
            this.gbWorkShift.Text = "Work shift";
            // 
            // gbCategory
            // 
            this.gbCategory.Controls.Add(this.rbnVeteran);
            this.gbCategory.Controls.Add(this.rbnFreshman);
            this.gbCategory.Location = new System.Drawing.Point(12, 95);
            this.gbCategory.Name = "gbCategory";
            this.gbCategory.Size = new System.Drawing.Size(200, 57);
            this.gbCategory.TabIndex = 5;
            this.gbCategory.TabStop = false;
            this.gbCategory.Text = "Category : ";
            // 
            // lstInfo
            // 
            this.lstInfo.FormattingEnabled = true;
            this.lstInfo.Location = new System.Drawing.Point(12, 158);
            this.lstInfo.MultiColumn = true;
            this.lstInfo.Name = "lstInfo";
            this.lstInfo.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstInfo.Size = new System.Drawing.Size(394, 173);
            this.lstInfo.TabIndex = 6;
            // 
            // txtBCategory
            // 
            this.txtBCategory.Location = new System.Drawing.Point(12, 347);
            this.txtBCategory.Name = "txtBCategory";
            this.txtBCategory.Size = new System.Drawing.Size(296, 20);
            this.txtBCategory.TabIndex = 7;
            // 
            // bttCalculate
            // 
            this.bttCalculate.Location = new System.Drawing.Point(323, 345);
            this.bttCalculate.Name = "bttCalculate";
            this.bttCalculate.Size = new System.Drawing.Size(83, 23);
            this.bttCalculate.TabIndex = 8;
            this.bttCalculate.Text = "Calculate";
            this.bttCalculate.UseVisualStyleBackColor = true;
            this.bttCalculate.Click += new System.EventHandler(this.bttCalculate_Click);
            // 
            // rbnFreshman
            // 
            this.rbnFreshman.AutoSize = true;
            this.rbnFreshman.Location = new System.Drawing.Point(7, 31);
            this.rbnFreshman.Name = "rbnFreshman";
            this.rbnFreshman.Size = new System.Drawing.Size(71, 17);
            this.rbnFreshman.TabIndex = 0;
            this.rbnFreshman.TabStop = true;
            this.rbnFreshman.Text = "Freshman";
            this.rbnFreshman.UseVisualStyleBackColor = true;
            // 
            // rbnVeteran
            // 
            this.rbnVeteran.AutoSize = true;
            this.rbnVeteran.Location = new System.Drawing.Point(99, 31);
            this.rbnVeteran.Name = "rbnVeteran";
            this.rbnVeteran.Size = new System.Drawing.Size(62, 17);
            this.rbnVeteran.TabIndex = 1;
            this.rbnVeteran.TabStop = true;
            this.rbnVeteran.Text = "Veteran";
            this.rbnVeteran.UseVisualStyleBackColor = true;
            // 
            // rbnMorning
            // 
            this.rbnMorning.AutoSize = true;
            this.rbnMorning.Location = new System.Drawing.Point(6, 32);
            this.rbnMorning.Name = "rbnMorning";
            this.rbnMorning.Size = new System.Drawing.Size(63, 17);
            this.rbnMorning.TabIndex = 0;
            this.rbnMorning.TabStop = true;
            this.rbnMorning.Text = "Morning";
            this.rbnMorning.UseVisualStyleBackColor = true;
            // 
            // rbnEvening
            // 
            this.rbnEvening.AutoSize = true;
            this.rbnEvening.Location = new System.Drawing.Point(6, 67);
            this.rbnEvening.Name = "rbnEvening";
            this.rbnEvening.Size = new System.Drawing.Size(64, 17);
            this.rbnEvening.TabIndex = 1;
            this.rbnEvening.TabStop = true;
            this.rbnEvening.Text = "Evening";
            this.rbnEvening.UseVisualStyleBackColor = true;
            // 
            // rbnNocturnal
            // 
            this.rbnNocturnal.AutoSize = true;
            this.rbnNocturnal.Location = new System.Drawing.Point(6, 98);
            this.rbnNocturnal.Name = "rbnNocturnal";
            this.rbnNocturnal.Size = new System.Drawing.Size(71, 17);
            this.rbnNocturnal.TabIndex = 2;
            this.rbnNocturnal.TabStop = true;
            this.rbnNocturnal.Text = "Nocturnal";
            this.rbnNocturnal.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Hint";
            // 
            // frmNetSalaryReajust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 379);
            this.Controls.Add(this.bttCalculate);
            this.Controls.Add(this.txtBCategory);
            this.Controls.Add(this.lstInfo);
            this.Controls.Add(this.gbCategory);
            this.Controls.Add(this.gbWorkShift);
            this.Controls.Add(this.txtWorkedHours);
            this.Controls.Add(this.txtMinimumWage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmNetSalaryReajust";
            this.Text = "Net Salary Reajust";
            this.gbWorkShift.ResumeLayout(false);
            this.gbWorkShift.PerformLayout();
            this.gbCategory.ResumeLayout(false);
            this.gbCategory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMinimumWage;
        private System.Windows.Forms.TextBox txtWorkedHours;
        private System.Windows.Forms.GroupBox gbWorkShift;
        private System.Windows.Forms.RadioButton rbnNocturnal;
        private System.Windows.Forms.RadioButton rbnEvening;
        private System.Windows.Forms.RadioButton rbnMorning;
        private System.Windows.Forms.GroupBox gbCategory;
        private System.Windows.Forms.RadioButton rbnVeteran;
        private System.Windows.Forms.RadioButton rbnFreshman;
        private System.Windows.Forms.ListBox lstInfo;
        private System.Windows.Forms.TextBox txtBCategory;
        private System.Windows.Forms.Button bttCalculate;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

