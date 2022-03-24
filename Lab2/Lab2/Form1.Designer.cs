namespace Lab_2
{
    partial class Lab2
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
            this.PriceOfMeal = new System.Windows.Forms.Label();
            this.Tax15 = new System.Windows.Forms.Label();
            this.Tax18 = new System.Windows.Forms.Label();
            this.Tax20 = new System.Windows.Forms.Label();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.CalculateTip = new System.Windows.Forms.Button();
            this.taxes15 = new System.Windows.Forms.Label();
            this.taxes18 = new System.Windows.Forms.Label();
            this.taxes20 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PriceOfMeal
            // 
            this.PriceOfMeal.AutoSize = true;
            this.PriceOfMeal.Location = new System.Drawing.Point(158, 109);
            this.PriceOfMeal.Name = "PriceOfMeal";
            this.PriceOfMeal.Size = new System.Drawing.Size(198, 25);
            this.PriceOfMeal.TabIndex = 0;
            this.PriceOfMeal.Text = "Enter price of meal:";
            // 
            // Tax15
            // 
            this.Tax15.AutoSize = true;
            this.Tax15.Location = new System.Drawing.Point(285, 166);
            this.Tax15.Name = "Tax15";
            this.Tax15.Size = new System.Drawing.Size(55, 25);
            this.Tax15.TabIndex = 1;
            this.Tax15.Text = "15%";
            // 
            // Tax18
            // 
            this.Tax18.AutoSize = true;
            this.Tax18.Location = new System.Drawing.Point(285, 247);
            this.Tax18.Name = "Tax18";
            this.Tax18.Size = new System.Drawing.Size(55, 25);
            this.Tax18.TabIndex = 2;
            this.Tax18.Text = "18%";
            // 
            // Tax20
            // 
            this.Tax20.AutoSize = true;
            this.Tax20.Location = new System.Drawing.Point(285, 325);
            this.Tax20.Name = "Tax20";
            this.Tax20.Size = new System.Drawing.Size(55, 25);
            this.Tax20.TabIndex = 3;
            this.Tax20.Text = "20%";
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(362, 109);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(202, 31);
            this.InputBox.TabIndex = 4;
            // 
            // CalculateTip
            // 
            this.CalculateTip.Location = new System.Drawing.Point(343, 399);
            this.CalculateTip.Name = "CalculateTip";
            this.CalculateTip.Size = new System.Drawing.Size(250, 58);
            this.CalculateTip.TabIndex = 5;
            this.CalculateTip.Text = "Calculate Tip";
            this.CalculateTip.UseVisualStyleBackColor = true;
            this.CalculateTip.Click += new System.EventHandler(this.CalculateTax_Click);
            // 
            // taxes15
            // 
            this.taxes15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxes15.Location = new System.Drawing.Point(362, 165);
            this.taxes15.Name = "taxes15";
            this.taxes15.Size = new System.Drawing.Size(202, 35);
            this.taxes15.TabIndex = 6;
            // 
            // taxes18
            // 
            this.taxes18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxes18.Location = new System.Drawing.Point(362, 246);
            this.taxes18.Name = "taxes18";
            this.taxes18.Size = new System.Drawing.Size(202, 35);
            this.taxes18.TabIndex = 7;
            // 
            // taxes20
            // 
            this.taxes20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxes20.Location = new System.Drawing.Point(362, 324);
            this.taxes20.Name = "taxes20";
            this.taxes20.Size = new System.Drawing.Size(202, 35);
            this.taxes20.TabIndex = 8;
            // 
            // Lab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 544);
            this.Controls.Add(this.taxes20);
            this.Controls.Add(this.taxes18);
            this.Controls.Add(this.taxes15);
            this.Controls.Add(this.CalculateTip);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.Tax20);
            this.Controls.Add(this.Tax18);
            this.Controls.Add(this.Tax15);
            this.Controls.Add(this.PriceOfMeal);
            this.Name = "Lab2";
            this.Text = "Lab 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PriceOfMeal;
        private System.Windows.Forms.Label Tax15;
        private System.Windows.Forms.Label Tax18;
        private System.Windows.Forms.Label Tax20;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Button CalculateTip;
        private System.Windows.Forms.Label taxes15;
        private System.Windows.Forms.Label taxes18;
        private System.Windows.Forms.Label taxes20;
    }
}

