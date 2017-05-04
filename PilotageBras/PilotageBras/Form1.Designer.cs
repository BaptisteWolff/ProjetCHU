namespace PilotageBras
{
    partial class Form1
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
            this.itineraire = new System.Windows.Forms.ListBox();
            this.chooseCOM = new System.Windows.Forms.ComboBox();
            this.labelCOM = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.positionX = new System.Windows.Forms.TextBox();
            this.Xdec = new System.Windows.Forms.Button();
            this.Xinc = new System.Windows.Forms.Button();
            this.Yinc = new System.Windows.Forms.Button();
            this.Ydec = new System.Windows.Forms.Button();
            this.positionY = new System.Windows.Forms.TextBox();
            this.labelY = new System.Windows.Forms.Label();
            this.Zinc = new System.Windows.Forms.Button();
            this.Zdec = new System.Windows.Forms.Button();
            this.positionZ = new System.Windows.Forms.TextBox();
            this.labelZ = new System.Windows.Forms.Label();
            this.interval = new System.Windows.Forms.TextBox();
            this.goTo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.portCOM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itineraire
            // 
            this.itineraire.FormattingEnabled = true;
            this.itineraire.Location = new System.Drawing.Point(12, 99);
            this.itineraire.Name = "itineraire";
            this.itineraire.Size = new System.Drawing.Size(721, 303);
            this.itineraire.TabIndex = 0;
            // 
            // chooseCOM
            // 
            this.chooseCOM.FormattingEnabled = true;
            this.chooseCOM.Location = new System.Drawing.Point(12, 36);
            this.chooseCOM.Name = "chooseCOM";
            this.chooseCOM.Size = new System.Drawing.Size(121, 21);
            this.chooseCOM.TabIndex = 1;
            // 
            // labelCOM
            // 
            this.labelCOM.AutoSize = true;
            this.labelCOM.Location = new System.Drawing.Point(59, 20);
            this.labelCOM.Name = "labelCOM";
            this.labelCOM.Size = new System.Drawing.Size(34, 13);
            this.labelCOM.TabIndex = 2;
            this.labelCOM.Text = "COM:";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(274, 11);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(17, 13);
            this.labelX.TabIndex = 3;
            this.labelX.Text = "X:";
            // 
            // positionX
            // 
            this.positionX.Location = new System.Drawing.Point(297, 9);
            this.positionX.Name = "positionX";
            this.positionX.Size = new System.Drawing.Size(100, 20);
            this.positionX.TabIndex = 4;
            this.positionX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Xdec
            // 
            this.Xdec.Location = new System.Drawing.Point(403, 9);
            this.Xdec.Name = "Xdec";
            this.Xdec.Size = new System.Drawing.Size(23, 20);
            this.Xdec.TabIndex = 5;
            this.Xdec.Text = "-";
            this.Xdec.UseVisualStyleBackColor = true;
            this.Xdec.Click += new System.EventHandler(this.Xdec_Click);
            // 
            // Xinc
            // 
            this.Xinc.Location = new System.Drawing.Point(433, 9);
            this.Xinc.Name = "Xinc";
            this.Xinc.Size = new System.Drawing.Size(21, 20);
            this.Xinc.TabIndex = 6;
            this.Xinc.Text = "+";
            this.Xinc.UseVisualStyleBackColor = true;
            this.Xinc.Click += new System.EventHandler(this.Xinc_Click);
            // 
            // Yinc
            // 
            this.Yinc.Location = new System.Drawing.Point(433, 35);
            this.Yinc.Name = "Yinc";
            this.Yinc.Size = new System.Drawing.Size(21, 20);
            this.Yinc.TabIndex = 10;
            this.Yinc.Text = "+";
            this.Yinc.UseVisualStyleBackColor = true;
            this.Yinc.Click += new System.EventHandler(this.Yinc_Click);
            // 
            // Ydec
            // 
            this.Ydec.Location = new System.Drawing.Point(403, 35);
            this.Ydec.Name = "Ydec";
            this.Ydec.Size = new System.Drawing.Size(23, 20);
            this.Ydec.TabIndex = 9;
            this.Ydec.Text = "-";
            this.Ydec.UseVisualStyleBackColor = true;
            this.Ydec.Click += new System.EventHandler(this.Ydec_Click);
            // 
            // positionY
            // 
            this.positionY.Location = new System.Drawing.Point(297, 35);
            this.positionY.Name = "positionY";
            this.positionY.Size = new System.Drawing.Size(100, 20);
            this.positionY.TabIndex = 8;
            this.positionY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(274, 37);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(17, 13);
            this.labelY.TabIndex = 7;
            this.labelY.Text = "Y:";
            // 
            // Zinc
            // 
            this.Zinc.Location = new System.Drawing.Point(433, 61);
            this.Zinc.Name = "Zinc";
            this.Zinc.Size = new System.Drawing.Size(21, 20);
            this.Zinc.TabIndex = 14;
            this.Zinc.Text = "+";
            this.Zinc.UseVisualStyleBackColor = true;
            this.Zinc.Click += new System.EventHandler(this.Zinc_Click);
            // 
            // Zdec
            // 
            this.Zdec.Location = new System.Drawing.Point(403, 61);
            this.Zdec.Name = "Zdec";
            this.Zdec.Size = new System.Drawing.Size(23, 20);
            this.Zdec.TabIndex = 13;
            this.Zdec.Text = "-";
            this.Zdec.UseVisualStyleBackColor = true;
            this.Zdec.Click += new System.EventHandler(this.Zdec_Click);
            // 
            // positionZ
            // 
            this.positionZ.Location = new System.Drawing.Point(297, 61);
            this.positionZ.Name = "positionZ";
            this.positionZ.Size = new System.Drawing.Size(100, 20);
            this.positionZ.TabIndex = 12;
            this.positionZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Location = new System.Drawing.Point(274, 63);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(17, 13);
            this.labelZ.TabIndex = 11;
            this.labelZ.Text = "Z:";
            // 
            // interval
            // 
            this.interval.Location = new System.Drawing.Point(675, 8);
            this.interval.Name = "interval";
            this.interval.Size = new System.Drawing.Size(58, 20);
            this.interval.TabIndex = 15;
            this.interval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // goTo
            // 
            this.goTo.Location = new System.Drawing.Point(460, 27);
            this.goTo.Name = "goTo";
            this.goTo.Size = new System.Drawing.Size(43, 37);
            this.goTo.TabIndex = 17;
            this.goTo.Text = "Go XYZ";
            this.goTo.UseVisualStyleBackColor = true;
            this.goTo.Click += new System.EventHandler(this.go_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(624, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Interval:";
            // 
            // portCOM
            // 
            this.portCOM.Location = new System.Drawing.Point(41, 61);
            this.portCOM.Name = "portCOM";
            this.portCOM.Size = new System.Drawing.Size(52, 30);
            this.portCOM.TabIndex = 19;
            this.portCOM.Text = "Ports";
            this.portCOM.UseVisualStyleBackColor = true;
            this.portCOM.Click += new System.EventHandler(this.selectCOM);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 413);
            this.Controls.Add(this.portCOM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goTo);
            this.Controls.Add(this.interval);
            this.Controls.Add(this.Zinc);
            this.Controls.Add(this.Zdec);
            this.Controls.Add(this.positionZ);
            this.Controls.Add(this.labelZ);
            this.Controls.Add(this.Yinc);
            this.Controls.Add(this.Ydec);
            this.Controls.Add(this.positionY);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.Xinc);
            this.Controls.Add(this.Xdec);
            this.Controls.Add(this.positionX);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelCOM);
            this.Controls.Add(this.chooseCOM);
            this.Controls.Add(this.itineraire);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox itineraire;
        private System.Windows.Forms.ComboBox chooseCOM;
        private System.Windows.Forms.Label labelCOM;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox positionX;
        private System.Windows.Forms.Button Xdec;
        private System.Windows.Forms.Button Xinc;
        private System.Windows.Forms.Button Yinc;
        private System.Windows.Forms.Button Ydec;
        private System.Windows.Forms.TextBox positionY;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Button Zinc;
        private System.Windows.Forms.Button Zdec;
        private System.Windows.Forms.TextBox positionZ;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.TextBox interval;
        private System.Windows.Forms.Button goTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button portCOM;
    }
}

