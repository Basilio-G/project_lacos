namespace project_lacos
{
    partial class FRMtabuada
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTcalc = new System.Windows.Forms.Button();
            this.TXnum = new System.Windows.Forms.TextBox();
            this.LBOXresult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabuada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número";
            // 
            // BTcalc
            // 
            this.BTcalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTcalc.Location = new System.Drawing.Point(284, 94);
            this.BTcalc.Name = "BTcalc";
            this.BTcalc.Size = new System.Drawing.Size(157, 40);
            this.BTcalc.TabIndex = 2;
            this.BTcalc.Text = "Descobrir";
            this.BTcalc.UseVisualStyleBackColor = true;
            this.BTcalc.Click += new System.EventHandler(this.BTcalc_Click);
            // 
            // TXnum
            // 
            this.TXnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXnum.Location = new System.Drawing.Point(110, 94);
            this.TXnum.Name = "TXnum";
            this.TXnum.Size = new System.Drawing.Size(156, 40);
            this.TXnum.TabIndex = 3;
            this.TXnum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXnum_KeyDown);
            // 
            // LBOXresult
            // 
            this.LBOXresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBOXresult.FormattingEnabled = true;
            this.LBOXresult.ItemHeight = 20;
            this.LBOXresult.Location = new System.Drawing.Point(109, 154);
            this.LBOXresult.Name = "LBOXresult";
            this.LBOXresult.Size = new System.Drawing.Size(190, 284);
            this.LBOXresult.TabIndex = 4;
            // 
            // FRMtabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.LBOXresult);
            this.Controls.Add(this.TXnum);
            this.Controls.Add(this.BTcalc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRMtabuada";
            this.Text = "FRMtabuada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTcalc;
        private System.Windows.Forms.TextBox TXnum;
        private System.Windows.Forms.ListBox LBOXresult;
    }
}