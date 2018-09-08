using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Train
{
    public partial class Admin_Main : Form
    {
        public Admin_Main()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_Main_Load(object sender, EventArgs e)
        {
           
        }

        private void Admin_Main_Load_1(object sender, EventArgs e)
        {
            mainPicture.BorderStyle = BorderStyle.None;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            viewPanel.Show();
            editPanel.Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            viewPanel.Hide();
            editPanel.Show();
        }
    }
}
