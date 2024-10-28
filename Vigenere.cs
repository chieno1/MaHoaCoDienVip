using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaHoaCoDien
{
    public partial class Vigenere : UserControl
    {
        public Vigenere()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_khoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ban_goc_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void txt_giai_thich_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_ban_goc.Text = string.Empty;
            txt_ban_ma.Text = string.Empty;
            txt_khoa.Text = string.Empty;
            txt_giai_thich.Text = string.Empty;
        }

        private void btn_tao_khoa_Click(object sender, EventArgs e)
        {
            txt_khoa.Text = "chiendz";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_giai_ma_Click(object sender, EventArgs e)
        {
            if (txt_ban_ma.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập bản mã");
                return;
            }
            if (txt_khoa.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập khóa");
                return;
            }

            txt_ban_goc.Text = string.Empty;
            txt_giai_thich.Text = string.Empty;
            string s = txt_ban_ma.Text;
            string k = txt_khoa.Text;
            string temp = "";
            for (int i = 0; i < s.Length; i++)
            {
                temp += Form1.charMap[(Form1.charMap2[s[i]] - Form1.charMap2[k[i % k.Length]] + 97) % 97];
                txt_giai_thich.Text += s[i] + " => " + Form1.charMap[(Form1.charMap2[s[i]] + Form1.charMap2[k[i % k.Length]]) % 97] + " <=> (" + Form1.charMap2[s[i]] + " + 97 -  " + Form1.charMap2[k[i % k.Length]] + ") % 97 = " + (Form1.charMap2[s[i]] + Form1.charMap2[k[i % k.Length]]) % 97 + "\r\n";
            }
            txt_ban_goc.Text = temp;
        }

        private void btn_ma_hoa_Click(object sender, EventArgs e)
        {
            if (txt_ban_goc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập bản gốc");
                return;
            }
            if(txt_khoa.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập khóa");
                return;
            }

            txt_ban_ma.Text = string.Empty;
            txt_giai_thich.Text= string.Empty;
            string s = txt_ban_goc.Text;
            string k = txt_khoa.Text;
            string temp = "";
            for(int i = 0; i < s.Length; i++)
            {
                temp += Form1.charMap[(Form1.charMap2[s[i]] + Form1.charMap2[k[i % k.Length]]) % 97];
                txt_giai_thich.Text += s[i] + " => " + Form1.charMap[(Form1.charMap2[s[i]] + Form1.charMap2[k[i % k.Length]]) % 97] + " <=> (" + Form1.charMap2[s[i]]+ " + " + Form1.charMap2[k[i % k.Length]] + ") % 97 = " + (Form1.charMap2[s[i]] + Form1.charMap2[k[i % k.Length]]) % 97 + "\r\n";
            }
            txt_ban_ma.Text = temp;
        }

        private void txt_ban_ma_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
