using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRUpdate
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox()
        {
            InitializeComponent();
        }
        static CustomMessageBox msgBox;
        static string result ="";
        public static string Show(string text,string caption,string btnOne,string btnTwo)
        {
            msgBox = new CustomMessageBox();
            msgBox.label1.Text = text;
            msgBox.button1.Text = btnOne;
            msgBox.button2.Text = btnTwo;
            msgBox.ShowDialog();
            return result;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = "Yes";
            msgBox.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result ="No";
            msgBox.Close();
        }

        private void CustomMessageBox_Load(object sender, EventArgs e)
        {

        }
    }
}
