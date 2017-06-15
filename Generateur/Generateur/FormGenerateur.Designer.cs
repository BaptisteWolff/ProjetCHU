namespace Generateur
{
    partial class Generateur
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
            this.selectionCOM = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LockPorts = new System.Windows.Forms.Button();
            this.buttonPulse = new System.Windows.Forms.Button();
            this.buttonStatus = new System.Windows.Forms.Button();
            this.StatutsBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectionCOM
            // 
            this.selectionCOM.FormattingEnabled = true;
            this.selectionCOM.Location = new System.Drawing.Point(12, 70);
            this.selectionCOM.Name = "selectionCOM";
            this.selectionCOM.Size = new System.Drawing.Size(121, 21);
            this.selectionCOM.TabIndex = 0;
            this.selectionCOM.SelectedIndexChanged += new System.EventHandler(this.selectionCOM_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // LockPorts
            // 
            this.LockPorts.Location = new System.Drawing.Point(48, 97);
            this.LockPorts.Name = "LockPorts";
            this.LockPorts.Size = new System.Drawing.Size(40, 23);
            this.LockPorts.TabIndex = 2;
            this.LockPorts.Text = "Ports";
            this.LockPorts.UseVisualStyleBackColor = true;
            this.LockPorts.Click += new System.EventHandler(this.ports_click);
            // 
            // buttonPulse
            // 
            this.buttonPulse.Location = new System.Drawing.Point(171, 56);
            this.buttonPulse.Name = "buttonPulse";
            this.buttonPulse.Size = new System.Drawing.Size(75, 23);
            this.buttonPulse.TabIndex = 3;
            this.buttonPulse.Text = "Pulse";
            this.buttonPulse.UseVisualStyleBackColor = true;
            this.buttonPulse.Click += new System.EventHandler(this.pulse_click);
            // 
            // buttonStatus
            // 
            this.buttonStatus.Location = new System.Drawing.Point(171, 85);
            this.buttonStatus.Name = "buttonStatus";
            this.buttonStatus.Size = new System.Drawing.Size(75, 23);
            this.buttonStatus.TabIndex = 4;
            this.buttonStatus.Text = "Status";
            this.buttonStatus.UseVisualStyleBackColor = true;
            this.buttonStatus.Click += new System.EventHandler(this.statuts_click);
            // 
            // StatutsBox
            // 
            this.StatutsBox.Location = new System.Drawing.Point(316, 12);
            this.StatutsBox.Name = "StatutsBox";
            this.StatutsBox.Size = new System.Drawing.Size(398, 354);
            this.StatutsBox.TabIndex = 5;
            this.StatutsBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Select port";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Generateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 378);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StatutsBox);
            this.Controls.Add(this.buttonStatus);
            this.Controls.Add(this.buttonPulse);
            this.Controls.Add(this.LockPorts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectionCOM);
            this.Name = "Generateur";
            this.Text = "Generateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectionCOM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LockPorts;
        private System.Windows.Forms.Button buttonPulse;
        private System.Windows.Forms.Button buttonStatus;
        private System.Windows.Forms.RichTextBox StatutsBox;
        private System.Windows.Forms.Button button1;
    }
}

