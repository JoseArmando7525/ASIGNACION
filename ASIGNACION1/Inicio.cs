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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            label1.Parent = pb1;
            label1.BackColor = Color.Transparent;
            label11.Parent = pb2;
            label11.BackColor = Color.Transparent;
            label12.Parent = pb3;
            label12.BackColor = Color.Transparent;
            label13.Parent = pb4;
            label13.BackColor = Color.Transparent;
            label5.Parent = pb5;
            label5.BackColor = Color.Transparent;
            label9.Parent = pb1;
            label9.BackColor = Color.Transparent;
            label9.ForeColor = Color.White;
            label10.Parent = pb2;
            label10.BackColor = Color.Transparent;
            label10.ForeColor = Color.White;
            label2.Parent = pb3;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label3.Parent = pb4;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label4.Parent = pb5;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            label9.BackColor = Color.Transparent;
            label9.ForeColor = Color.White;
            label9.Parent = pb1;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panel4.Visible == true)
            {
                panel4.Visible = false;
            }
            else
            {
                panel4.Visible = true;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
