namespace Program_1
{
    partial class Program1
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
            this.MaxWidth = new System.Windows.Forms.Label();
            this.MaxLength = new System.Windows.Forms.Label();
            this.CarpetPrice = new System.Windows.Forms.Label();
            this.FirstRoom = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.LayersOPadding = new System.Windows.Forms.Label();
            this.SqYard = new System.Windows.Forms.Label();
            this.CarpetCost = new System.Windows.Forms.Label();
            this.PaddingCost = new System.Windows.Forms.Label();
            this.LaborCost = new System.Windows.Forms.Label();
            this.TotalCost = new System.Windows.Forms.Label();
            this.YardOutput = new System.Windows.Forms.Label();
            this.CarpetOutput = new System.Windows.Forms.Label();
            this.PaddingOutput = new System.Windows.Forms.Label();
            this.LaborOutput = new System.Windows.Forms.Label();
            this.TotalOutput = new System.Windows.Forms.Label();
            this.MaxWidthInput = new System.Windows.Forms.TextBox();
            this.MaxLengthInput = new System.Windows.Forms.TextBox();
            this.CarpetInput = new System.Windows.Forms.TextBox();
            this.PaddingInput = new System.Windows.Forms.TextBox();
            this.FirstRoomInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MaxWidth
            // 
            this.MaxWidth.AutoSize = true;
            this.MaxWidth.Location = new System.Drawing.Point(12, 19);
            this.MaxWidth.Name = "MaxWidth";
            this.MaxWidth.Size = new System.Drawing.Size(370, 25);
            this.MaxWidth.TabIndex = 0;
            this.MaxWidth.Text = "Enter the max width of room (in feet) :";
            // 
            // MaxLength
            // 
            this.MaxLength.AutoSize = true;
            this.MaxLength.Location = new System.Drawing.Point(12, 69);
            this.MaxLength.Name = "MaxLength";
            this.MaxLength.Size = new System.Drawing.Size(379, 25);
            this.MaxLength.TabIndex = 1;
            this.MaxLength.Text = "Enter the max length of room (in feet) :";
            // 
            // CarpetPrice
            // 
            this.CarpetPrice.AutoSize = true;
            this.CarpetPrice.Location = new System.Drawing.Point(12, 119);
            this.CarpetPrice.Name = "CarpetPrice";
            this.CarpetPrice.Size = new System.Drawing.Size(364, 25);
            this.CarpetPrice.TabIndex = 2;
            this.CarpetPrice.Text = "Enter the carpet price (per sq. yard) :";
            // 
            // FirstRoom
            // 
            this.FirstRoom.AutoSize = true;
            this.FirstRoom.Location = new System.Drawing.Point(12, 217);
            this.FirstRoom.Name = "FirstRoom";
            this.FirstRoom.Size = new System.Drawing.Size(403, 25);
            this.FirstRoom.TabIndex = 4;
            this.FirstRoom.Text = "Is this the first room? ( 1 = YES, 0 = No) :";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(12, 260);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(902, 85);
            this.Calculate.TabIndex = 5;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // LayersOPadding
            // 
            this.LayersOPadding.AutoSize = true;
            this.LayersOPadding.Location = new System.Drawing.Point(12, 168);
            this.LayersOPadding.Name = "LayersOPadding";
            this.LayersOPadding.Size = new System.Drawing.Size(386, 25);
            this.LayersOPadding.TabIndex = 6;
            this.LayersOPadding.Text = "Enter layers of padding to use (1 or 2) :";
            // 
            // SqYard
            // 
            this.SqYard.AutoSize = true;
            this.SqYard.Location = new System.Drawing.Point(244, 381);
            this.SqYard.Name = "SqYard";
            this.SqYard.Size = new System.Drawing.Size(194, 25);
            this.SqYard.TabIndex = 7;
            this.SqYard.Text = "Sq. Yards Needed:";
            // 
            // CarpetCost
            // 
            this.CarpetCost.AutoSize = true;
            this.CarpetCost.Location = new System.Drawing.Point(306, 445);
            this.CarpetCost.Name = "CarpetCost";
            this.CarpetCost.Size = new System.Drawing.Size(132, 25);
            this.CarpetCost.TabIndex = 8;
            this.CarpetCost.Text = "Carpet Cost:";
            // 
            // PaddingCost
            // 
            this.PaddingCost.AutoSize = true;
            this.PaddingCost.Location = new System.Drawing.Point(291, 509);
            this.PaddingCost.Name = "PaddingCost";
            this.PaddingCost.Size = new System.Drawing.Size(147, 25);
            this.PaddingCost.TabIndex = 9;
            this.PaddingCost.Text = "Padding Cost:";
            // 
            // LaborCost
            // 
            this.LaborCost.AutoSize = true;
            this.LaborCost.Location = new System.Drawing.Point(315, 577);
            this.LaborCost.Name = "LaborCost";
            this.LaborCost.Size = new System.Drawing.Size(123, 25);
            this.LaborCost.TabIndex = 10;
            this.LaborCost.Text = "Labor Cost:";
            // 
            // TotalCost
            // 
            this.TotalCost.AutoSize = true;
            this.TotalCost.Location = new System.Drawing.Point(322, 647);
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.Size = new System.Drawing.Size(116, 25);
            this.TotalCost.TabIndex = 11;
            this.TotalCost.Text = "Total Cost:";
            // 
            // YardOutput
            // 
            this.YardOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YardOutput.Location = new System.Drawing.Point(444, 371);
            this.YardOutput.Name = "YardOutput";
            this.YardOutput.Size = new System.Drawing.Size(208, 45);
            this.YardOutput.TabIndex = 12;
            // 
            // CarpetOutput
            // 
            this.CarpetOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CarpetOutput.Location = new System.Drawing.Point(444, 434);
            this.CarpetOutput.Name = "CarpetOutput";
            this.CarpetOutput.Size = new System.Drawing.Size(208, 45);
            this.CarpetOutput.TabIndex = 13;
            // 
            // PaddingOutput
            // 
            this.PaddingOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaddingOutput.Location = new System.Drawing.Point(444, 499);
            this.PaddingOutput.Name = "PaddingOutput";
            this.PaddingOutput.Size = new System.Drawing.Size(208, 45);
            this.PaddingOutput.TabIndex = 14;
            // 
            // LaborOutput
            // 
            this.LaborOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LaborOutput.Location = new System.Drawing.Point(444, 566);
            this.LaborOutput.Name = "LaborOutput";
            this.LaborOutput.Size = new System.Drawing.Size(208, 45);
            this.LaborOutput.TabIndex = 15;
            // 
            // TotalOutput
            // 
            this.TotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalOutput.Location = new System.Drawing.Point(441, 627);
            this.TotalOutput.Name = "TotalOutput";
            this.TotalOutput.Size = new System.Drawing.Size(208, 45);
            this.TotalOutput.TabIndex = 16;
            // 
            // MaxWidthInput
            // 
            this.MaxWidthInput.Location = new System.Drawing.Point(388, 16);
            this.MaxWidthInput.Name = "MaxWidthInput";
            this.MaxWidthInput.Size = new System.Drawing.Size(252, 31);
            this.MaxWidthInput.TabIndex = 17;
            // 
            // MaxLengthInput
            // 
            this.MaxLengthInput.Location = new System.Drawing.Point(397, 66);
            this.MaxLengthInput.Name = "MaxLengthInput";
            this.MaxLengthInput.Size = new System.Drawing.Size(252, 31);
            this.MaxLengthInput.TabIndex = 18;
            // 
            // CarpetInput
            // 
            this.CarpetInput.Location = new System.Drawing.Point(382, 116);
            this.CarpetInput.Name = "CarpetInput";
            this.CarpetInput.Size = new System.Drawing.Size(252, 31);
            this.CarpetInput.TabIndex = 19;
            // 
            // PaddingInput
            // 
            this.PaddingInput.Location = new System.Drawing.Point(404, 165);
            this.PaddingInput.Name = "PaddingInput";
            this.PaddingInput.Size = new System.Drawing.Size(252, 31);
            this.PaddingInput.TabIndex = 20;
            // 
            // FirstRoomInput
            // 
            this.FirstRoomInput.Location = new System.Drawing.Point(421, 214);
            this.FirstRoomInput.Name = "FirstRoomInput";
            this.FirstRoomInput.Size = new System.Drawing.Size(252, 31);
            this.FirstRoomInput.TabIndex = 21;
            // 
            // Program1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 708);
            this.Controls.Add(this.FirstRoomInput);
            this.Controls.Add(this.PaddingInput);
            this.Controls.Add(this.CarpetInput);
            this.Controls.Add(this.MaxLengthInput);
            this.Controls.Add(this.MaxWidthInput);
            this.Controls.Add(this.TotalOutput);
            this.Controls.Add(this.LaborOutput);
            this.Controls.Add(this.PaddingOutput);
            this.Controls.Add(this.CarpetOutput);
            this.Controls.Add(this.YardOutput);
            this.Controls.Add(this.TotalCost);
            this.Controls.Add(this.LaborCost);
            this.Controls.Add(this.PaddingCost);
            this.Controls.Add(this.CarpetCost);
            this.Controls.Add(this.SqYard);
            this.Controls.Add(this.LayersOPadding);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.FirstRoom);
            this.Controls.Add(this.CarpetPrice);
            this.Controls.Add(this.MaxLength);
            this.Controls.Add(this.MaxWidth);
            this.Name = "Program1";
            this.Text = "Welcome to the Handy-Dandy Carpet Estimator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MaxWidth;
        private System.Windows.Forms.Label MaxLength;
        private System.Windows.Forms.Label CarpetPrice;
        private System.Windows.Forms.Label FirstRoom;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label LayersOPadding;
        private System.Windows.Forms.Label SqYard;
        private System.Windows.Forms.Label CarpetCost;
        private System.Windows.Forms.Label PaddingCost;
        private System.Windows.Forms.Label LaborCost;
        private System.Windows.Forms.Label TotalCost;
        private System.Windows.Forms.Label YardOutput;
        private System.Windows.Forms.Label CarpetOutput;
        private System.Windows.Forms.Label PaddingOutput;
        private System.Windows.Forms.Label LaborOutput;
        private System.Windows.Forms.Label TotalOutput;
        private System.Windows.Forms.TextBox MaxWidthInput;
        private System.Windows.Forms.TextBox MaxLengthInput;
        private System.Windows.Forms.TextBox CarpetInput;
        private System.Windows.Forms.TextBox PaddingInput;
        private System.Windows.Forms.TextBox FirstRoomInput;
    }
}

