namespace MaHoaCoDien
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
            this.btn_ceasar = new System.Windows.Forms.Button();
            this.btn_don_bang = new System.Windows.Forms.Button();
            this.btn_vigenere = new System.Windows.Forms.Button();
            this.btn_playfair = new System.Windows.Forms.Button();
            this.btn_hill = new System.Windows.Forms.Button();
            this.btn_affine = new System.Windows.Forms.Button();
            this.btn_hang = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ceasar
            // 
            this.btn_ceasar.Location = new System.Drawing.Point(12, 12);
            this.btn_ceasar.Name = "btn_ceasar";
            this.btn_ceasar.Size = new System.Drawing.Size(75, 40);
            this.btn_ceasar.TabIndex = 1;
            this.btn_ceasar.Text = "Ceasar";
            this.btn_ceasar.UseVisualStyleBackColor = true;
            this.btn_ceasar.Click += new System.EventHandler(this.btn_ceasar_Click);
            // 
            // btn_don_bang
            // 
            this.btn_don_bang.Location = new System.Drawing.Point(93, 12);
            this.btn_don_bang.Name = "btn_don_bang";
            this.btn_don_bang.Size = new System.Drawing.Size(84, 40);
            this.btn_don_bang.TabIndex = 2;
            this.btn_don_bang.Text = "Đơn bảng";
            this.btn_don_bang.UseVisualStyleBackColor = true;
            this.btn_don_bang.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_vigenere
            // 
            this.btn_vigenere.Location = new System.Drawing.Point(187, 12);
            this.btn_vigenere.Name = "btn_vigenere";
            this.btn_vigenere.Size = new System.Drawing.Size(87, 40);
            this.btn_vigenere.TabIndex = 3;
            this.btn_vigenere.Text = "Vigenere";
            this.btn_vigenere.UseVisualStyleBackColor = true;
            this.btn_vigenere.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_playfair
            // 
            this.btn_playfair.Location = new System.Drawing.Point(280, 12);
            this.btn_playfair.Name = "btn_playfair";
            this.btn_playfair.Size = new System.Drawing.Size(75, 40);
            this.btn_playfair.TabIndex = 4;
            this.btn_playfair.Text = "Playfair";
            this.btn_playfair.UseVisualStyleBackColor = true;
            this.btn_playfair.Click += new System.EventHandler(this.btn_playfair_Click_1);
            // 
            // btn_hill
            // 
            this.btn_hill.Location = new System.Drawing.Point(361, 12);
            this.btn_hill.Name = "btn_hill";
            this.btn_hill.Size = new System.Drawing.Size(75, 40);
            this.btn_hill.TabIndex = 5;
            this.btn_hill.Text = "Hill";
            this.btn_hill.UseVisualStyleBackColor = true;
            this.btn_hill.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_affine
            // 
            this.btn_affine.Location = new System.Drawing.Point(452, 12);
            this.btn_affine.Name = "btn_affine";
            this.btn_affine.Size = new System.Drawing.Size(75, 40);
            this.btn_affine.TabIndex = 6;
            this.btn_affine.Text = "Affine";
            this.btn_affine.UseVisualStyleBackColor = true;
            this.btn_affine.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_hang
            // 
            this.btn_hang.Location = new System.Drawing.Point(534, 12);
            this.btn_hang.Name = "btn_hang";
            this.btn_hang.Size = new System.Drawing.Size(75, 40);
            this.btn_hang.TabIndex = 7;
            this.btn_hang.Text = "Hàng";
            this.btn_hang.UseVisualStyleBackColor = true;
            this.btn_hang.Click += new System.EventHandler(this.btn_hang_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_affine);
            this.panel1.Controls.Add(this.btn_hang);
            this.panel1.Controls.Add(this.btn_ceasar);
            this.panel1.Controls.Add(this.btn_don_bang);
            this.panel1.Controls.Add(this.btn_hill);
            this.panel1.Controls.Add(this.btn_vigenere);
            this.panel1.Controls.Add(this.btn_playfair);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 57);
            this.panel1.TabIndex = 8;
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 57);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(730, 686);
            this.pnlMain.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 743);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Mã hóa cổ điển code by Chiến dz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_ceasar;
        private System.Windows.Forms.Button btn_don_bang;
        private System.Windows.Forms.Button btn_vigenere;
        private System.Windows.Forms.Button btn_playfair;
        private System.Windows.Forms.Button btn_hill;
        private System.Windows.Forms.Button btn_affine;
        private System.Windows.Forms.Button btn_hang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMain;
    }
}

