using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaHoaCoDien
{
    public partial class Hill : UserControl
    {

        public Hill()
        {
            InitializeComponent();
        }
        public static int sizemat;
        public static int[,] a = new int[11, 11];
        public static int[,] b = new int[11, 11];
        public static int mk = 0;
        private void Hill_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public static int gcd(int x, int y)  {
            if(y == 0)
            return x;
            return gcd(y, x % y);
}
        private void txt_ban_ma_TextChanged(object sender, EventArgs e)
        {

        }
        public static int ModInverse(int n)
        {
            for (int i = 1; i < 97; i++)
            {
                if ((i * n) % 97 == 1)
                {
                    return i; // Trả về nghịch đảo nếu tìm thấy
                }
            }
            return -1; // Trả về -1 nếu không tìm thấy nghịch đảo
        }

        public static int[,] sinhMat(string s) 
        {
            int[,] mat = new int[1, s.Length];
            for(int i = 0; i < s.Length; i++)
            {
                mat[0, i] = Form1.charMap2[s[i]];
            }
            return mat;
        }
        public static int[,] Mulmk(int[,] matrixA)
        {
            int[, ] Mnew = new int[matrixA.GetLength(0), matrixA.GetLength(1)];
            for(int i = 0; i < matrixA.GetLength(0); i++)
            {
                for(int j = 0; j < matrixA.GetLength(1); j++)
                    Mnew[i, j] = (matrixA[i, j] * mk + 970000) % 97;
            }
            return Mnew;
        }

        public static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
        {
            int rowsA = matrixA.GetLength(0);
            int colsA = matrixA.GetLength(1);
            int rowsB = matrixB.GetLength(0);
            int colsB = matrixB.GetLength(1);

            // Kiểm tra điều kiện nhân ma trận
            if (colsA != rowsB)
            {
                throw new InvalidOperationException("Số cột của ma trận A phải bằng số hàng của ma trận B.");
            }

            // Tạo mảng kết quả với kích thước phù hợp
            int[,] result = new int[rowsA, colsB];

            // Thực hiện phép nhân ma trận
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        result[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            return result;
        }


        private void btn_tao_khoa_Click(object sender, EventArgs e)
        {
            txt_khoa.Text = "";
            try
            {
                sizemat = int.Parse(txt_size_mat.Text);
                if (sizemat <= 1)
                {
                    MessageBox.Show("Khóa phải lớn hơn 1");
                    return;
                }
                if (sizemat > 10)
                {
                    MessageBox.Show("Chỉ hỗ trợ khóa <= 10");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khóa bạn nhập không hợp lệ");
                return;
            }
            Random rd = new Random();
            for (int i = 0; i < sizemat; i++)
            {
                for (int j = 0; j < sizemat; j++)
                {
                    a[i, j] = rd.Next(10);
                    txt_khoa.Text += a[i, j] + " ";
                }
                txt_khoa.Text += "\r\n";
            }
        }


        
            // Phương thức tính định thức của ma trận bằng phương pháp khai triển Laplace
            public static int Determinant(int[,] matrix)
            {
                int n = matrix.GetLength(0);
                if (n == 1)
                {
                    return (matrix[0, 0] + 97 * 1000) % 97;
                }
                else if (n == 2)
                {
                    return (matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0] + 97 * 1000) % 97;
                }
                else
                {
                    int det = 0;
                    for (int j = 0; j < n; j++)
                    {
                        det += (int)Math.Pow(-1, j) * matrix[0, j] * Determinant(Minor(matrix, 0, j));
                    }
                    return (det + 97 * 1000) % 97;
                }
            }

            // Phương thức tạo ma trận con bằng cách loại bỏ dòng và cột
            private static int[,] Minor(int[,] matrix, int row, int col)
            {
                int n = matrix.GetLength(0);
                int[,] minor = new int[n - 1, n - 1];
                int mRow = 0, mCol;

                for (int i = 0; i < n; i++)
                {
                    if (i == row) continue;
                    mCol = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (j == col) continue;
                        minor[mRow, mCol] = matrix[i, j];
                        mCol++;
                    }
                    mRow++;
                }

                return minor;
            }
        public static int[,] ParseMatrixToInt(string input)
        {
            // Tách chuỗi đầu vào thành các dòng (các dòng được phân cách bằng '\n')
            string[] rows = input.Trim().Split('\n');

            // Số hàng và số cột của ma trận
            int rowCount = rows.Length;
            int colCount = rows[0].Trim().Split(' ').Length;

            // Khởi tạo mảng 2 chiều kiểu int để lưu ma trận
            int[,] matrix = new int[rowCount, colCount];

            // Duyệt từng dòng và từng phần tử trong dòng để chuyển thành số nguyên
            for (int i = 0; i < rowCount; i++)
            {
                string[] elements = rows[i].Trim().Split(' '); // Tách các phần tử trong dòng bằng khoảng trắng

                for (int j = 0; j < colCount; j++)
                {
                    matrix[i, j] = int.Parse(elements[j]); // Chuyển chuỗi thành số nguyên và gán vào mảng
                }
            }

            return matrix;
        }


        private static int[,] AdjugateMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int[,] cofactors = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Tính phần tử phụ đại số
                    cofactors[i, j] = (int)Math.Pow(-1, i + j) * Determinant(Minor(matrix, i, j));
                }
            }

            // Chuyển vị ma trận phụ hợp để có ma trận kề (adjugate matrix)
            return Transpose(cofactors);
        }

        // Hàm chuyển vị ma trận
        private static int[,] Transpose(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int[,] transpose = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    transpose[j, i] = matrix[i, j];
                }
            }

            return transpose;
        }


        private void btn_giai_ma_Click(object sender, EventArgs e)
        {
            txt_ban_goc.Text = txt_giai_thich.Text=string.Empty;
            a = ParseMatrixToInt(txt_khoa.Text);
            
            if (Determinant(a) % 97 == 0  )
            {
                MessageBox.Show("Ma trận khóa không hợp lệ vì det k % 97 = 0" );
                return;
            }
            if (gcd(Determinant(a), 97) != 1)
            {
                MessageBox.Show("Ma trận khóa không hợp lệ vì không tồn tại detK(k)^-1 voi det k =" + Determinant(a));
                return;
            }   // ) ;
            
            mk = ModInverse(Determinant(a));
            b = AdjugateMatrix(a);
            b = Mulmk(b);
        
            string s1= txt_ban_ma.Text;

            sizemat = b.GetLength(0);
            txt_size_mat.Text = sizemat +"";
            if(s1.Length < sizemat)
            {
                MessageBox.Show("Bản mã không hợp lệ vì số kí tự nhỏ hơn k");
                return;
            }
            for (int i = 0; i + sizemat <= s1.Length; i += sizemat)
            {
                int[,] matA = sinhMat(s1.Substring(i, sizemat));
                int[,] mul = MultiplyMatrices(matA, b);
                txt_giai_thich.Text += $"Giải mã khối thứ {i / sizemat}" + "\r\n";
                txt_giai_thich.Text += "[";
                for (int j = 0; j < sizemat; j++)
                {
                    txt_giai_thich.Text += matA[0, j] + ", ";
                }
                txt_giai_thich.Text += "]  *  [";
                for (int j = 0; j < sizemat; j++)
                {
                    for (int k = 0; k < sizemat; k++)
                    {
                        if (k == 0)
                        {
                            txt_giai_thich.Text += "[" + b[j, k] + ", ";
                        }
                        else if (k != sizemat - 1)
                        {
                            txt_giai_thich.Text += b[j, k] + ", ";
                        }
                        else if (k == sizemat - 1)
                        {
                            txt_giai_thich.Text += b[j, k] + "], ";
                        }

                    }
                }
                txt_giai_thich.Text += "]  = [";
                for (int j = 0; j < sizemat; j++)
                {
                    if (j != sizemat - 1)
                        txt_giai_thich.Text += ((mul[0, j] + 97 * 1000) % 97) + ", ";
                    else
                        txt_giai_thich.Text += ((mul[0, j] + 97 * 1000) % 97) + "]\r\n";
                }

                for (int k = 0; k < sizemat; k++)
                {
                    txt_ban_goc.Text += Form1.charMap[(mul[0, k]+ 97 * 1000 )% 97];
                }
                txt_giai_thich.Text += s1.Substring(i, sizemat) + "==>";
                txt_giai_thich.Text += txt_ban_goc.Text.Substring(txt_ban_goc.Text.Length - sizemat, sizemat) + "\r\n";

            }
            if (s1.Length % sizemat != 0)
            {
                int du = s1.Length % sizemat;
                txt_giai_thich.Text += "Xâu " + s1.Substring(s1.Length - du, du) + "Thừa hạ xuống\r\n";
                txt_ban_goc.Text += s1.Substring(s1.Length - du, du);
            }

        }

        private void btn_ma_hoa_Click(object sender, EventArgs e)
        {

            txt_ban_ma.Text = txt_giai_thich.Text="";
            try
            {
                a = ParseMatrixToInt(txt_khoa.Text);
                sizemat = a.GetLength(0);
                txt_size_mat.Text = sizemat + "";
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Khóa không hợp lệ");
                return;
            }
            if (Determinant(a) % 97 == 0 || Determinant(a) == 0)
            {
                MessageBox.Show("Ma trận khóa không hợp lệ");
                return;
            }
            if (Determinant(a) % 97 == 0)
            {
                MessageBox.Show("Ma trận khóa không hợp lệ vì det k % 97 = 0");
                return;
            }
            if (gcd(Determinant(a), 97) != 1)
            {
                MessageBox.Show("Ma trận khóa không hợp lệ vì không tồn tại detK(k)^-1 voi det k =" + Determinant(a));
                return;
            }
            string s = txt_ban_goc.Text;
            while (s.Length < sizemat) 
            {
                s += "X";
                txt_ban_goc.Text += "X";
            }
            for (int i = 0; i + sizemat <= s.Length; i+= sizemat) 
            {
                int[,] matA = sinhMat(s.Substring(i, sizemat));
                int[,] mul = MultiplyMatrices(matA, a);
                txt_giai_thich.Text += $"Mã hóa khối thứ {i / sizemat}" + "\r\n";
                txt_giai_thich.Text += "[";
                for(int j = 0; j < sizemat; j++)
                {
                    txt_giai_thich.Text += matA[0, j] + ", ";
                }
                txt_giai_thich.Text += "]  *  [";
                for(int j = 0; j < sizemat; j++)
                {
                    for(int k = 0; k < sizemat; k++)
                    {
                        if(k == 0)
                        {
                            txt_giai_thich.Text += "[" + a[j, k] +", ";
                        }else if(k != sizemat - 1)
                        {
                            txt_giai_thich.Text += a[j, k] + ", ";
                        }else if(k == sizemat - 1)
                        {
                            txt_giai_thich.Text += a[j, k] + "], ";
                        }
                        
                    }
                }
                txt_giai_thich.Text += "]  = [";
                for(int j=0; j < sizemat; j++)
                {
                    if(j != sizemat - 1)
                    txt_giai_thich.Text += (mul[0, j] % 97)+ ", ";
                    else
                        txt_giai_thich.Text += (mul[0, j] % 97) + "]\r\n";
                }
                
               for(int k = 0; k < sizemat; k++)
                {
                    txt_ban_ma.Text += Form1.charMap[mul[0, k] % 97];
                }
               txt_giai_thich.Text +=   s.Substring(i, sizemat) +"==>";
                txt_giai_thich.Text += txt_ban_ma.Text.Substring(txt_ban_ma.Text.Length - sizemat, sizemat) +"\r\n";

            }
            if(s.Length % sizemat != 0) 
            {
                int du = s.Length % sizemat;
                txt_giai_thich.Text += "Xâu " +s.Substring(s.Length - du, du) + "Thừa hạ xuống\r\n";
                txt_ban_ma.Text +=s.Substring(s.Length - du , du);
            }
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_ban_goc.Text = txt_ban_ma.Text = txt_giai_thich.Text = txt_size_mat.Text = txt_khoa.Text = "";

        }
    }
    }

