
namespace İndirimHesapla2
{
    partial class Form1
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
            this.tbFiyat = new System.Windows.Forms.TextBox();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn25 = new System.Windows.Forms.Button();
            this.btn50 = new System.Windows.Forms.Button();
            this.btn75 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbİndFiyat = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etiket Fiyatı:";
            // 
            // tbFiyat
            // 
            this.tbFiyat.Location = new System.Drawing.Point(294, 69);
            this.tbFiyat.Name = "tbFiyat";
            this.tbFiyat.Size = new System.Drawing.Size(100, 20);
            this.tbFiyat.TabIndex = 1;
            this.tbFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(133, 110);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(83, 59);
            this.btn10.TabIndex = 2;
            this.btn10.Text = "%10 indirim";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btn25
            // 
            this.btn25.Location = new System.Drawing.Point(222, 110);
            this.btn25.Name = "btn25";
            this.btn25.Size = new System.Drawing.Size(83, 59);
            this.btn25.TabIndex = 3;
            this.btn25.Text = "%25 indirim";
            this.btn25.UseVisualStyleBackColor = true;
            this.btn25.Click += new System.EventHandler(this.btn25_Click);
            // 
            // btn50
            // 
            this.btn50.Location = new System.Drawing.Point(311, 110);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(83, 59);
            this.btn50.TabIndex = 4;
            this.btn50.Text = "%50 indirim";
            this.btn50.UseVisualStyleBackColor = true;
            this.btn50.Click += new System.EventHandler(this.btn50_Click);
            // 
            // btn75
            // 
            this.btn75.Location = new System.Drawing.Point(400, 110);
            this.btn75.Name = "btn75";
            this.btn75.Size = new System.Drawing.Size(83, 59);
            this.btn75.TabIndex = 5;
            this.btn75.Text = "%75 indirim";
            this.btn75.UseVisualStyleBackColor = true;
            this.btn75.Click += new System.EventHandler(this.btn75_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "İndirimli Fiyat:";
            // 
            // lbİndFiyat
            // 
            this.lbİndFiyat.AutoSize = true;
            this.lbİndFiyat.Location = new System.Drawing.Point(295, 197);
            this.lbİndFiyat.Name = "lbİndFiyat";
            this.lbİndFiyat.Size = new System.Drawing.Size(35, 13);
            this.lbİndFiyat.TabIndex = 7;
            this.lbİndFiyat.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "TL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbİndFiyat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn75);
            this.Controls.Add(this.btn50);
            this.Controls.Add(this.btn25);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.tbFiyat);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFiyat;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn25;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.Button btn75;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbİndFiyat;
        private System.Windows.Forms.Label label3;
    }
}

