using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASIGNACION1
{
    internal class Modelo
    {
        public int registro(Usuarios usuario)
        {
            //obtenemos la conexion
            SqlConnection conn = Conexion.getConexion();
            //abrimos la conexion
            conn.Open();
            //creamos una varaible que contiene la consulta
            String sql = "INSERT INTO USUARIOS " +
                "VALUES(@CI,@NOMBRE,@PATERNO,@MATERNO,@CARGO,@PROFESION,@USUARIO,@PASSWORD,@VERIFI,@ROL)";
            //realizamos la consulta
            SqlCommand cmd = new SqlCommand(sql, conn);
            //asignamos los valores para la consulta
            cmd.Parameters.AddWithValue("@CI", usuario.Ci);
            cmd.Parameters.AddWithValue("@NOMBRE", usuario.Nombre);
            cmd.Parameters.AddWithValue("@PATERNO", usuario.Paterno);
            cmd.Parameters.AddWithValue("@MATERNO", usuario.Materno);
            cmd.Parameters.AddWithValue("@CARGO", usuario.Cargo);
            cmd.Parameters.AddWithValue("@PROFESION", usuario.Profesion);
            cmd.Parameters.AddWithValue("@USUARIO", usuario.Usuario);
            cmd.Parameters.AddWithValue("@PASSWORD", usuario.Password);
            cmd.Parameters.AddWithValue("@VERIFI", "F");
            cmd.Parameters.AddWithValue("@ROL", 2);
            //obtenemos el numero de filas
            int resultado = cmd.ExecuteNonQuery();
            //retornamos el valor de resultado
            conn.Close();
            return resultado;
        }

        public bool existeUsuario(String usuario)
        {
            SqlDataReader reader;
            SqlConnection connection = Conexion.getConexion();  
            connection.Open();
            String sql = "SELECT USUARIO_NO FROM USUARIOS WHERE USUARIO LIKE @USUARIO";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@usuario",usuario);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
            connection.Close();
        }
        public Usuarios porUsuario(String usuario)
        {
            SqlDataReader reader;
            SqlConnection connection = Conexion.getConexion();
            connection.Open();
            String sql = "SELECT USUARIO_NO,NOMBRE,PASSWORD,ESTADO,ROL FROM USUARIOS WHERE USUARIO LIKE @USUARIO";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@usuario", usuario);
            reader = command.ExecuteReader();
            Usuarios user = null;
            while (reader.Read())
            {
                user = new Usuarios();
                user.Usuario_no = reader["USUARIO_NO"].ToString();
                user.Nombre = reader["NOMBRE"].ToString();
                user.Password = reader["PASSWORD"].ToString();
                user.Estado = reader["ESTADO"].ToString();
                user.Rol = int.Parse(reader["ROL"].ToString());
            }
            return user;
            connection.Close();
        }
    }
}
