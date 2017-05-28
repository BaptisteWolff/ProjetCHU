namespace WCFServer
{
    partial class FormServeurPicoscope
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonImediateBlock = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSampleCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.textBoxSetPeriod = new System.Windows.Forms.TextBox();
            this.buttonSetPico = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelChD = new System.Windows.Forms.Label();
            this.trackBarChD = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.labelChC = new System.Windows.Forms.Label();
            this.trackBarChC = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.labelChB = new System.Windows.Forms.Label();
            this.trackBarChB = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.labelChA = new System.Windows.Forms.Label();
            this.trackBarChA = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarChD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarChC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarChB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarChA)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(325, 275);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonImediateBlock
            // 
            this.buttonImediateBlock.Location = new System.Drawing.Point(127, 12);
            this.buttonImediateBlock.Name = "buttonImediateBlock";
            this.buttonImediateBlock.Size = new System.Drawing.Size(98, 23);
            this.buttonImediateBlock.TabIndex = 3;
            this.buttonImediateBlock.Text = "Capture signal";
            this.buttonImediateBlock.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonImediateBlock.UseVisualStyleBackColor = true;
            this.buttonImediateBlock.Click += new System.EventHandler(this.buttonImmediateBlock_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxSampleCount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxFileName);
            this.groupBox1.Controls.Add(this.textBoxSetPeriod);
            this.groupBox1.Controls.Add(this.buttonSetPico);
            this.groupBox1.Controls.Add(this.buttonImediateBlock);
            this.groupBox1.Location = new System.Drawing.Point(325, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 273);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Period (ns) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sample count :";
            // 
            // textBoxSampleCount
            // 
            this.textBoxSampleCount.Location = new System.Drawing.Point(125, 144);
            this.textBoxSampleCount.Name = "textBoxSampleCount";
            this.textBoxSampleCount.Size = new System.Drawing.Size(100, 20);
            this.textBoxSampleCount.TabIndex = 8;
            this.textBoxSampleCount.Text = "20000";
            this.textBoxSampleCount.TextChanged += new System.EventHandler(this.textBoxSampleCount_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "File name :";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(70, 241);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(155, 20);
            this.textBoxFileName.TabIndex = 6;
            this.textBoxFileName.Text = "block.csv";
            this.textBoxFileName.TextChanged += new System.EventHandler(this.textBoxFileName_TextChanged);
            // 
            // textBoxSetPeriod
            // 
            this.textBoxSetPeriod.Location = new System.Drawing.Point(125, 109);
            this.textBoxSetPeriod.Name = "textBoxSetPeriod";
            this.textBoxSetPeriod.Size = new System.Drawing.Size(100, 20);
            this.textBoxSetPeriod.TabIndex = 5;
            this.textBoxSetPeriod.Text = "16";
            this.textBoxSetPeriod.TextChanged += new System.EventHandler(this.textBoxSetPeriod_TextChanged);
            // 
            // buttonSetPico
            // 
            this.buttonSetPico.Location = new System.Drawing.Point(9, 12);
            this.buttonSetPico.Name = "buttonSetPico";
            this.buttonSetPico.Size = new System.Drawing.Size(97, 23);
            this.buttonSetPico.TabIndex = 5;
            this.buttonSetPico.Text = "Set Picoscope";
            this.buttonSetPico.UseVisualStyleBackColor = true;
            this.buttonSetPico.Click += new System.EventHandler(this.buttonSetPico_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.labelChD);
            this.groupBox2.Controls.Add(this.trackBarChD);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.labelChC);
            this.groupBox2.Controls.Add(this.trackBarChC);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.labelChB);
            this.groupBox2.Controls.Add(this.trackBarChB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.labelChA);
            this.groupBox2.Controls.Add(this.trackBarChA);
            this.groupBox2.Location = new System.Drawing.Point(568, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 275);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Voltage range";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Channel D";
            // 
            // labelChD
            // 
            this.labelChD.AutoSize = true;
            this.labelChD.Location = new System.Drawing.Point(213, 39);
            this.labelChD.Name = "labelChD";
            this.labelChD.Size = new System.Drawing.Size(43, 13);
            this.labelChD.TabIndex = 10;
            this.labelChD.Text = "000 mV";
            this.labelChD.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // trackBarChD
            // 
            this.trackBarChD.Location = new System.Drawing.Point(207, 55);
            this.trackBarChD.Maximum = 8;
            this.trackBarChD.Name = "trackBarChD";
            this.trackBarChD.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarChD.Size = new System.Drawing.Size(45, 214);
            this.trackBarChD.TabIndex = 9;
            this.trackBarChD.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarChD.Scroll += new System.EventHandler(this.trackBarChD_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Channel C";
            // 
            // labelChC
            // 
            this.labelChC.AutoSize = true;
            this.labelChC.Location = new System.Drawing.Point(146, 39);
            this.labelChC.Name = "labelChC";
            this.labelChC.Size = new System.Drawing.Size(46, 13);
            this.labelChC.TabIndex = 7;
            this.labelChC.Text = "000 mV ";
            this.labelChC.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // trackBarChC
            // 
            this.trackBarChC.Location = new System.Drawing.Point(140, 55);
            this.trackBarChC.Maximum = 8;
            this.trackBarChC.Name = "trackBarChC";
            this.trackBarChC.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarChC.Size = new System.Drawing.Size(45, 214);
            this.trackBarChC.TabIndex = 6;
            this.trackBarChC.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarChC.Value = 3;
            this.trackBarChC.Scroll += new System.EventHandler(this.trackBarChC_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Channel B";
            // 
            // labelChB
            // 
            this.labelChB.AutoSize = true;
            this.labelChB.Location = new System.Drawing.Point(78, 39);
            this.labelChB.Name = "labelChB";
            this.labelChB.Size = new System.Drawing.Size(43, 13);
            this.labelChB.TabIndex = 4;
            this.labelChB.Text = "000 mV";
            this.labelChB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // trackBarChB
            // 
            this.trackBarChB.Location = new System.Drawing.Point(72, 55);
            this.trackBarChB.Maximum = 8;
            this.trackBarChB.Name = "trackBarChB";
            this.trackBarChB.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarChB.Size = new System.Drawing.Size(45, 214);
            this.trackBarChB.TabIndex = 3;
            this.trackBarChB.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarChB.Value = 3;
            this.trackBarChB.Scroll += new System.EventHandler(this.trackBarChB_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Channel A";
            // 
            // labelChA
            // 
            this.labelChA.AutoSize = true;
            this.labelChA.Location = new System.Drawing.Point(8, 39);
            this.labelChA.Name = "labelChA";
            this.labelChA.Size = new System.Drawing.Size(43, 13);
            this.labelChA.TabIndex = 1;
            this.labelChA.Text = "000 mV";
            this.labelChA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // trackBarChA
            // 
            this.trackBarChA.Location = new System.Drawing.Point(6, 55);
            this.trackBarChA.Maximum = 8;
            this.trackBarChA.Name = "trackBarChA";
            this.trackBarChA.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarChA.Size = new System.Drawing.Size(45, 214);
            this.trackBarChA.TabIndex = 0;
            this.trackBarChA.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarChA.Value = 3;
            this.trackBarChA.Scroll += new System.EventHandler(this.trackBarChA_Scroll);
            // 
            // FormServeurPicoscope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 275);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "FormServeurPicoscope";
            this.Text = "ServeurPico";
            this.Load += new System.EventHandler(this.FormServeur_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarChD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarChC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarChB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarChA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonImediateBlock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSetPico;
        private System.Windows.Forms.TextBox textBoxSetPeriod;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSampleCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar trackBarChA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelChD;
        private System.Windows.Forms.TrackBar trackBarChD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelChC;
        private System.Windows.Forms.TrackBar trackBarChC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelChB;
        private System.Windows.Forms.TrackBar trackBarChB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelChA;
        private System.Windows.Forms.Label label5;
    }
}

