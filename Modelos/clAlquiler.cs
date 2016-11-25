using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace video_club
{
    class clAlquiler : clConexion
    {
        public SqlCommand comando = new SqlCommand();

        public DataTable ObtenerTodos()
        {
            try
            {
                Conectar();

                comando = new SqlCommand("select alquiler_id, nombre_apellido, pelicula, precio, iva_10, sub_total, usuario from vista_alquiler;");
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
                SqlDataReader lector = default(SqlDataReader);
                lector = comando.ExecuteReader();
                if (lector.HasRows == true)
                {
                    DataTable p = new DataTable();
                    p.Load(lector);
                    return p;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                Desconectar();
            }
        }
    }
}
