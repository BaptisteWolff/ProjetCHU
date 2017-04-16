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
            this.textBoxPing = new System.Windows.Forms.TextBox();
            this.buttonPing = new System.Windows.Forms.Button();
            this.buttonPicoCommand = new System.Windows.Forms.Button();
            this.textBoxPicoCommand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 139);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(455, 134);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBoxPing
            // 
            this.textBoxPing.Location = new System.Drawing.Point(11, 9);
            this.textBoxPing.Name = "textBoxPing";
            this.textBoxPing.Size = new System.Drawing.Size(100, 20);
            this.textBoxPing.TabIndex = 1;
            this.textBoxPing.Text = "Pico";
            this.textBoxPing.TextChanged += new System.EventHandler(this.textBoxPing_TextChanged);
            // 
            // buttonPing
            // 
            this.buttonPing.Location = new System.Drawing.Point(151, 6);
            this.buttonPing.Name = "buttonPing";
            this.buttonPing.Size = new System.Drawing.Size(75, 23);
            this.buttonPing.TabIndex = 2;
            this.buttonPing.Text = "Ping";
            this.buttonPing.UseVisualStyleBackColor = true;
            this.buttonPing.Click += new System.EventHandler(this.buttonPing_Click);
            // 
            // buttonPicoCommand
            // 
            this.buttonPicoCommand.Location = new System.Drawing.Point(304, 51);
            this.buttonPicoCommand.Name = "buttonPicoCommand";
            this.buttonPicoCommand.Size = new System.Drawing.Size(139, 23);
            this.buttonPicoCommand.TabIndex = 3;
            this.buttonPicoCommand.Text = "Send pico capture signal";
            this.buttonPicoCommand.UseVisualStyleBackColor = true;
            this.buttonPicoCommand.Click += new System.EventHandler(this.buttonPicoCommand_Click_1);
            // 
            // textBoxPicoCommand
            // 
            this.textBoxPicoCommand.Location = new System.Drawing.Point(76, 53);
            this.textBoxPicoCommand.Name = "textBoxPicoCommand";
            this.textBoxPicoCommand.Size = new System.Drawing.Size(222, 20);
            this.textBoxPicoCommand.TabIndex = 4;
            this.textBoxPicoCommand.Text = "block.csv";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "File name :";
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 273);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPicoCommand);
            this.Controls.Add(this.buttonPicoCommand);
            this.Controls.Add(this.buttonPing);
            this.Controls.Add(this.textBoxPing);
            this.Controls.Add(this.listBox1);
            this.Name = "FormClient";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClient_FormClosed);
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxPing;
        private System.Windows.Forms.Button buttonPing;
        private System.Windows.Forms.Button buttonPicoCommand;
        private System.Windows.Forms.TextBox textBoxPicoCommand;
        private System.Windows.Forms.Label label1;
    }
}

