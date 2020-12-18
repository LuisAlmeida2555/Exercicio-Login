using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bttlogin.Enabled = false;
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {
            bttlogin.Enabled = txtuser.Text != "" && txtsenha.Text != "" ? true : false;
        }

        private void txtuser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttlogin_Click(this, EventArgs.Empty);
            }
        }

        private void bttlogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entrou");
        }
    }
}
