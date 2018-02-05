namespace TextFileToRegSz
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxSchlüsselname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxZeichenfolge = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnDatei = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSchlüsselname
            // 
            this.textBoxSchlüsselname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSchlüsselname.Location = new System.Drawing.Point(12, 29);
            this.textBoxSchlüsselname.Name = "textBoxSchlüsselname";
            this.textBoxSchlüsselname.Size = new System.Drawing.Size(425, 20);
            this.textBoxSchlüsselname.TabIndex = 0;
            this.textBoxSchlüsselname.TextChanged += new System.EventHandler(this.textBoxSchlüsselname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Schlüsselnamen über Rechte Maustaste kopieren und hier einfügen...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name Zeichenfolge (REG_SZ)";
            // 
            // textBoxZeichenfolge
            // 
            this.textBoxZeichenfolge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxZeichenfolge.Location = new System.Drawing.Point(171, 81);
            this.textBoxZeichenfolge.Name = "textBoxZeichenfolge";
            this.textBoxZeichenfolge.Size = new System.Drawing.Size(266, 20);
            this.textBoxZeichenfolge.TabIndex = 3;
            this.textBoxZeichenfolge.TextChanged += new System.EventHandler(this.textBoxZeichenfolge_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDatei
            // 
            this.btnDatei.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDatei.Location = new System.Drawing.Point(13, 156);
            this.btnDatei.Name = "btnDatei";
            this.btnDatei.Size = new System.Drawing.Size(166, 23);
            this.btnDatei.TabIndex = 4;
            this.btnDatei.Text = "strDatei";
            this.btnDatei.UseVisualStyleBackColor = true;
            this.btnDatei.Click += new System.EventHandler(this.btnDatei_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(219, 156);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(218, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "strOk";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 191);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnDatei);
            this.Controls.Add(this.textBoxZeichenfolge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSchlüsselname);
            this.MinimumSize = new System.Drawing.Size(460, 230);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "TextFileToRegSz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSchlüsselname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxZeichenfolge;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnDatei;
        private System.Windows.Forms.Button btnOk;
    }
}

