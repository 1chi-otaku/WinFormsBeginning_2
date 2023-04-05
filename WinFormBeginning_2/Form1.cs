using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormBeginning_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Rectangle";
            this.Width = 500;
            this.Height = 500;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.X > 10 && e.X < ClientSize.Width - 10 &&
                e.Y > 10 && e.Y < ClientSize.Height - 10)
                {
                    MessageBox.Show("Inside");
                }
                else if (e.X == 10 || e.X == ClientSize.Width - 10 ||
                e.Y == 10 || e.Y == ClientSize.Height - 10)
                {
                    MessageBox.Show("Frontier");
                }
                else
                    MessageBox.Show("Outside");
            }
            else if(e.Button == MouseButtons.Right)
            {
                MessageBox.Show("x - " + ClientSize.Width.ToString() + "\ny - " + ClientSize.Height.ToString(),"Window Size");
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Form frm = (Form)sender;
            frm.Text = String.Format("x = {0}  y = {1}", e.X, e.Y);
        }
    }
}

