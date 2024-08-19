namespace project_lacos
{
    partial class FRMcontador20
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTwhile = new System.Windows.Forms.Button();
            this.LBOXnum = new System.Windows.Forms.ListBox();
            this.BTdowhile = new System.Windows.Forms.Button();
            this.BTfor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contador até 20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista:";
            // 
            // BTwhile
            // 
            this.BTwhile.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTwhile.Location = new System.Drawing.Point(12, 397);
            this.BTwhile.Name = "BTwhile";
            this.BTwhile.Size = new System.Drawing.Size(119, 41);
            this.BTwhile.TabIndex = 3;
            this.BTwhile.Text = "While";
            this.BTwhile.UseVisualStyleBackColor = true;
            this.BTwhile.Click += new System.EventHandler(this.BTwhile_Click);
            // 
            // LBOXnum
            // 
            this.LBOXnum.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LBOXnum.FormattingEnabled = true;
            this.LBOXnum.Location = new System.Drawing.Point(137, 80);
            this.LBOXnum.Name = "LBOXnum";
            this.LBOXnum.Size = new System.Drawing.Size(189, 303);
            this.LBOXnum.TabIndex = 4;
            // 
            // BTdowhile
            // 
            this.BTdowhile.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTdowhile.Location = new System.Drawing.Point(137, 397);
            this.BTdowhile.Name = "BTdowhile";
            this.BTdowhile.Size = new System.Drawing.Size(117, 41);
            this.BTdowhile.TabIndex = 3;
            this.BTdowhile.Text = "Do while";
            this.BTdowhile.UseVisualStyleBackColor = true;
            this.BTdowhile.Click += new System.EventHandler(this.BTdowhile_Click);
            // 
            // BTfor
            // 
            this.BTfor.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTfor.Location = new System.Drawing.Point(260, 397);
            this.BTfor.Name = "BTfor";
            this.BTfor.Size = new System.Drawing.Size(117, 41);
            this.BTfor.TabIndex = 3;
            this.BTfor.Text = "For";
            this.BTfor.UseVisualStyleBackColor = true;
            this.BTfor.Click += new System.EventHandler(this.BTfor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this.LBOXnum);
            this.Controls.Add(this.BTfor);
            this.Controls.Add(this.BTdowhile);
            this.Controls.Add(this.BTwhile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTwhile;
        private System.Windows.Forms.ListBox LBOXnum;
        private System.Windows.Forms.Button BTdowhile;
        private System.Windows.Forms.Button BTfor;
    }
}

