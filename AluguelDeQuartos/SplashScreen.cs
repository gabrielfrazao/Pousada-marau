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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (prgInicio.Value < 100)
            {
                prgInicio.Value = prgInicio.Value + 2;
            }
            else
            {
                timer1.Enabled = false;
                frmLogin abrirInicio = new frmLogin();
                abrirInicio.Show();
                this.Visible = false;
            }


        }
    }
}
