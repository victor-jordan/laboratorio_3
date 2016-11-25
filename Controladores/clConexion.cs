using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace video_club
{
    public class clConexion
    {
        public static SqlConnection conexion;

        public static bool Conectar()
        {
            try
            {
                conexion = new SqlConnection("Server=(local);Database=video_club;Trusted_Connection=True");
                conexion.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool Desconectar()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
