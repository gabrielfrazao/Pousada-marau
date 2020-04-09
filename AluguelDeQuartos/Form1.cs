using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AluguelDeQuartos
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if ((textBox1.Text == "poo") && (textBox2.Text == "123"))
            {
                frmPrincipal abrir = new frmPrincipal();
                abrir.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Login e Senha inválidos !!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (e.KeyChar == 13) { 
            if ((textBox1.Text == "poo") && (textBox2.Text == "123"))
            {
                
                    frmPrincipal abrir = new frmPrincipal();
                    abrir.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Login e Senha inválidos !!!");
                }
            }
        }
    }
}
