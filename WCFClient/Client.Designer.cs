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
            this.buttonPicoGetStatus = new System.Windows.Forms.Button();
            this.textBoxPicoFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPicoCaptureBlock = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 342);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(700, 134);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonPicoPing
            // 
            this.buttonPicoPing.Location = new System.Drawing.Point(27, 31);
            this.buttonPicoPing.Name = "buttonPicoPing";
            this.buttonPicoPing.Size = new System.Drawing.Size(75, 23);
            this.buttonPicoPing.TabIndex = 2;
            this.buttonPicoPing.Text = "Ping";
            this.buttonPicoPing.UseVisualStyleBackColor = true;
            this.buttonPicoPing.Click += new System.EventHandler(this.buttonPicoPing_Click);
            // 
            // buttonPicoGetStatus
            // 
            this.buttonPicoGetStatus.Location = new System.Drawing.Point(108, 31);
            this.buttonPicoGetStatus.Name = "buttonPicoGetStatus";
            this.buttonPicoGetStatus.Size = new System.Drawing.Size(109, 23);
            this.buttonPicoGetStatus.TabIndex = 3;
            this.buttonPicoGetStatus.Text = "Set picoscope";
            this.buttonPicoGetStatus.UseVisualStyleBackColor = true;
            this.buttonPicoGetStatus.Click += new System.EventHandler(this.buttonPicoGetStatus_Click_1);
            // 
            // textBoxPicoFolder
            // 
            this.textBoxPicoFolder.Location = new System.Drawing.Point(79, 78);
            this.textBoxPicoFolder.Name = "textBoxPicoFolder";
            this.textBoxPicoFolder.Size = new System.Drawing.Size(222, 20);
            this.textBoxPicoFolder.TabIndex = 4;
            this.textBoxPicoFolder.Text = "measures";
            this.textBoxPicoFolder.TextChanged += new System.EventHandler(this.textBoxPicoFolder_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Folder :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPicoCaptureBlock);
            this.groupBox1.Controls.Add(this.buttonPicoPing);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxPicoFolder);
            this.groupBox1.Controls.Add(this.buttonPicoGetStatus);
            this.groupBox1.Location = new System.Drawing.Point(0, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 137);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Picoscope";
            // 
            // buttonPicoCaptureBlock
            // 
            this.buttonPicoCaptureBlock.Location = new System.Drawing.Point(226, 31);
            this.buttonPicoCaptureBlock.Name = "buttonPicoCaptureBlock";
            this.buttonPicoCaptureBlock.Size = new System.Drawing.Size(75, 23);
            this.buttonPicoCaptureBlock.TabIndex = 6;
            this.buttonPicoCaptureBlock.Text = "Capture";
            this.buttonPicoCaptureBlock.UseVisualStyleBackColor = true;
            this.buttonPicoCaptureBlock.Click += new System.EventHandler(this.buttonPicoCaptureBlock_Click);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 476);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "FormClient";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClient_FormClosed);
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonPicoPing;
        private System.Windows.Forms.Button buttonPicoGetStatus;
        private System.Windows.Forms.TextBox textBoxPicoFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonPicoCaptureBlock;
    }
}

