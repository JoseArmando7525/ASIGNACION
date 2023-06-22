using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASIGNACION1
{
    internal class Usuarios
    {
        int rol;
        String usuario_no,ci,password,nombre, paterno, materno, cargo, profesion, usuario;
        String estado;

        public string Usuario_no { get => usuario_no; set => usuario_no = value; }
        public string Ci { get => ci; set => ci = value; }
        public string Password { get => password; set => password = value; }
        public int Rol { get => rol; set => rol = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Paterno { get => paterno; set => paterno = value; }
        public string Materno { get => materno; set => materno = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Profesion { get => profesion; set => profesion = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
