namespace KelimeBulmaca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            con.Close();
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHarfler = new System.Windows.Forms.TextBox();
            this.lstKelimeler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(266, 19);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(94, 29);
            this.btnAra.TabIndex = 0;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "HARFLER";
            // 
            // txtHarfler
            // 
            this.txtHarfler.Location = new System.Drawing.Point(99, 20);
            this.txtHarfler.Name = "txtHarfler";
            this.txtHarfler.Size = new System.Drawing.Size(161, 27);
            this.txtHarfler.TabIndex = 2;
            // 
            // lstKelimeler
            // 
            this.lstKelimeler.FormattingEnabled = true;
            this.lstKelimeler.ItemHeight = 20;
            this.lstKelimeler.Location = new System.Drawing.Point(23, 67);
            this.lstKelimeler.Name = "lstKelimeler";
            this.lstKelimeler.Size = new System.Drawing.Size(337, 344);
            this.lstKelimeler.TabIndex = 3;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAra;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 422);
            this.Controls.Add(this.lstKelimeler);
            this.Controls.Add(this.txtHarfler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAra);
            this.Name = "Form1";
            this.Text = "Kelime Bulmaca ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAra;
        private Label label1;
        private TextBox txtHarfler;
        private ListBox lstKelimeler;
    }
}