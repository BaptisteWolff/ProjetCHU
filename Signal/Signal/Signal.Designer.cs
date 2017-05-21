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
            this.LabelPath = new System.Windows.Forms.Label();
            this.buttonPath = new System.Windows.Forms.Button();
            this.buttonValeurSignal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(-4, 154);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(872, 186);
            this.listBox1.TabIndex = 0;
            // 
            // LabelPath
            // 
            this.LabelPath.AutoSize = true;
            this.LabelPath.Location = new System.Drawing.Point(12, 25);
            this.LabelPath.Name = "LabelPath";
            this.LabelPath.Size = new System.Drawing.Size(29, 13);
            this.LabelPath.TabIndex = 1;
            this.LabelPath.Text = "Path";
            // 
            // buttonPath
            // 
            this.buttonPath.Location = new System.Drawing.Point(15, 54);
            this.buttonPath.Name = "buttonPath";
            this.buttonPath.Size = new System.Drawing.Size(109, 23);
            this.buttonPath.TabIndex = 2;
            this.buttonPath.Text = "Change path";
            this.buttonPath.UseVisualStyleBackColor = true;
            this.buttonPath.Click += new System.EventHandler(this.buttonPath_Click);
            // 
            // buttonValeurSignal
            // 
            this.buttonValeurSignal.Location = new System.Drawing.Point(15, 83);
            this.buttonValeurSignal.Name = "buttonValeurSignal";
            this.buttonValeurSignal.Size = new System.Drawing.Size(109, 23);
            this.buttonValeurSignal.TabIndex = 3;
            this.buttonValeurSignal.Text = "valeur_signal(path)";
            this.buttonValeurSignal.UseVisualStyleBackColor = true;
            this.buttonValeurSignal.Click += new System.EventHandler(this.buttonValeurSignal_Click);
            // 
            // Signal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 340);
            this.Controls.Add(this.buttonValeurSignal);
            this.Controls.Add(this.buttonPath);
            this.Controls.Add(this.LabelPath);
            this.Controls.Add(this.listBox1);
            this.Name = "Signal";
            this.Text = "Signal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label LabelPath;
        private System.Windows.Forms.Button buttonPath;
        private System.Windows.Forms.Button buttonValeurSignal;
    }
}