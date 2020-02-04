using System;
using System.Text;
using System.Windows.Forms;

namespace Convertor
{
    public partial class Form1 : Form
    {
        public static string Ascii(string input)
        {
            string output = string.Empty;
            foreach (char c in input)
            {
                output += (int)c;
            }   return output;
        }

        public static string Hexadecimal(string UserInput)
        {
            byte[] bGetBytesFrom_UserInput = Encoding.Default.GetBytes(UserInput);
            var Hexadecimal_Out = BitConverter.ToString(bGetBytesFrom_UserInput);
            return Hexadecimal_Out;
        }

        public static string IterHex(string UserInput, int Iterations)
        {
            int i = 1;
            int Iters = Iterations;
            byte[] bGetBytesFrom_UserInput = Encoding.Default.GetBytes(UserInput);
            var Hexadecimal_Out = BitConverter.ToString(bGetBytesFrom_UserInput);

            while (i < Iters)

            {
                Hexadecimal_Out = Hexadecimal(Hexadecimal_Out);
                i = i + 1;
            }
            return Hexadecimal_Out;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ConvertTo_ASCII_Click(object sender, EventArgs e)
        {
            string input = ASCII_txtBox_Input.Text;
            string AsciiResult = Ascii(input);
            ASCII_txtBox_Input.Text = AsciiResult;
        }


        private void btn_ConvertTo_Hex_Click(object sender, EventArgs e)
        {
            string input = Hexadecimal_txtBox_Input.Text;
            string HexResult = Hexadecimal(input);
            Hexadecimal_txtBox_Input.Text = HexResult;
        }

        private void btn_ConvertTo_IteratedHex_Click(object sender, EventArgs e)
        {
            var Iterations = Convert.ToInt32(numericUpDown_Iterations_Hex.Value);
            string input = IterHex_txtBox_Input.Text;
            string IteratedHexResult = IterHex(input, Iterations);
            IterHex_txtBox_Input.Text = IteratedHexResult;
        }

    }
}
