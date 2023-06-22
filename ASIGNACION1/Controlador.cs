using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASIGNACION1
{
    internal class Controlador
    {
        public String ctrlRegistro(Usuarios usuario)
        {
            Modelo modelo = new Modelo();
            String respuesta = "";
            if (String.IsNullOrEmpty(usuario.Ci) || String.IsNullOrEmpty(usuario.Nombre) || String.IsNullOrEmpty(usuario.Materno)
                || String.IsNullOrEmpty(usuario.Cargo) || String.IsNullOrEmpty(usuario.Profesion) || String.IsNullOrEmpty(usuario.Usuario)
                || String.IsNullOrEmpty(usuario.Password))
            {
                respuesta = "Debe llenar todos los campos..!!";
            }
            else
            {
                if(modelo.existeUsuario(usuario.Usuario)){
                    respuesta = "El usuario ya existe..!!";
                }
                else
                {
                    modelo.registro(usuario);
                }
            }
            return respuesta;
        }

        public String ctrlLogin(String usuario, String password)
        {
            Modelo modelo = new Modelo();
            String respuesta = "";
            Usuarios datoUsuario = null;
            if(String.IsNullOrEmpty(usuario)||String.IsNullOrEmpty(password)) {
                respuesta = "Debe llenar todos los campo..!!";
            }
            else
            {
                datoUsuario=modelo.porUsuario(usuario);
                if(datoUsuario==null)
                {
                    respuesta = "El usuario no existe..!!";
                }
                else
                {
                    if(datoUsuario.Password != password)
                    {
                        respuesta = "El usuario y/o contraseña no coinciden..!!";
                    }
                    else
                    {
                        if (datoUsuario.Estado.Equals("F"))
                        {
                            respuesta = "Debe ser verificado por el administrador..!!";
                        }
                        else
                        {
                            Session.id = datoUsuario.Usuario_no;
                            Session.usuario = usuario;
                            Session.nombre = datoUsuario.Nombre;
                            Session.rol = datoUsuario.Rol;
                        }
                    }
                }
            }
            return respuesta;
        }
        public void borrarCapos(Form1 control)
        {
            foreach(var txt in control.Controls)
            {
                if(txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
            }
        }
    }
}
