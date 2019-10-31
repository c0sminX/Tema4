using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int i = rnd.Next(1, 10);
            switch (i)
            {
                case 1:
                    TextBox1.ForeColor = Color.Red;
                    break;
                case 2:
                    TextBox1.ForeColor = Color.Blue;
                    break;
                case 3:
                    TextBox1.ForeColor = Color.Violet;
                    break;
                case 4:
                    TextBox1.ForeColor = Color.Yellow;
                    break;
                case 5:
                    TextBox1.ForeColor = Color.Pink;
                    break;
                case 6:
                    TextBox1.ForeColor = Color.Green;
                    break;
                case 7:
                    TextBox1.ForeColor = Color.DarkSeaGreen;
                    break;
                case 8:
                    TextBox1.ForeColor = Color.LawnGreen;
                    break;
                case 9:
                    TextBox1.ForeColor = Color.DarkBlue;
                    break;
                case 10:
                    TextBox1.ForeColor = Color.LavenderBlush;
                    break;
                default:
                    TextBox1.ForeColor = Color.Black;
                    break;
            }
        }
    }
}
