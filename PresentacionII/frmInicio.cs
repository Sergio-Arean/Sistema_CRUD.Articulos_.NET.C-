using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionII
{
    public partial class frmInicio : Form
    {
        private int posY = 0;
        private int posX = 0;
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            frmPrincipal form = new frmPrincipal();
            form.Show();
            this.Hide();
        }

        private void menuTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }


        }

        private void ipbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ipbCerrar_MouseEnter(object sender, EventArgs e)
        {
            ipbCerrar.BackColor = System.Drawing.Color.Crimson;
        }

        private void ipbCerrar_MouseLeave(object sender, EventArgs e)
        {
            ipbCerrar.BackColor = System.Drawing.Color.MediumPurple;
        }
    }
}
