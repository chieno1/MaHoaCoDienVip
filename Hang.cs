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
    public partial class Hang : UserControl
    {
        public Hang()
        {
            InitializeComponent();
        }

        private void btn_ma_hoa_Click(object sender, EventArgs e)
        {
            txt_giai_thich.Text = txt_ban_ma.Text = "";
            string iput = txt_ban_goc.Text;
            string k = txt_khoa.Text;
            string[] keyParts = k.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] keya = new int[keyParts.Length];

            
            for (int i = 0; i < keyParts.Length; i++)
            {
                keya[i] = int.Parse(keyParts[i]);
                txt_giai_thich.Text += keya[i] + "\t";
            }
            txt_giai_thich.Text += "\r\n";
            for(int i = 0; i < iput.Length; i++)
            {
                if(i % keya.Length == keya.Length - 1 )
                {
                    txt_giai_thich.Text += iput[i] +"\r\n" ;
                }
                else
                {
                    txt_giai_thich.Text+= iput[i] + "\t"; 
                }
            }
            // Tạo mảng để lưu trữ kết quả mã hóa cho từng cột
            txt_giai_thich.Text += "\r\n";
            string[] arr = new string[keya.Length];
            for (int i = 0; i < keya.Length; i++)
            {
                arr[i] = ""; // Khởi tạo mỗi phần tử của arr
            }

            // Mã hóa văn bản đầu vào theo thứ tự hàng
            for (int i = 0; i < iput.Length; i++)
            {
                // Sử dụng khóa đã tách để xác định cột
                int columnIndex = keya[i % keya.Length] - 1; // Chỉ số cột (trừ 1 để phù hợp với chỉ số mảng)
                arr[columnIndex] += iput[i]; // Thêm ký tự vào cột tương ứng
                
            }
            for(int i = 0; i < keya.Length; i++)
            {
                txt_giai_thich.Text += $"({i + 1}) : {arr[i]} \r\n";
            }
            // Tạo văn bản mã hóa từ các cột
            for (int i = 0; i < keya.Length; i++)
            {
                txt_ban_ma.Text += arr[i]; // Kết hợp các cột lại với nhau
            }

        }

        private void txt_ban_goc_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void txt_khoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }

        private void btn_tao_khoa_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_giai_ma_Click(object sender, EventArgs e)
        {
            string k= txt_khoa.Text;
            string iput = txt_ban_ma.Text;
            txt_giai_thich.Text = "";
            txt_ban_goc.Text = "";
            string[] nu = k.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int num_col = nu.Length;
            int num_row = (int)Math.Ceiling((double)iput.Length / num_col);
            int[] ax = new int[num_col];
            int[] ax2 = new int[num_col];

            // Ánh xạ cột i sang cột thứ s[i]
            for (int i = 0; i < num_col; i++)
            {
                ax[i] = int.Parse(nu[i]) - 1;
                ax2[ax[i]] = i;
            }

            int[] cnt_k = new int[num_col];
            string[] g_s = new string[num_col];
            for (int i = 0; i < num_col; i++)
            {
                cnt_k[i] = 0;
                g_s[i] = "";
            }

            // Đếm số ký tự cho mỗi cột
            for (int i = 0; i < iput.Length; i++)
            {
                cnt_k[ax[i % num_col]] += 1;
            }

            // Chia văn bản đầu vào cho từng cột
            int st = 0;
            for (int i = 0; i < num_col; i++)
            {
                g_s[i] = iput.Substring(st, cnt_k[i]);
                st += cnt_k[i];
            }

            // Tạo ma trận ký tự với dấu '!'
            char[,] ck = new char[num_row, num_col];
            for (int i = 0; i < num_row; i++)
            {
                for (int d = 0; d < num_col; d++)
                {
                    ck[i, d] = '!';
                }
            }

            // Điền các ký tự vào ma trận theo thứ tự
            for (int i = 0; i < num_row; i++)
            {
                for (int d = 0; d < num_col; d++)
                {
                    if (i < g_s[ax[d]].Length)
                    {
                        ck[i, d] = g_s[ax[d]][i];
                    }
                }
            }
            for(int i =0; i < num_col; i++)
            {
                txt_giai_thich.Text += (ax[i] + 1) + "\t";
            }
            txt_giai_thich.Text += "\r\n";
            // Tạo văn bản mã hóa từ các cột
            for (int i = 0; i < num_row; i++)
            {
                for (int d = 0; d < num_col; d++)
                {
                    if (ck[i, d] != '!')
                    {
                        txt_ban_goc.Text += ck[i, d];
                        if(d == num_col - 1)
                        {
                            txt_giai_thich.Text += ck[i, d] +"\r\n";
                        }
                        else
                        {
                            txt_giai_thich.Text += ck[i, d] + "\t";
                        }
                    }
                }
            }
            txt_giai_thich.Text +="\r\n" + txt_ban_ma.Text + " => " + txt_ban_goc.Text;
        }

        private void txt_giai_thich_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ban_ma_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
