using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASIGNACION1
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            textUsuario.Text = Session.nombre;
            if (Session.rol == 2)
            {
                btnAsignaciones.Visible = true;
                btnEmpleados.Visible = false;
                btnInventario.Visible = false;
                btnOficinas.Visible = false;
                btnPartidas.Visible = false;
            }
            abrirFrm(new Inicio());
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            abrirFrm(new Inicio());
        }

        private void abrirFrm(object frmHijo)
        {
            if(this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0);
            }
            Form fn = frmHijo as Form;
            fn.TopLevel = false;
            fn.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fn);
            this.panel1.Tag = fn;
            fn.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
