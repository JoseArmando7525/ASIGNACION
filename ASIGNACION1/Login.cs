using Microsoft.Win32;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            linkCrear.Parent = pictureBox4;
            linkCrear.BackColor = Color.Transparent;
            linkCrear.ForeColor = Color.White;
            labelRegistro.Parent = pictureBox4;
            labelRegistro.BackColor = Color.Transparent;
            labelRegistro.ForeColor = Color.White;
            labelTitulo.BackColor = Color.Transparent;
            labelTitulo.Parent = pictureBox4;
            pbCerrar.BackColor = Color.Transparent;
            pbUsuario.BackColor = Color.Transparent;
            pbPassword.BackColor = Color.Transparent;
            pbCerrar.Parent = pictureBox4;
            pbUsuario.Parent = pictureBox4;
            pbPassword.Parent = pictureBox4;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkCrear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 rs = new Form1();
            rs.ShowDialog();
            //this.Hide();
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Ingrese su Usuario";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Ingrese su Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Ingrese su contraseña";
                txtContraseña.ForeColor = Color.Black;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Ingrese su contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text;
            String password = txtContraseña.Text;
            try
            {
                Controlador ctrl = new Controlador();
                String respuesta = ctrl.ctrlLogin(usuario,password);
                if (respuesta.Length>0) {
                    MessageBox.Show(respuesta,"aviso", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    this.Close();
                    MessageBox.Show("Bienvenido...!!");
                    Principal pri = new Principal();
                    //pri.Visible = true;
                    pri.ShowDialog();

                    //this.Visible=false;
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtContraseña.Focus();
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==Convert.ToChar(Keys.Enter))
            {
                String usuario = txtUsuario.Text;
                String password = txtContraseña.Text;
                try
                {
                    Controlador ctrl = new Controlador();
                    String respuesta = ctrl.ctrlLogin(usuario, password);
                    if (respuesta.Length > 0)
                    {
                        MessageBox.Show(respuesta, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        this.Close();
                        MessageBox.Show("Bienvenido...!!");
                        Principal pri = new Principal();
                        //pri.Visible = true;
                        pri.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
