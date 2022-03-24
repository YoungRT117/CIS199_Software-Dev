namespace Lab4
{
    partial class Admission
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
            this.HSGpa = new System.Windows.Forms.Label();
            this.AdmissionTS = new System.Windows.Forms.Label();
            this.HSGpaInput = new System.Windows.Forms.TextBox();
            this.ATSInput = new System.Windows.Forms.TextBox();
            this.AcceptOrReject = new System.Windows.Forms.Label();
            this.RunningTotals = new System.Windows.Forms.Label();
            this.Accepted = new System.Windows.Forms.Label();
            this.AcceptedTotal = new System.Windows.Forms.Label();
            this.Rejected = new System.Windows.Forms.Label();
            this.RejectedTotal = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.AdDecision = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HSGpa
            // 
            this.HSGpa.AutoSize = true;
            this.HSGpa.Location = new System.Drawing.Point(115, 61);
            this.HSGpa.Name = "HSGpa";
            this.HSGpa.Size = new System.Drawing.Size(184, 25);
            this.HSGpa.TabIndex = 0;
            this.HSGpa.Text = "High School GPA:";
            // 
            // AdmissionTS
            // 
            this.AdmissionTS.AutoSize = true;
            this.AdmissionTS.Location = new System.Drawing.Point(72, 131);
            this.AdmissionTS.Name = "AdmissionTS";
            this.AdmissionTS.Size = new System.Drawing.Size(227, 25);
            this.AdmissionTS.TabIndex = 1;
            this.AdmissionTS.Text = "Admission Test Score:";
            // 
            // HSGpaInput
            // 
            this.HSGpaInput.Location = new System.Drawing.Point(305, 58);
            this.HSGpaInput.Name = "HSGpaInput";
            this.HSGpaInput.Size = new System.Drawing.Size(188, 31);
            this.HSGpaInput.TabIndex = 2;
            // 
            // ATSInput
            // 
            this.ATSInput.Location = new System.Drawing.Point(305, 128);
            this.ATSInput.Name = "ATSInput";
            this.ATSInput.Size = new System.Drawing.Size(188, 31);
            this.ATSInput.TabIndex = 3;
            // 
            // AcceptOrReject
            // 
            this.AcceptOrReject.AutoSize = true;
            this.AcceptOrReject.Location = new System.Drawing.Point(517, 248);
            this.AcceptOrReject.Name = "AcceptOrReject";
            this.AcceptOrReject.Size = new System.Drawing.Size(0, 25);
            this.AcceptOrReject.TabIndex = 5;
            this.AcceptOrReject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RunningTotals
            // 
            this.RunningTotals.AutoSize = true;
            this.RunningTotals.Location = new System.Drawing.Point(42, 356);
            this.RunningTotals.Name = "RunningTotals";
            this.RunningTotals.Size = new System.Drawing.Size(163, 25);
            this.RunningTotals.TabIndex = 6;
            this.RunningTotals.Text = "Running Totals:";
            // 
            // Accepted
            // 
            this.Accepted.AutoSize = true;
            this.Accepted.Location = new System.Drawing.Point(191, 441);
            this.Accepted.Name = "Accepted";
            this.Accepted.Size = new System.Drawing.Size(108, 25);
            this.Accepted.TabIndex = 7;
            this.Accepted.Text = "Accepted:";
            // 
            // AcceptedTotal
            // 
            this.AcceptedTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AcceptedTotal.Location = new System.Drawing.Point(305, 440);
            this.AcceptedTotal.Name = "AcceptedTotal";
            this.AcceptedTotal.Size = new System.Drawing.Size(112, 35);
            this.AcceptedTotal.TabIndex = 8;
            // 
            // Rejected
            // 
            this.Rejected.AutoSize = true;
            this.Rejected.Location = new System.Drawing.Point(493, 440);
            this.Rejected.Name = "Rejected";
            this.Rejected.Size = new System.Drawing.Size(103, 25);
            this.Rejected.TabIndex = 9;
            this.Rejected.Text = "Rejected:";
            // 
            // RejectedTotal
            // 
            this.RejectedTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RejectedTotal.Location = new System.Drawing.Point(602, 439);
            this.RejectedTotal.Name = "RejectedTotal";
            this.RejectedTotal.Size = new System.Drawing.Size(112, 35);
            this.RejectedTotal.TabIndex = 10;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(512, 58);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(306, 98);
            this.Calculate.TabIndex = 11;
            this.Calculate.Text = "Calculate Admission";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // AdDecision
            // 
            this.AdDecision.AutoSize = true;
            this.AdDecision.Location = new System.Drawing.Point(305, 248);
            this.AdDecision.Name = "AdDecision";
            this.AdDecision.Size = new System.Drawing.Size(206, 25);
            this.AdDecision.TabIndex = 12;
            this.AdDecision.Text = "Admission Decision:";
            // 
            // Admission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 578);
            this.Controls.Add(this.AdDecision);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.RejectedTotal);
            this.Controls.Add(this.Rejected);
            this.Controls.Add(this.AcceptedTotal);
            this.Controls.Add(this.Accepted);
            this.Controls.Add(this.RunningTotals);
            this.Controls.Add(this.AcceptOrReject);
            this.Controls.Add(this.ATSInput);
            this.Controls.Add(this.HSGpaInput);
            this.Controls.Add(this.AdmissionTS);
            this.Controls.Add(this.HSGpa);
            this.Name = "Admission";
            this.Text = "University Admission Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HSGpa;
        private System.Windows.Forms.Label AdmissionTS;
        private System.Windows.Forms.TextBox HSGpaInput;
        private System.Windows.Forms.TextBox ATSInput;
        private System.Windows.Forms.Label AcceptOrReject;
        private System.Windows.Forms.Label RunningTotals;
        private System.Windows.Forms.Label Accepted;
        private System.Windows.Forms.Label AcceptedTotal;
        private System.Windows.Forms.Label Rejected;
        private System.Windows.Forms.Label RejectedTotal;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label AdDecision;
    }
}

