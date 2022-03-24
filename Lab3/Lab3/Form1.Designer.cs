namespace Lab3
{
    partial class Lab3
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
            this.RadOSphere = new System.Windows.Forms.Label();
            this.Diameter = new System.Windows.Forms.Label();
            this.SurfaceA = new System.Windows.Forms.Label();
            this.Volume = new System.Windows.Forms.Label();
            this.Dinput = new System.Windows.Forms.Label();
            this.SAinput = new System.Windows.Forms.Label();
            this.Vinput = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.ROSinput = new System.Windows.Forms.TextBox();
            this.TopPic = new System.Windows.Forms.PictureBox();
            this.BottomPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TopPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomPic)).BeginInit();
            this.SuspendLayout();
            // 
            // RadOSphere
            // 
            this.RadOSphere.AutoSize = true;
            this.RadOSphere.Location = new System.Drawing.Point(315, 126);
            this.RadOSphere.Name = "RadOSphere";
            this.RadOSphere.Size = new System.Drawing.Size(181, 25);
            this.RadOSphere.TabIndex = 0;
            this.RadOSphere.Text = "Radius of sphere:";
            // 
            // Diameter
            // 
            this.Diameter.AutoSize = true;
            this.Diameter.Location = new System.Drawing.Point(49, 354);
            this.Diameter.Name = "Diameter";
            this.Diameter.Size = new System.Drawing.Size(98, 25);
            this.Diameter.TabIndex = 1;
            this.Diameter.Text = "Diameter";
            // 
            // SurfaceA
            // 
            this.SurfaceA.AutoSize = true;
            this.SurfaceA.Location = new System.Drawing.Point(12, 440);
            this.SurfaceA.Name = "SurfaceA";
            this.SurfaceA.Size = new System.Drawing.Size(137, 25);
            this.SurfaceA.TabIndex = 2;
            this.SurfaceA.Text = "Surface Area";
            // 
            // Volume
            // 
            this.Volume.AutoSize = true;
            this.Volume.Location = new System.Drawing.Point(63, 520);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(84, 25);
            this.Volume.TabIndex = 3;
            this.Volume.Text = "Volume";
            // 
            // Dinput
            // 
            this.Dinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Dinput.Location = new System.Drawing.Point(153, 353);
            this.Dinput.Name = "Dinput";
            this.Dinput.Size = new System.Drawing.Size(176, 41);
            this.Dinput.TabIndex = 4;
            // 
            // SAinput
            // 
            this.SAinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SAinput.Location = new System.Drawing.Point(155, 440);
            this.SAinput.Name = "SAinput";
            this.SAinput.Size = new System.Drawing.Size(176, 41);
            this.SAinput.TabIndex = 5;
            // 
            // Vinput
            // 
            this.Vinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Vinput.Location = new System.Drawing.Point(153, 519);
            this.Vinput.Name = "Vinput";
            this.Vinput.Size = new System.Drawing.Size(176, 41);
            this.Vinput.TabIndex = 6;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(517, 178);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(147, 45);
            this.Calculate.TabIndex = 7;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // ROSinput
            // 
            this.ROSinput.Location = new System.Drawing.Point(502, 126);
            this.ROSinput.Name = "ROSinput";
            this.ROSinput.Size = new System.Drawing.Size(178, 31);
            this.ROSinput.TabIndex = 8;
            // 
            // TopPic
            // 
            this.TopPic.Image = global::Lab3.Properties.Resources.Sphere_and_Ball;
            this.TopPic.Location = new System.Drawing.Point(36, 44);
            this.TopPic.Name = "TopPic";
            this.TopPic.Size = new System.Drawing.Size(273, 219);
            this.TopPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TopPic.TabIndex = 9;
            this.TopPic.TabStop = false;
            // 
            // BottomPic
            // 
            this.BottomPic.Image = global::Lab3.Properties.Resources.Sphere_and_Ball;
            this.BottomPic.Location = new System.Drawing.Point(407, 385);
            this.BottomPic.Name = "BottomPic";
            this.BottomPic.Size = new System.Drawing.Size(273, 219);
            this.BottomPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BottomPic.TabIndex = 10;
            this.BottomPic.TabStop = false;
            // 
            // Lab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 649);
            this.Controls.Add(this.BottomPic);
            this.Controls.Add(this.TopPic);
            this.Controls.Add(this.ROSinput);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Vinput);
            this.Controls.Add(this.SAinput);
            this.Controls.Add(this.Dinput);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.SurfaceA);
            this.Controls.Add(this.Diameter);
            this.Controls.Add(this.RadOSphere);
            this.Name = "Lab3";
            this.Text = "Lab 3";
            ((System.ComponentModel.ISupportInitialize)(this.TopPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RadOSphere;
        private System.Windows.Forms.Label Diameter;
        private System.Windows.Forms.Label SurfaceA;
        private System.Windows.Forms.Label Volume;
        private System.Windows.Forms.Label Dinput;
        private System.Windows.Forms.Label SAinput;
        private System.Windows.Forms.Label Vinput;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox ROSinput;
        private System.Windows.Forms.PictureBox TopPic;
        private System.Windows.Forms.PictureBox BottomPic;
    }
}

