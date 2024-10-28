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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static Dictionary<int, char> charMap = new Dictionary<int, char>
        {
            { 0, 'a' }, { 1, 'b' }, { 2, 'c' }, { 3, 'd' }, { 4, 'e' }, { 5, 'f' },
            { 6, 'g' }, { 7, 'h' }, { 8, 'i' }, { 9, 'j' }, { 10, 'k' }, { 11, 'l' },
            { 12, 'm' }, { 13, 'n' }, { 14, 'o' }, { 15, 'p' }, { 16, 'q' }, { 17, 'r' },
            { 18, 's' }, { 19, 't' }, { 20, 'u' }, { 21, 'v' }, { 22, 'w' }, { 23, 'x' },
            { 24, 'y' }, { 25, 'z' }, { 26, 'A' }, { 27, 'B' }, { 28, 'C' }, { 29, 'D' },
            { 30, 'E' }, { 31, 'F' }, { 32, 'G' }, { 33, 'H' }, { 34, 'I' }, { 35, 'J' },
            { 36, 'K' }, { 37, 'L' }, { 38, 'M' }, { 39, 'N' }, { 40, 'O' }, { 41, 'P' },
            { 42, 'Q' }, { 43, 'R' }, { 44, 'S' }, { 45, 'T' }, { 46, 'U' }, { 47, 'V' },
            { 48, 'W' }, { 49, 'X' }, { 50, 'Y' }, { 51, 'Z' }, { 52, ' ' }, { 53, '~' },
            { 54, '`' }, { 55, '!' }, { 56, '@' }, { 57, '#' }, { 58, '$' }, { 59, '%' },
            { 60, '^' }, { 61, '&' }, { 62, '*' }, { 63, '(' }, { 64, ')' }, { 65, '-' },
            { 66, '_' }, { 67, '+' }, { 68, '=' }, { 69, '|' }, { 70, '\\' }, { 71, '"' },
            { 72, '\n' }, { 73, '\t' }, { 74, '{' }, { 75, '[' }, { 76, ']' }, { 77, '}' },
            { 78, ':' }, { 79, ';' }, { 80, '\'' }, { 81, '<' }, { 82, ',' }, { 83, '.' },
            { 84, '>' }, { 85, '?' }, { 86, '/' }, { 87, '0' }, { 88, '1' }, { 89, '2' },
            { 90, '3' }, { 91, '4' }, { 92, '5' }, { 93, '6' }, { 94, '7' }, { 95, '8' },
            { 96, '9' }
        };
        public static Dictionary<char, int> charMap2 = new Dictionary<char, int>
{
    { 'a', 0 }, { 'b', 1 }, { 'c', 2 }, { 'd', 3 }, { 'e', 4 }, { 'f', 5 },
    { 'g', 6 }, { 'h', 7 }, { 'i', 8 }, { 'j', 9 }, { 'k', 10 }, { 'l', 11 },
    { 'm', 12 }, { 'n', 13 }, { 'o', 14 }, { 'p', 15 }, { 'q', 16 }, { 'r', 17 },
    { 's', 18 }, { 't', 19 }, { 'u', 20 }, { 'v', 21 }, { 'w', 22 }, { 'x', 23 },
    { 'y', 24 }, { 'z', 25 }, { 'A', 26 }, { 'B', 27 }, { 'C', 28 }, { 'D', 29 },
    { 'E', 30 }, { 'F', 31 }, { 'G', 32 }, { 'H', 33 }, { 'I', 34 }, { 'J', 35 },
    { 'K', 36 }, { 'L', 37 }, { 'M', 38 }, { 'N', 39 }, { 'O', 40 }, { 'P', 41 },
    { 'Q', 42 }, { 'R', 43 }, { 'S', 44 }, { 'T', 45 }, { 'U', 46 }, { 'V', 47 },
    { 'W', 48 }, { 'X', 49 }, { 'Y', 50 }, { 'Z', 51 }, { ' ', 52 }, { '~', 53 },
    { '`', 54 }, { '!', 55 }, { '@', 56 }, { '#', 57 }, { '$', 58 }, { '%', 59 },
    { '^', 60 }, { '&', 61 }, { '*', 62 }, { '(', 63 }, { ')', 64 }, { '-', 65 },
    { '_', 66 }, { '+', 67 }, { '=', 68 }, { '|', 69 }, { '\\', 70 }, { '"', 71 },
    { '\n', 72 }, { '\t', 73 }, { '{', 74 }, { '[', 75 }, { ']', 76 }, { '}', 77 },
    { ':', 78 }, { ';', 79 }, { '\'', 80 }, { '<', 81 }, { ',', 82 }, { '.', 83 },
    { '>', 84 }, { '?', 85 }, { '/', 86 }, { '0', 87 }, { '1', 88 }, { '2', 89 },
    { '3', 90 }, { '4', 91 }, { '5', 92 }, { '6', 93 }, { '7', 94 }, { '8', 95 },
    { '9', 96 }
};

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hill formHii = new Hill();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(formHii);
            formHii.Dock = DockStyle.Fill;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Affine formAfine = new Affine();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(formAfine);
            formAfine.Dock = DockStyle.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DonBang formDonBang = new DonBang();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(formDonBang);
            formDonBang.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vigenere vigenere = new Vigenere();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(vigenere);
            vigenere.Dock = DockStyle.Fill;
        }

        private void btn_playfair_Click(object sender, EventArgs e)
        {

        }

        private void btn_hang_Click(object sender, EventArgs e)
        {

        }

        private void btn_ceasar_Click(object sender, EventArgs e)
        {
            Ceasar formCeasar = new Ceasar();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(formCeasar);
            formCeasar.Dock = DockStyle.Fill;

        }

        private void btn_playfair_Click_1(object sender, EventArgs e)
        {
            PlayFair playFair = new PlayFair();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add((PlayFair)playFair);
            playFair.Dock = DockStyle.Fill;
        }

        private void btn_hang_Click_1(object sender, EventArgs e)
        {
            Hang formHang = new Hang();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(formHang);
            formHang.Dock = DockStyle.Fill;
        }
    }
}
