namespace MaHoaCoDien
{
    partial class Hang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt_khoa = new System.Windows.Forms.TextBox();
            this.txt_ban_goc = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_giai_thich = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_tao_khoa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_giai_ma = new System.Windows.Forms.Button();
            this.btn_ma_hoa = new System.Windows.Forms.Button();
            this.txt_ban_ma = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_khoa
            // 
            this.txt_khoa.Location = new System.Drawing.Point(227, 154);
            this.txt_khoa.Name = "txt_khoa";
            this.txt_khoa.Size = new System.Drawing.Size(457, 22);
            this.txt_khoa.TabIndex = 31;
            this.txt_khoa.TextChanged += new System.EventHandler(this.txt_khoa_TextChanged);
            // 
            // txt_ban_goc
            // 
            this.txt_ban_goc.Location = new System.Drawing.Point(227, 85);
            this.txt_ban_goc.Name = "txt_ban_goc";
            this.txt_ban_goc.Size = new System.Drawing.Size(457, 22);
            this.txt_ban_goc.TabIndex = 30;
            this.txt_ban_goc.TextChanged += new System.EventHandler(this.txt_ban_goc_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // txt_giai_thich
            // 
            this.txt_giai_thich.Location = new System.Drawing.Point(49, 401);
            this.txt_giai_thich.Multiline = true;
            this.txt_giai_thich.Name = "txt_giai_thich";
            this.txt_giai_thich.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_giai_thich.Size = new System.Drawing.Size(635, 296);
            this.txt_giai_thich.TabIndex = 40;
            this.txt_giai_thich.TextChanged += new System.EventHandler(this.txt_giai_thich_TextChanged);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(226, 358);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(126, 23);
            this.btn_clear.TabIndex = 39;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_tao_khoa
            // 
            this.btn_tao_khoa.Location = new System.Drawing.Point(512, 302);
            this.btn_tao_khoa.Name = "btn_tao_khoa";
            this.btn_tao_khoa.Size = new System.Drawing.Size(126, 23);
            this.btn_tao_khoa.TabIndex = 38;
            this.btn_tao_khoa.Text = "Sinh khóa";
            this.btn_tao_khoa.UseVisualStyleBackColor = true;
            this.btn_tao_khoa.Click += new System.EventHandler(this.btn_tao_khoa_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(89, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 35;
            this.label3.Text = "Bản mã";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(89, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 36;
            this.label2.Text = "Khóa ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(89, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 37;
            this.label1.Text = "Bản gốc";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_giai_ma
            // 
            this.btn_giai_ma.Location = new System.Drawing.Point(370, 302);
            this.btn_giai_ma.Name = "btn_giai_ma";
            this.btn_giai_ma.Size = new System.Drawing.Size(126, 23);
            this.btn_giai_ma.TabIndex = 33;
            this.btn_giai_ma.Text = "Giải mã";
            this.btn_giai_ma.UseVisualStyleBackColor = true;
            this.btn_giai_ma.Click += new System.EventHandler(this.btn_giai_ma_Click);
            // 
            // btn_ma_hoa
            // 
            this.btn_ma_hoa.Location = new System.Drawing.Point(226, 302);
            this.btn_ma_hoa.Name = "btn_ma_hoa";
            this.btn_ma_hoa.Size = new System.Drawing.Size(126, 23);
            this.btn_ma_hoa.TabIndex = 34;
            this.btn_ma_hoa.Text = "Mã hóa";
            this.btn_ma_hoa.UseVisualStyleBackColor = true;
            this.btn_ma_hoa.Click += new System.EventHandler(this.btn_ma_hoa_Click);
            // 
            // txt_ban_ma
            // 
            this.txt_ban_ma.Location = new System.Drawing.Point(227, 230);
            this.txt_ban_ma.Name = "txt_ban_ma";
            this.txt_ban_ma.Size = new System.Drawing.Size(457, 22);
            this.txt_ban_ma.TabIndex = 32;
            this.txt_ban_ma.TextChanged += new System.EventHandler(this.txt_ban_ma_TextChanged);
            // 
            // Hang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_khoa);
            this.Controls.Add(this.txt_ban_goc);
            this.Controls.Add(this.txt_giai_thich);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_tao_khoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_giai_ma);
            this.Controls.Add(this.btn_ma_hoa);
            this.Controls.Add(this.txt_ban_ma);
            this.Name = "Hang";
            this.Size = new System.Drawing.Size(733, 782);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_khoa;
        private System.Windows.Forms.TextBox txt_ban_goc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_giai_thich;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_tao_khoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_giai_ma;
        private System.Windows.Forms.Button btn_ma_hoa;
        private System.Windows.Forms.TextBox txt_ban_ma;
    }
}
