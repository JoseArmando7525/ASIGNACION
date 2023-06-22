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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.Ci = txtCi.Text;
            usuario.Nombre = txtNombre.Text ;
            usuario.Paterno = txtPaterno.Text;
            usuario.Materno = txtMaterno.Text;
            usuario.Cargo = txtCargo.Text;
            usuario.Profesion = txtProfesion.Text;
            usuario.Usuario =   txtUsuario.Text;
            usuario.Password = txtContraseña.Text;

            try {
                Controlador control = new Controlador();
                String respuesta = control.ctrlRegistro(usuario);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario Creado con EXITO..!!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    control.borrarCapos(this);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
