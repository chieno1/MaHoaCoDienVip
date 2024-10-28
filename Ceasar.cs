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
    public partial class Ceasar : UserControl
    {
        public Ceasar()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ceasar_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        public  void btn_ma_hoa_Click(object sender, EventArgs e)
        {
            txt_ban_ma.Text = "";
            txt_giai_thich.Text = "";
            if(txt_ban_goc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập bản gốc");
                return;
            }
            int key;
            string temp = "";
            try
            {
                key = int.Parse(txt_khoa.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khóa không hợp lệ");
                return;
            }
            
            string s = txt_ban_goc.Text;
            for (int i = 0; i < txt_ban_goc.Text.Length; i++) 
            {
     
                temp += Form1.charMap[ (Form1.charMap2[s[i]] + key) % 97];
                txt_giai_thich.Text += s[i] + " => " + Form1.charMap[(Form1.charMap2[s[i]] + key) % 97] + " <=> (" + Form1.charMap2[s[i]] + " + " + key + ") % 97 = " + ((Form1.charMap2[s[i]] + key) % 97) + "\r\n";
            }
            txt_ban_ma.Text += temp;
        }

        public void btn_tao_khoa_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            txt_khoa.Text = rd.Next(0,97)+"";
        }

        public void btn_clear_Click(object sender, EventArgs e)
        {
            txt_ban_goc.Text = txt_ban_ma.Text = txt_khoa.Text = txt_giai_thich.Text = "";
        }

        public void btn_giai_ma_Click(object sender, EventArgs e)
        {
            txt_ban_goc.Text = "";
            txt_giai_thich.Text = "";
            if (txt_ban_ma.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập bản mã");
                return;
            }
            int key;
            string temp = "";
            try
            {
                key = int.Parse(txt_khoa.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khóa không hợp lệ");
                return;
            }

            string s = txt_ban_ma.Text;
            for (int i = 0; i < s.Length; i++)
            {

                temp += Form1.charMap[(Form1.charMap2[s[i]] - key + 97) % 97];
                txt_giai_thich.Text += s[i] + " => " + Form1.charMap[(Form1.charMap2[s[i]] - key + 97) % 97] + " <=> (" + Form1.charMap2[s[i]] + " + 97 - " + key + ") % 97 = " + ((Form1.charMap2[s[i]] - key) % 97) + "\r\n";
            }
            txt_ban_goc.Text += temp;
        }

        private void txt_giai_thich_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
