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
    public partial class DonBang : UserControl
    {
        
        public DonBang()
        {
            InitializeComponent();
        }
        Dictionary<char, char> charMap3 = new Dictionary<char, char>();
        Dictionary<char, char> charMap4 = new Dictionary<char, char>();
        private void btn_ma_hoa_Click(object sender, EventArgs e)
        {
            txt_ban_ma.Text = "";
            txt_giai_thich.Text = "";
            charMap3.Clear();
            charMap4.Clear();
            if (txt_ban_goc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập bản gốc");
                return;
            }
            int key = 0;
            string temp = "";
            try
            {
                Boolean[] used = new Boolean[97];
                for (int i = 0; i < used.Length; i++)
                {
                    used[i] = false; // Gán tất cả các phần tử là false
                }
                
                if (txt_khoa.Text.Length == 97)
                {
                    
                    string s1 = txt_khoa.Text;
                    for(int i = 0; i < s1.Length; i++)
                    {
                        if (used[Form1.charMap2[s1[i]]])
                        {
                           MessageBox.Show("Khóa không hợp lệ có kí tự lặp");
                            return;
                        }
                        else
                        {
                            used[Form1.charMap2[s1[i]]] = true;
                            charMap3.Add(Form1.charMap[i], s1[i]);
                            charMap4.Add(s1[i], Form1.charMap[i]);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Khóa không hợp lệ chiều dài khác 97 ");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khóa không hợp lệ có kí tự không năm trong bảng mã ");
                return;
            }

            string s = txt_ban_goc.Text;
            for (int i = 0; i < s.Length; i++)
            {
                temp += charMap3[s[i]];
                txt_giai_thich.Text += s[i] + " => " + charMap3[s[i]] + "\r\n";
            }
            txt_ban_ma.Text += temp;
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
            
            charMap3.Clear();
            charMap4.Clear();
            txt_khoa.Text = string.Empty;
            int j = 0;
            for (int i = 1; i < 97; i++)
            {
                txt_khoa.Text += Form1.charMap[i];
                
            }
            txt_khoa.Text += Form1.charMap[0];
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_giai_ma_Click(object sender, EventArgs e)
        {
            txt_ban_goc.Text = "";
            txt_giai_thich.Text = "";
            charMap3.Clear();
            charMap4.Clear();   
            if (txt_ban_ma.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập bản mã");
                return;
            }
            string temp = "";
            Boolean[] used = new Boolean[97];
            for (int i = 0; i < used.Length; i++)
            {
                used[i] = false; // Gán tất cả các phần tử là false
            }
            try
            {
                if (txt_khoa.Text.Length == 97)
                {

                    string s1 = txt_khoa.Text;
                    
                    for (int i = 0; i < s1.Length; i++)
                    {
                        if (used[Form1.charMap2[s1[i]]])
                        {
                            MessageBox.Show("Khóa không hợp lệ có kí tự lặp");
                            return;
                        }
                        else
                        {
                            
                                charMap3.Add(Form1.charMap[i], s1[i]);
                                charMap4.Add(s1[i], Form1.charMap[i]);
                            
                           
                            
                            used[Form1.charMap2[s1[i]]] = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Khóa không hợp lệ chiều dài khác 97 " );
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khóa không hợp lệ có kí tự không năm trong bảng mã " + ex.Message);
                return;
            }
        
            string s = txt_ban_ma.Text;
            for (int i = 0; i<s.Length; i++)
            {
                temp += charMap4[s[i]];
                txt_giai_thich.Text += s[i] + " => " + charMap4[s[i]] + "\r\n";
            }
            txt_ban_goc.Text += temp;
        }

        private void DonBang_Load(object sender, EventArgs e)
        {

        }

        private void txt_ban_ma_TextChanged_1(object sender, EventArgs e)
        {
            
        }
    }
        
    }

