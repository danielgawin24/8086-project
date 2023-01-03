using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace architektura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AXBox.Text = BXBox.Text = CXBox.Text = DXBox.Text = "0000";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            AXBox.Text = $"{rnd.Next(65536).ToString("X4")}";
            BXBox.Text = $"{rnd.Next(65536).ToString("X4")}";
            CXBox.Text = $"{rnd.Next(65536).ToString("X4")}";
            DXBox.Text = $"{rnd.Next(65536).ToString("X4")}";
        }

        private void AXBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (!allowedChars.Contains(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void MOV_btn_Click(object sender, EventArgs e)
        {
            TextBox To = null, From = null;
            if (radioButton1.Checked) To = AXBox;
            else if (radioButton2.Checked) To = BXBox;
            else if (radioButton3.Checked) To = CXBox;
            else if (radioButton4.Checked) To = DXBox;

            if (radioButton5.Checked) From = AXBox;
            else if (radioButton6.Checked) From = BXBox;
            else if (radioButton7.Checked) From = CXBox;
            else if (radioButton8.Checked) From = DXBox;

            if (To != null & From != null)
                To.Text = From.Text;
        }

        private void XCHG_btn_Click(object sender, EventArgs e)
        {
            TextBox To = null, From = null;
            if (radioButton1.Checked) To = AXBox;
            else if (radioButton2.Checked) To = BXBox;
            else if (radioButton3.Checked) To = CXBox;
            else if (radioButton4.Checked) To = DXBox;

            if (radioButton5.Checked) From = AXBox;
            else if (radioButton6.Checked) From = BXBox;
            else if (radioButton7.Checked) From = CXBox;
            else if (radioButton8.Checked) From = DXBox;

            if (To != null & From != null)
            {
                string temp = To.Text;
                To.Text = From.Text;
                From.Text = temp;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
