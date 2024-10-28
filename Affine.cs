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
    public partial class Affine : UserControl
    {
        public Affine()
        {
            InitializeComponent();
        }
        public static int a = 0, b = 0, a_1;
        public static int gcd(int x, int y)
        {
            if (y == 0)
                return x;
            return gcd(y, x % y);
        }
        public static int  moduliv(int n)
        {
            for (int i = 1; i < 97; i++)
                if ((i * n) % 97 == 1)
                    return i;
            return 0;
        }
        private void btn_ma_hoa_Click(object sender, EventArgs e)
        {
            txt_ban_ma.Text = txt_giai_thich.Text = "";
            string s = txt_ban_goc.Text;
            if(s.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập bản rõ");
            }
            try
            {
                string[] ar = txt_khoa.Text.Split(' ');
                a = int.Parse(ar[0]);
                b = int.Parse(ar[1]);
            }catch(Exception ex)
            {
                MessageBox.Show("Khóa không đùng định dạng");
                return;
            }
            if(txt_khoa.Text.Length == 0 || gcd(a, 97) != 1)
            {
                MessageBox.Show("Khóa không hợp lệ");
                return;
            }
            for(int i = 0; i < s.Length; i++) 
            {
                txt_ban_ma.Text += Form1.charMap[((Form1.charMap2[s[i]] * a + b + 97000) % 97)];
                txt_giai_thich.Text += s[i] + " => " + Form1.charMap[((Form1.charMap2[s[i]] * a + b + 97000) % 97)] + " <=> " + $"({Form1.charMap2[s[i]]} * {a} + {b}) % 97 = {((Form1.charMap2[s[i]] * a + b + 97000) % 97)}\r\n";
            }
        }

        private void btn_giai_ma_Click(object sender, EventArgs e)
        {
            txt_ban_goc.Text = txt_giai_thich.Text = "";
            string s = txt_ban_ma.Text;
            if (s.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập bản mã");
            }
            try
            {
                string[] ar = txt_khoa.Text.Split(' ');
                a = int.Parse(ar[0]);
                b = int.Parse(ar[1]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khóa không đùng định dạng");
                return;
            }
            if (txt_khoa.Text.Length == 0 || gcd(a, 97) != 1)
            {
                MessageBox.Show("Khóa không hợp lệ");
                return;
            }
            a_1 = moduliv(a);
            txt_giai_thich.Text += a_1 + "\r\n";
            for (int i = 0; i < s.Length; i++)
            {
                txt_ban_goc.Text += Form1.charMap[((Form1.charMap2[s[i]]  - b + 97000) * a_1 % 97)];
                txt_giai_thich.Text += s[i] + " => " + Form1.charMap[(a_1*(Form1.charMap2[s[i]]  - b + 97000) % 97)] + " <=> " + $"({a_1} *{Form1.charMap2[s[i]]}  - {b}) % 97 = {((Form1.charMap2[s[i]]  - b + 97000) * a_1 % 97)}\r\n";
            }
        }

        private void btn_tao_khoa_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
         
            a = rd.Next(30);
            b = rd.Next(30);
            txt_khoa.Text += a + " " + b;
        }
    }
}
