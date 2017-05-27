namespace Signal
{
    partial class Signal
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.LabelFileIn = new System.Windows.Forms.Label();
            this.buttonFileIn = new System.Windows.Forms.Button();
            this.buttonValeurSignal = new System.Windows.Forms.Button();
            this.labelPath = new System.Windows.Forms.Label();
            this.buttonPath = new System.Windows.Forms.Button();
            this.button_clearResults = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_posX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_posY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_posZ = new System.Windows.Forms.TextBox();
            this.buttonMapping = new System.Windows.Forms.Button();
            this.textBox_savedFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(-1, 271);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(872, 186);
            this.listBox1.TabIndex = 0;
            // 
            // LabelFileIn
            // 
            this.LabelFileIn.AutoSize = true;
            this.LabelFileIn.Location = new System.Drawing.Point(138, 24);
            this.LabelFileIn.Name = "LabelFileIn";
            this.LabelFileIn.Size = new System.Drawing.Size(52, 13);
            this.LabelFileIn.TabIndex = 1;
            this.LabelFileIn.Text = "File name";
            // 
            // buttonFileIn
            // 
            this.buttonFileIn.Location = new System.Drawing.Point(15, 19);
            this.buttonFileIn.Name = "buttonFileIn";
            this.buttonFileIn.Size = new System.Drawing.Size(109, 23);
            this.buttonFileIn.TabIndex = 2;
            this.buttonFileIn.Text = "Change file";
            this.buttonFileIn.UseVisualStyleBackColor = true;
            this.buttonFileIn.Click += new System.EventHandler(this.buttonFileIn_Click);
            // 
            // buttonValeurSignal
            // 
            this.buttonValeurSignal.Location = new System.Drawing.Point(15, 48);
            this.buttonValeurSignal.Name = "buttonValeurSignal";
            this.buttonValeurSignal.Size = new System.Drawing.Size(109, 23);
            this.buttonValeurSignal.TabIndex = 3;
            this.buttonValeurSignal.Text = "valeur_signal(file)";
            this.buttonValeurSignal.UseVisualStyleBackColor = true;
            this.buttonValeurSignal.Click += new System.EventHandler(this.buttonValeurSignal_Click);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(138, 99);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(78, 13);
            this.labelPath.TabIndex = 4;
            this.labelPath.Text = "Saved file path";
            // 
            // buttonPath
            // 
            this.buttonPath.Location = new System.Drawing.Point(15, 94);
            this.buttonPath.Name = "buttonPath";
            this.buttonPath.Size = new System.Drawing.Size(109, 23);
            this.buttonPath.TabIndex = 5;
            this.buttonPath.Text = "Change path";
            this.buttonPath.UseVisualStyleBackColor = true;
            this.buttonPath.Click += new System.EventHandler(this.buttonFileOut_Click_1);
            // 
            // button_clearResults
            // 
            this.button_clearResults.Location = new System.Drawing.Point(12, 232);
            this.button_clearResults.Name = "button_clearResults";
            this.button_clearResults.Size = new System.Drawing.Size(109, 23);
            this.button_clearResults.TabIndex = 6;
            this.button_clearResults.Text = "Clear results";
            this.button_clearResults.UseVisualStyleBackColor = true;
            this.button_clearResults.Click += new System.EventHandler(this.button_clearResults_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Position :";
            // 
            // textBox_posX
            // 
            this.textBox_posX.Location = new System.Drawing.Point(272, 51);
            this.textBox_posX.Name = "textBox_posX";
            this.textBox_posX.Size = new System.Drawing.Size(84, 20);
            this.textBox_posX.TabIndex = 8;
            this.textBox_posX.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "x :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "y :";
            // 
            // textBox_posY
            // 
            this.textBox_posY.Location = new System.Drawing.Point(383, 51);
            this.textBox_posY.Name = "textBox_posY";
            this.textBox_posY.Size = new System.Drawing.Size(82, 20);
            this.textBox_posY.TabIndex = 11;
            this.textBox_posY.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "z :";
            // 
            // textBox_posZ
            // 
            this.textBox_posZ.Location = new System.Drawing.Point(495, 51);
            this.textBox_posZ.Name = "textBox_posZ";
            this.textBox_posZ.Size = new System.Drawing.Size(84, 20);
            this.textBox_posZ.TabIndex = 13;
            this.textBox_posZ.Text = "0";
            // 
            // buttonMapping
            // 
            this.buttonMapping.Location = new System.Drawing.Point(12, 159);
            this.buttonMapping.Name = "buttonMapping";
            this.buttonMapping.Size = new System.Drawing.Size(109, 23);
            this.buttonMapping.TabIndex = 15;
            this.buttonMapping.Text = "mapping";
            this.buttonMapping.UseVisualStyleBackColor = true;
            this.buttonMapping.Click += new System.EventHandler(this.buttonMapping_Click);
            // 
            // textBox_savedFile
            // 
            this.textBox_savedFile.Location = new System.Drawing.Point(141, 126);
            this.textBox_savedFile.Name = "textBox_savedFile";
            this.textBox_savedFile.Size = new System.Drawing.Size(100, 20);
            this.textBox_savedFile.TabIndex = 16;
            this.textBox_savedFile.Text = "test";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Saved file name :";
            // 
            // Signal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 454);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_savedFile);
            this.Controls.Add(this.buttonMapping);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_posZ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_posY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_posX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_clearResults);
            this.Controls.Add(this.buttonPath);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.buttonValeurSignal);
            this.Controls.Add(this.buttonFileIn);
            this.Controls.Add(this.LabelFileIn);
            this.Controls.Add(this.listBox1);
            this.Name = "Signal";
            this.Text = "Signal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label LabelFileIn;
        private System.Windows.Forms.Button buttonFileIn;
        private System.Windows.Forms.Button buttonValeurSignal;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Button buttonPath;
        private System.Windows.Forms.Button button_clearResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_posX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_posY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_posZ;
        private System.Windows.Forms.Button buttonMapping;
        private System.Windows.Forms.TextBox textBox_savedFile;
        private System.Windows.Forms.Label label5;
    }
}