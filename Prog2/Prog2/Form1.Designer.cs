namespace Prog2
{
    partial class taxIncome
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
            this.enterTaxableIncome = new System.Windows.Forms.Label();
            this.Income = new System.Windows.Forms.TextBox();
            this.baselineButton = new System.Windows.Forms.RadioButton();
            this.candidate1Button = new System.Windows.Forms.RadioButton();
            this.candidate2Button = new System.Windows.Forms.RadioButton();
            this.candidate3Button = new System.Windows.Forms.RadioButton();
            this.calculateButton = new System.Windows.Forms.Button();
            this.marginalRa = new System.Windows.Forms.Label();
            this.marginalR = new System.Windows.Forms.Label();
            this.amountOfTax = new System.Windows.Forms.Label();
            this.Tax = new System.Windows.Forms.Label();
            this.currentPlan = new System.Windows.Forms.Label();
            this.Plan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterTaxableIncome
            // 
            this.enterTaxableIncome.AutoSize = true;
            this.enterTaxableIncome.Location = new System.Drawing.Point(12, 29);
            this.enterTaxableIncome.Name = "enterTaxableIncome";
            this.enterTaxableIncome.Size = new System.Drawing.Size(227, 25);
            this.enterTaxableIncome.TabIndex = 0;
            this.enterTaxableIncome.Text = "Enter Taxable Income:";
            // 
            // Income
            // 
            this.Income.Location = new System.Drawing.Point(245, 29);
            this.Income.Name = "Income";
            this.Income.Size = new System.Drawing.Size(158, 31);
            this.Income.TabIndex = 1;
            // 
            // baselineButton
            // 
            this.baselineButton.AutoSize = true;
            this.baselineButton.Location = new System.Drawing.Point(641, 29);
            this.baselineButton.Name = "baselineButton";
            this.baselineButton.Size = new System.Drawing.Size(126, 29);
            this.baselineButton.TabIndex = 2;
            this.baselineButton.TabStop = true;
            this.baselineButton.Text = "Baseline";
            this.baselineButton.UseVisualStyleBackColor = true;
            // 
            // candidate1Button
            // 
            this.candidate1Button.AutoSize = true;
            this.candidate1Button.Location = new System.Drawing.Point(641, 64);
            this.candidate1Button.Name = "candidate1Button";
            this.candidate1Button.Size = new System.Drawing.Size(159, 29);
            this.candidate1Button.TabIndex = 3;
            this.candidate1Button.TabStop = true;
            this.candidate1Button.Text = "Candidate 1";
            this.candidate1Button.UseVisualStyleBackColor = true;
            // 
            // candidate2Button
            // 
            this.candidate2Button.AutoSize = true;
            this.candidate2Button.Location = new System.Drawing.Point(641, 99);
            this.candidate2Button.Name = "candidate2Button";
            this.candidate2Button.Size = new System.Drawing.Size(159, 29);
            this.candidate2Button.TabIndex = 4;
            this.candidate2Button.TabStop = true;
            this.candidate2Button.Text = "Candidate 2";
            this.candidate2Button.UseVisualStyleBackColor = true;
            // 
            // candidate3Button
            // 
            this.candidate3Button.AutoSize = true;
            this.candidate3Button.Location = new System.Drawing.Point(641, 135);
            this.candidate3Button.Name = "candidate3Button";
            this.candidate3Button.Size = new System.Drawing.Size(159, 29);
            this.candidate3Button.TabIndex = 5;
            this.candidate3Button.TabStop = true;
            this.candidate3Button.Text = "Candidate 3";
            this.candidate3Button.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 70);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(576, 94);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate Taxable Income";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // marginalRa
            // 
            this.marginalRa.AutoSize = true;
            this.marginalRa.Location = new System.Drawing.Point(12, 262);
            this.marginalRa.Name = "marginalRa";
            this.marginalRa.Size = new System.Drawing.Size(246, 25);
            this.marginalRa.TabIndex = 7;
            this.marginalRa.Text = "Your Marginal Tax Rate:";
            // 
            // marginalR
            // 
            this.marginalR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.marginalR.Location = new System.Drawing.Point(264, 261);
            this.marginalR.Name = "marginalR";
            this.marginalR.Size = new System.Drawing.Size(180, 37);
            this.marginalR.TabIndex = 8;
            // 
            // amountOfTax
            // 
            this.amountOfTax.AutoSize = true;
            this.amountOfTax.Location = new System.Drawing.Point(51, 340);
            this.amountOfTax.Name = "amountOfTax";
            this.amountOfTax.Size = new System.Drawing.Size(207, 25);
            this.amountOfTax.TabIndex = 9;
            this.amountOfTax.Text = "Your amount of Tax:";
            // 
            // Tax
            // 
            this.Tax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tax.Location = new System.Drawing.Point(264, 339);
            this.Tax.Name = "Tax";
            this.Tax.Size = new System.Drawing.Size(180, 37);
            this.Tax.TabIndex = 10;
            // 
            // currentPlan
            // 
            this.currentPlan.AutoSize = true;
            this.currentPlan.Location = new System.Drawing.Point(539, 304);
            this.currentPlan.Name = "currentPlan";
            this.currentPlan.Size = new System.Drawing.Size(138, 25);
            this.currentPlan.TabIndex = 11;
            this.currentPlan.Text = "Current Plan:";
            // 
            // Plan
            // 
            this.Plan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Plan.Location = new System.Drawing.Point(683, 303);
            this.Plan.Name = "Plan";
            this.Plan.Size = new System.Drawing.Size(180, 37);
            this.Plan.TabIndex = 12;
            // 
            // taxIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 416);
            this.Controls.Add(this.Plan);
            this.Controls.Add(this.currentPlan);
            this.Controls.Add(this.Tax);
            this.Controls.Add(this.amountOfTax);
            this.Controls.Add(this.marginalR);
            this.Controls.Add(this.marginalRa);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.candidate3Button);
            this.Controls.Add(this.candidate2Button);
            this.Controls.Add(this.candidate1Button);
            this.Controls.Add(this.baselineButton);
            this.Controls.Add(this.Income);
            this.Controls.Add(this.enterTaxableIncome);
            this.Name = "taxIncome";
            this.Text = "Taxable Income";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterTaxableIncome;
        private System.Windows.Forms.TextBox Income;
        private System.Windows.Forms.RadioButton baselineButton;
        private System.Windows.Forms.RadioButton candidate1Button;
        private System.Windows.Forms.RadioButton candidate2Button;
        private System.Windows.Forms.RadioButton candidate3Button;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label marginalRa;
        private System.Windows.Forms.Label marginalR;
        private System.Windows.Forms.Label amountOfTax;
        private System.Windows.Forms.Label Tax;
        private System.Windows.Forms.Label currentPlan;
        private System.Windows.Forms.Label Plan;
    }
}

