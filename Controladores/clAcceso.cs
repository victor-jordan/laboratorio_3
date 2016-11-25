using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;


namespace video_club
{
    class clAcceso : clConexion
    {
        public SqlCommand comando = new SqlCommand();

        public string Validacion(clUsuario usuario)
        {
            try
            {
                Conectar();

                comando = new SqlCommand("login_usuario");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = conexion;
                comando.Parameters.AddWithValue("@usuario", usuario.denominacion);
                comando.Parameters.AddWithValue("@password", usuario.clave);
                SqlDataReader lector = default(SqlDataReader);
                lector = comando.ExecuteReader();
                if (lector.HasRows == true)
                {
                    while (lector.Read())
                    {
                        usuario.nombre = lector.GetString(2).Trim();
                        usuario.apellido = lector.GetString(3).Trim();
                        usuario.activo = lector.GetBoolean(4);
                    }
                    if (usuario.activo == true)
                    {
                        return "Activo";
                    }
                    else if (usuario.activo == false)
                    {
                        return "Inactivo";
                    }
                    else
                    {
                        return "Desconocido";
                    }
                }
                else
                {
                    return "Inexistente";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return "Error";
            }
            finally
            {
                Desconectar();
            }
        }
    }
}
