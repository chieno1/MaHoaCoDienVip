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
    public partial class PlayFair : UserControl
    {
        public static char[,] a = new char[10,10];
        
     
        public PlayFair()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_ban_goc.Text = txt_ban_ma.Text = txt_khoa.Text = txt_giai_thich.Text = "";
        }

        private void btn_tao_khoa_Click(object sender, EventArgs e)
        {
            txt_khoa.Text = "chiendz";
        }

        private void btn_ma_hoa_Click(object sender, EventArgs e)
        {
            
            if (txt_ban_goc.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập bản gốc");
                return;
            }
            if(txt_khoa.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập khóa");
                return;
            }
            txt_ban_ma.Text = "";
            txt_giai_thich.Text = "";
            List<char> numberList = new List<char>();
            string s = txt_khoa.Text;
            for (int i = 0; i < s.Length; i++)
            {
                if(numberList.Contains(s[i]) == false)
                numberList.Add(s[i]);
            }
            
            for (int i = 0; i < numberList.Count; i++)
            {
                a[(int)(i / 10),i % 10] = numberList[i];
            }
            int pos = numberList.Count;
            for(int i = 0;i < 97; i++)
            {
                if (numberList.Contains(Form1.charMap[i]) == false)
                {
                    a[pos / 10, pos % 10] = Form1.charMap[i];
                    numberList.Add(Form1.charMap[i]);
                    pos += 1;
                }
            }
            a[9, 7] = (char)(1);
            a[9, 8] = (char)(2);
            a[9, 9] = (char)(3);
            txt_giai_thich.Text += "Ma trận khóa là :\r\n";
            Dictionary<char,Tuple<int, int>> t = new Dictionary<char,Tuple<int, int>>();
            Dictionary<Tuple<int, int>,char> tn = new Dictionary<Tuple<int, int>, char>();
            for (int i = 0;i < 10; i++)
            {
                for(int j = 0;  j < 10; j++)
                {
                    txt_giai_thich.Text += a[i, j] + " ";
                    Tuple<int,int> tuple = new Tuple<int,int>(i, j);
                    tn.Add(tuple, a[i, j]);
                    t.Add(a[i, j], tuple);
                }
                txt_giai_thich.Text += "\r\n";
            }
            s = txt_ban_goc.Text;
            if (s.Length % 2 == 1)
                s += "X";
            for (int i = 0; i < s.Length; i += 2) 
            {
                char c1 = s[i];
                char c2 = s[i + 1];
                if (c1 == c2)
                    c2 = 'X';
                if (c1 == 'X')
                    c2 = 'Q';
                int i1 = t[c1].Item1, j1 = t[c1].Item2;
                int i2 = t[c2].Item1, j2 = t[c2].Item2;
                txt_giai_thich.Text += "(" + c1 + ", " + c2 + ") => ";
                if(i1 == i2)
                {
                    j1 += 1;
                    j2 += 1;
                    if(j1 > 9)
                    {
                        j1 = 0;
                    }
                    if(j2 > 9)
                    {
                        j2 = 0;
                    }
                    c1 = tn[new Tuple<int, int>(i1, j1)];
                    c2 = c2 = tn[new Tuple<int, int>(i2, j2)];
                    
                    
                }
                else if (j1 == j2) 
                {
                    i1 += 1;
                    i2 += 1;
                    if (i1 > 9)
                    {
                        i1 = 0;
                    }
                    if (i2 > 9)
                    {
                        i2 = 0;
                    }
                    c1 = tn[new Tuple<int, int>(i1, j1)];
                    c2 = tn[new Tuple<int, int>(i2, j2)];
                    
                }
                else
                {
                    c1 = tn[new Tuple<int, int>(i1, j2)];
                    c2 = tn[new Tuple<int, int>(i2, j1)];
                    
                }
                txt_giai_thich.Text += "(" + c1 + ", " + c2 + ") \r\n";
                txt_ban_ma.Text += c1;
                txt_ban_ma.Text += c2;
                
            }

        }

        private void btn_giai_ma_Click(object sender, EventArgs e)
        {
            if (txt_ban_ma.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập bản mã");
                return;
            }
            if(txt_khoa.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập khóa");
                return;
            }
            txt_ban_goc.Text = "";
            txt_giai_thich.Text = "";
            List<char> numberList = new List<char>();
            string s = txt_khoa.Text;
            for (int i = 0; i < s.Length; i++)
            {
                if(numberList.Contains(s[i]) == false)
                numberList.Add(s[i]);
            }
            
            for (int i = 0; i < numberList.Count; i++)
            {
                a[(int)(i / 10),i % 10] = numberList[i];
            }
            int pos = numberList.Count;
            for(int i = 0;i < 97; i++)
            {
                if (numberList.Contains(Form1.charMap[i]) == false)
                {
                    a[pos / 10, pos % 10] = Form1.charMap[i];
                    numberList.Add(Form1.charMap[i]);
                    pos += 1;
                }
            }
            a[9, 7] = (char)(1);
            a[9, 8] = (char)(2);
            a[9, 9] = (char)(3);
            txt_giai_thich.Text += "Ma trận khóa là :\r\n";
            Dictionary<char,Tuple<int, int>> t = new Dictionary<char,Tuple<int, int>>();
            Dictionary<Tuple<int, int>,char> tn = new Dictionary<Tuple<int, int>, char>();
            for (int i = 0;i < 10; i++)
            {
                for(int j = 0;  j < 10; j++)
                {
                    txt_giai_thich.Text += a[i, j] + " ";
                    Tuple<int,int> tuple = new Tuple<int,int>(i, j);
                    tn.Add(tuple, a[i, j]);
                    t.Add(a[i, j], tuple);
                }
                txt_giai_thich.Text += "\r\n";
            }
            txt_giai_thich.Text += "Quá trình giải mã :\r\n";
            s = txt_ban_ma.Text;
            if (s.Length % 2 == 1)
                s += "X";
            for (int i = 0; i < s.Length; i += 2) 
            {
                char c1 = s[i];
                char c2 = s[i + 1];
                if (c1 == c2)
                    c2 = 'X';
                if (c1 == 'X')
                    c2 = 'Q';
                int i1 = t[c1].Item1, j1 = t[c1].Item2;
                int i2 = t[c2].Item1, j2 = t[c2].Item2;
                txt_giai_thich.Text += "(" + c1 + ", " + c2 + ") => ";
                if(i1 == i2)
                {
                    j1 -= 1;
                    j2 -= 1;
                    if(j1 < 0)
                    {
                        j1 = 9;
                    }
                    if(j2 < 0)
                    {
                        j2 = 9;
                    }
                    c1 = tn[new Tuple<int, int>(i1, j1)];
                    c2 = tn[new Tuple<int, int>(i2, j2)];
                }
                else if (j1 == j2) 
                {
                    i1 -= 1;
                    i2 -= 1;
                    if (i1 < 0)
                    {
                        i1 = 9;
                    }
                    if (i2 < 0)
                    {
                        i2 = 9;
                    }
                    c1 = tn[new Tuple<int, int>(i1, j1)];
                    c2 = tn[new Tuple<int, int>(i2, j2)];
                    
                }
                else
                {
                    c1 = tn[new Tuple<int, int>(i1, j2)];
                    c2 = tn[new Tuple<int, int>(i2, j1)];
                    
                }
                txt_giai_thich.Text += "(" + c1 + ", " + c2 + ") \r\n";
                txt_ban_goc.Text += c1;
                txt_ban_goc.Text += c2;
                
            }

        
        }
    }
}
