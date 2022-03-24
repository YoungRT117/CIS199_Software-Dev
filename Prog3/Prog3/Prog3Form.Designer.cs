namespace Prog3
{
    partial class Prog3Form
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.incomeLbl = new System.Windows.Forms.Label();
            this.incomeTxt = new System.Windows.Forms.TextBox();
            this.filingBox = new System.Windows.Forms.GroupBox();
            this.candidate3RdoBtn = new System.Windows.Forms.RadioButton();
            this.candidate2RdoBtn = new System.Windows.Forms.RadioButton();
            this.candidate1RdoBtn = new System.Windows.Forms.RadioButton();
            this.baselineRdoBtn = new System.Windows.Forms.RadioButton();
            this.calcTaxBtn = new System.Windows.Forms.Button();
            this.marginalRateLbl = new System.Windows.Forms.Label();
            this.marginalRateOutLbl = new System.Windows.Forms.Label();
            this.taxOutLbl = new System.Windows.Forms.Label();
            this.taxLbl = new System.Windows.Forms.Label();
            this.filingBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(72, 17);
            this.titleLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(360, 25);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "2020 Candidate Tax Rate Caclulator";
            // 
            // incomeLbl
            // 
            this.incomeLbl.AutoSize = true;
            this.incomeLbl.Location = new System.Drawing.Point(30, 69);
            this.incomeLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.incomeLbl.Name = "incomeLbl";
            this.incomeLbl.Size = new System.Drawing.Size(227, 25);
            this.incomeLbl.TabIndex = 1;
            this.incomeLbl.Text = "Enter Taxable Income:";
            // 
            // incomeTxt
            // 
            this.incomeTxt.Location = new System.Drawing.Point(270, 63);
            this.incomeTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.incomeTxt.Name = "incomeTxt";
            this.incomeTxt.Size = new System.Drawing.Size(196, 31);
            this.incomeTxt.TabIndex = 2;
            // 
            // filingBox
            // 
            this.filingBox.Controls.Add(this.candidate3RdoBtn);
            this.filingBox.Controls.Add(this.candidate2RdoBtn);
            this.filingBox.Controls.Add(this.candidate1RdoBtn);
            this.filingBox.Controls.Add(this.baselineRdoBtn);
            this.filingBox.Location = new System.Drawing.Point(36, 125);
            this.filingBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.filingBox.Name = "filingBox";
            this.filingBox.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.filingBox.Size = new System.Drawing.Size(434, 238);
            this.filingBox.TabIndex = 3;
            this.filingBox.TabStop = false;
            this.filingBox.Text = "Candidate?";
            // 
            // candidate3RdoBtn
            // 
            this.candidate3RdoBtn.AutoSize = true;
            this.candidate3RdoBtn.Enabled = false;
            this.candidate3RdoBtn.Location = new System.Drawing.Point(12, 171);
            this.candidate3RdoBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.candidate3RdoBtn.Name = "candidate3RdoBtn";
            this.candidate3RdoBtn.Size = new System.Drawing.Size(159, 29);
            this.candidate3RdoBtn.TabIndex = 4;
            this.candidate3RdoBtn.Text = "Candidate 3";
            this.candidate3RdoBtn.UseVisualStyleBackColor = true;
            // 
            // candidate2RdoBtn
            // 
            this.candidate2RdoBtn.AutoSize = true;
            this.candidate2RdoBtn.Location = new System.Drawing.Point(12, 127);
            this.candidate2RdoBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.candidate2RdoBtn.Name = "candidate2RdoBtn";
            this.candidate2RdoBtn.Size = new System.Drawing.Size(159, 29);
            this.candidate2RdoBtn.TabIndex = 2;
            this.candidate2RdoBtn.Text = "Candidate 2";
            this.candidate2RdoBtn.UseVisualStyleBackColor = true;
            // 
            // candidate1RdoBtn
            // 
            this.candidate1RdoBtn.AutoSize = true;
            this.candidate1RdoBtn.Enabled = false;
            this.candidate1RdoBtn.Location = new System.Drawing.Point(14, 83);
            this.candidate1RdoBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.candidate1RdoBtn.Name = "candidate1RdoBtn";
            this.candidate1RdoBtn.Size = new System.Drawing.Size(159, 29);
            this.candidate1RdoBtn.TabIndex = 1;
            this.candidate1RdoBtn.Text = "Candidate 1";
            this.candidate1RdoBtn.UseVisualStyleBackColor = true;
            // 
            // baselineRdoBtn
            // 
            this.baselineRdoBtn.AutoSize = true;
            this.baselineRdoBtn.Checked = true;
            this.baselineRdoBtn.Location = new System.Drawing.Point(14, 38);
            this.baselineRdoBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.baselineRdoBtn.Name = "baselineRdoBtn";
            this.baselineRdoBtn.Size = new System.Drawing.Size(126, 29);
            this.baselineRdoBtn.TabIndex = 0;
            this.baselineRdoBtn.TabStop = true;
            this.baselineRdoBtn.Text = "Baseline";
            this.baselineRdoBtn.UseVisualStyleBackColor = true;
            // 
            // calcTaxBtn
            // 
            this.calcTaxBtn.Location = new System.Drawing.Point(174, 401);
            this.calcTaxBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.calcTaxBtn.Name = "calcTaxBtn";
            this.calcTaxBtn.Size = new System.Drawing.Size(166, 46);
            this.calcTaxBtn.TabIndex = 4;
            this.calcTaxBtn.Text = "Calculate Tax";
            this.calcTaxBtn.UseVisualStyleBackColor = true;
            this.calcTaxBtn.Click += new System.EventHandler(this.calcTaxBtn_Click);
            // 
            // marginalRateLbl
            // 
            this.marginalRateLbl.AutoSize = true;
            this.marginalRateLbl.Location = new System.Drawing.Point(64, 467);
            this.marginalRateLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.marginalRateLbl.Name = "marginalRateLbl";
            this.marginalRateLbl.Size = new System.Drawing.Size(194, 25);
            this.marginalRateLbl.TabIndex = 5;
            this.marginalRateLbl.Text = "Marginal Tax Rate:";
            // 
            // marginalRateOutLbl
            // 
            this.marginalRateOutLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.marginalRateOutLbl.Location = new System.Drawing.Point(270, 465);
            this.marginalRateOutLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.marginalRateOutLbl.Name = "marginalRateOutLbl";
            this.marginalRateOutLbl.Size = new System.Drawing.Size(198, 37);
            this.marginalRateOutLbl.TabIndex = 6;
            // 
            // taxOutLbl
            // 
            this.taxOutLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxOutLbl.Location = new System.Drawing.Point(270, 525);
            this.taxOutLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.taxOutLbl.Name = "taxOutLbl";
            this.taxOutLbl.Size = new System.Drawing.Size(198, 37);
            this.taxOutLbl.TabIndex = 8;
            this.taxOutLbl.Text = "--------------";
            this.taxOutLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxLbl
            // 
            this.taxLbl.AutoSize = true;
            this.taxLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLbl.Location = new System.Drawing.Point(126, 527);
            this.taxLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.taxLbl.Name = "taxLbl";
            this.taxLbl.Size = new System.Drawing.Size(131, 26);
            this.taxLbl.TabIndex = 7;
            this.taxLbl.Text = "Income Tax:";
            // 
            // Prog3Form
            // 
            this.AcceptButton = this.calcTaxBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 588);
            this.Controls.Add(this.taxOutLbl);
            this.Controls.Add(this.taxLbl);
            this.Controls.Add(this.marginalRateOutLbl);
            this.Controls.Add(this.marginalRateLbl);
            this.Controls.Add(this.calcTaxBtn);
            this.Controls.Add(this.filingBox);
            this.Controls.Add(this.incomeTxt);
            this.Controls.Add(this.incomeLbl);
            this.Controls.Add(this.titleLbl);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Prog3Form";
            this.Text = "Program 3";
            this.filingBox.ResumeLayout(false);
            this.filingBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label incomeLbl;
        private System.Windows.Forms.TextBox incomeTxt;
        private System.Windows.Forms.GroupBox filingBox;
        private System.Windows.Forms.RadioButton candidate3RdoBtn;
        private System.Windows.Forms.RadioButton candidate2RdoBtn;
        private System.Windows.Forms.RadioButton candidate1RdoBtn;
        private System.Windows.Forms.RadioButton baselineRdoBtn;
        private System.Windows.Forms.Button calcTaxBtn;
        private System.Windows.Forms.Label marginalRateLbl;
        private System.Windows.Forms.Label marginalRateOutLbl;
        private System.Windows.Forms.Label taxOutLbl;
        private System.Windows.Forms.Label taxLbl;
    }
}

