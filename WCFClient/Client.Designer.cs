namespace WCFClient
{
    partial class FormClient
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
            this.buttonPicoPing = new System.Windows.Forms.Button();
            this.buttonPicoLock = new System.Windows.Forms.Button();
            this.labelFolder = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPicoCaptureBlock = new System.Windows.Forms.Button();
            this.buttonPicoFolder = new System.Windows.Forms.Button();
            this.labelPicoFolder = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.groupBox_PilotageBras = new System.Windows.Forms.GroupBox();
            this.labelPilotageBrasPosY = new System.Windows.Forms.Label();
            this.labelPilotageBrasPosZ = new System.Windows.Forms.Label();
            this.labelPilotageBrasPosX = new System.Windows.Forms.Label();
            this.buttonPilotageBrasGo = new System.Windows.Forms.Button();
            this.labelPilotageBrasNbPos = new System.Windows.Forms.Label();
            this.textBoxPilotageBrasNPos = new System.Windows.Forms.TextBox();
            this.labelPilotageBrasReadFile = new System.Windows.Forms.Label();
            this.buttonPilotageBrasReadFile = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox_PilotageBras.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 390);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(651, 134);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonPicoPing
            // 
            this.buttonPicoPing.Location = new System.Drawing.Point(27, 31);
            this.buttonPicoPing.Name = "buttonPicoPing";
            this.buttonPicoPing.Size = new System.Drawing.Size(124, 23);
            this.buttonPicoPing.TabIndex = 2;
            this.buttonPicoPing.Text = "Check status";
            this.buttonPicoPing.UseVisualStyleBackColor = true;
            this.buttonPicoPing.Click += new System.EventHandler(this.buttonPicoPing_Click);
            // 
            // buttonPicoLock
            // 
            this.buttonPicoLock.Location = new System.Drawing.Point(157, 31);
            this.buttonPicoLock.Name = "buttonPicoLock";
            this.buttonPicoLock.Size = new System.Drawing.Size(128, 23);
            this.buttonPicoLock.TabIndex = 3;
            this.buttonPicoLock.Text = "Lock server";
            this.buttonPicoLock.UseVisualStyleBackColor = true;
            this.buttonPicoLock.Click += new System.EventHandler(this.buttonPicoSetMod_Click_1);
            // 
            // labelFolder
            // 
            this.labelFolder.AutoSize = true;
            this.labelFolder.Location = new System.Drawing.Point(112, 305);
            this.labelFolder.Name = "labelFolder";
            this.labelFolder.Size = new System.Drawing.Size(90, 13);
            this.labelFolder.TabIndex = 5;
            this.labelFolder.Text = "Storage location :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPicoCaptureBlock);
            this.groupBox1.Controls.Add(this.buttonPicoPing);
            this.groupBox1.Controls.Add(this.buttonPicoLock);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1025, 77);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Picoscope";
            // 
            // buttonPicoCaptureBlock
            // 
            this.buttonPicoCaptureBlock.Location = new System.Drawing.Point(291, 31);
            this.buttonPicoCaptureBlock.Name = "buttonPicoCaptureBlock";
            this.buttonPicoCaptureBlock.Size = new System.Drawing.Size(154, 23);
            this.buttonPicoCaptureBlock.TabIndex = 6;
            this.buttonPicoCaptureBlock.Text = "Capture";
            this.buttonPicoCaptureBlock.UseVisualStyleBackColor = true;
            this.buttonPicoCaptureBlock.Click += new System.EventHandler(this.buttonPicoCaptureBlock_Click);
            // 
            // buttonPicoFolder
            // 
            this.buttonPicoFolder.Location = new System.Drawing.Point(31, 300);
            this.buttonPicoFolder.Name = "buttonPicoFolder";
            this.buttonPicoFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonPicoFolder.TabIndex = 8;
            this.buttonPicoFolder.Text = "Change";
            this.buttonPicoFolder.UseVisualStyleBackColor = true;
            this.buttonPicoFolder.Click += new System.EventHandler(this.buttonPicoFolder_Click);
            // 
            // labelPicoFolder
            // 
            this.labelPicoFolder.AutoSize = true;
            this.labelPicoFolder.Location = new System.Drawing.Point(208, 305);
            this.labelPicoFolder.Name = "labelPicoFolder";
            this.labelPicoFolder.Size = new System.Drawing.Size(16, 13);
            this.labelPicoFolder.TabIndex = 7;
            this.labelPicoFolder.Text = "...";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(148, 344);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(137, 23);
            this.button_start.TabIndex = 9;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // groupBox_PilotageBras
            // 
            this.groupBox_PilotageBras.Controls.Add(this.labelPilotageBrasPosY);
            this.groupBox_PilotageBras.Controls.Add(this.labelPilotageBrasPosZ);
            this.groupBox_PilotageBras.Controls.Add(this.labelPilotageBrasPosX);
            this.groupBox_PilotageBras.Controls.Add(this.buttonPilotageBrasGo);
            this.groupBox_PilotageBras.Controls.Add(this.labelPilotageBrasNbPos);
            this.groupBox_PilotageBras.Controls.Add(this.textBoxPilotageBrasNPos);
            this.groupBox_PilotageBras.Controls.Add(this.labelPilotageBrasReadFile);
            this.groupBox_PilotageBras.Controls.Add(this.buttonPilotageBrasReadFile);
            this.groupBox_PilotageBras.Location = new System.Drawing.Point(0, 95);
            this.groupBox_PilotageBras.Name = "groupBox_PilotageBras";
            this.groupBox_PilotageBras.Size = new System.Drawing.Size(1025, 93);
            this.groupBox_PilotageBras.TabIndex = 10;
            this.groupBox_PilotageBras.TabStop = false;
            this.groupBox_PilotageBras.Text = "Pilotage bras";
            // 
            // labelPilotageBrasPosY
            // 
            this.labelPilotageBrasPosY.AutoSize = true;
            this.labelPilotageBrasPosY.Location = new System.Drawing.Point(411, 68);
            this.labelPilotageBrasPosY.Name = "labelPilotageBrasPosY";
            this.labelPilotageBrasPosY.Size = new System.Drawing.Size(23, 13);
            this.labelPilotageBrasPosY.TabIndex = 7;
            this.labelPilotageBrasPosY.Text = "Y =";
            // 
            // labelPilotageBrasPosZ
            // 
            this.labelPilotageBrasPosZ.AutoSize = true;
            this.labelPilotageBrasPosZ.Location = new System.Drawing.Point(509, 68);
            this.labelPilotageBrasPosZ.Name = "labelPilotageBrasPosZ";
            this.labelPilotageBrasPosZ.Size = new System.Drawing.Size(23, 13);
            this.labelPilotageBrasPosZ.TabIndex = 6;
            this.labelPilotageBrasPosZ.Text = "Z =";
            // 
            // labelPilotageBrasPosX
            // 
            this.labelPilotageBrasPosX.AutoSize = true;
            this.labelPilotageBrasPosX.Location = new System.Drawing.Point(323, 68);
            this.labelPilotageBrasPosX.Name = "labelPilotageBrasPosX";
            this.labelPilotageBrasPosX.Size = new System.Drawing.Size(23, 13);
            this.labelPilotageBrasPosX.TabIndex = 5;
            this.labelPilotageBrasPosX.Text = "X =";
            // 
            // buttonPilotageBrasGo
            // 
            this.buttonPilotageBrasGo.Location = new System.Drawing.Point(157, 64);
            this.buttonPilotageBrasGo.Name = "buttonPilotageBrasGo";
            this.buttonPilotageBrasGo.Size = new System.Drawing.Size(75, 23);
            this.buttonPilotageBrasGo.TabIndex = 4;
            this.buttonPilotageBrasGo.Text = "Go";
            this.buttonPilotageBrasGo.UseVisualStyleBackColor = true;
            this.buttonPilotageBrasGo.Click += new System.EventHandler(this.buttonPilotageBrasGo_Click);
            // 
            // labelPilotageBrasNbPos
            // 
            this.labelPilotageBrasNbPos.AutoSize = true;
            this.labelPilotageBrasNbPos.Location = new System.Drawing.Point(77, 69);
            this.labelPilotageBrasNbPos.Name = "labelPilotageBrasNbPos";
            this.labelPilotageBrasNbPos.Size = new System.Drawing.Size(24, 13);
            this.labelPilotageBrasNbPos.TabIndex = 3;
            this.labelPilotageBrasNbPos.Text = "/ ...";
            // 
            // textBoxPilotageBrasNPos
            // 
            this.textBoxPilotageBrasNPos.Location = new System.Drawing.Point(12, 66);
            this.textBoxPilotageBrasNPos.Name = "textBoxPilotageBrasNPos";
            this.textBoxPilotageBrasNPos.Size = new System.Drawing.Size(59, 20);
            this.textBoxPilotageBrasNPos.TabIndex = 2;
            // 
            // labelPilotageBrasReadFile
            // 
            this.labelPilotageBrasReadFile.AutoSize = true;
            this.labelPilotageBrasReadFile.Location = new System.Drawing.Point(108, 25);
            this.labelPilotageBrasReadFile.Name = "labelPilotageBrasReadFile";
            this.labelPilotageBrasReadFile.Size = new System.Drawing.Size(22, 13);
            this.labelPilotageBrasReadFile.TabIndex = 1;
            this.labelPilotageBrasReadFile.Text = "  ...";
            // 
            // buttonPilotageBrasReadFile
            // 
            this.buttonPilotageBrasReadFile.Location = new System.Drawing.Point(13, 20);
            this.buttonPilotageBrasReadFile.Name = "buttonPilotageBrasReadFile";
            this.buttonPilotageBrasReadFile.Size = new System.Drawing.Size(89, 23);
            this.buttonPilotageBrasReadFile.TabIndex = 0;
            this.buttonPilotageBrasReadFile.Text = "Read file";
            this.buttonPilotageBrasReadFile.UseVisualStyleBackColor = true;
            this.buttonPilotageBrasReadFile.Click += new System.EventHandler(this.buttonPilotageBrasReadFile_Click);
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(326, 344);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(151, 23);
            this.button_stop.TabIndex = 11;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 524);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.groupBox_PilotageBras);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.labelPicoFolder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonPicoFolder);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelFolder);
            this.Name = "FormClient";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClient_FormClosed);
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox_PilotageBras.ResumeLayout(false);
            this.groupBox_PilotageBras.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonPicoPing;
        private System.Windows.Forms.Button buttonPicoLock;
        private System.Windows.Forms.Label labelFolder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonPicoCaptureBlock;
        private System.Windows.Forms.Button buttonPicoFolder;
        private System.Windows.Forms.Label labelPicoFolder;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.GroupBox groupBox_PilotageBras;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Label labelPilotageBrasReadFile;
        private System.Windows.Forms.Button buttonPilotageBrasReadFile;
        private System.Windows.Forms.Label labelPilotageBrasNbPos;
        private System.Windows.Forms.TextBox textBoxPilotageBrasNPos;
        private System.Windows.Forms.Label labelPilotageBrasPosY;
        private System.Windows.Forms.Label labelPilotageBrasPosZ;
        private System.Windows.Forms.Label labelPilotageBrasPosX;
        private System.Windows.Forms.Button buttonPilotageBrasGo;
    }
}

