using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OldUglyLegacyApp
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            var rng = new Random();
            int value = rng.Next(1000);
            label11.Visible = false;
            pictureBox1.ImageLocation = "http://2.bp.blogspot.com/_UmNGRJ8HjhA/S_cm4veCMUI/AAAAAAAAAao/8w7GOJR2-vE/s1600/mr-t.gif";
            pictureBox1.BringToFront();
            labelAutoNumber.Visible = true;
            labelValueAutonumber.Text = value.ToString("000");
            labelValueAutonumber.Visible = true;
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }
    }
}
