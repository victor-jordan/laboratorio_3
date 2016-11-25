using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using video_club.Modelos;

namespace video_club.Controladores
{
    class clPeliculaControlador : clConexion, itfManejador<clPelicula>
    {
        public SqlCommand comando = new SqlCommand();

        public DataTable ObtenerTodos()
        {
            try
            {
                Conectar();

                comando = new SqlCommand("select pelicula_id as Id, titulo as Titulo, genero as Genero, año, director, formato, precio_alquiler from pelicula");
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

        public string[] Colecciones(String campo)
        {
            try
            {
                Conectar();

                String sentencia = String.Format("select distinct {0} from pelicula;", campo);
                comando = new SqlCommand(sentencia);
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataSet datos = new DataSet();
                adaptador.Fill(datos);
                adaptador.Dispose();
                string[] los_datos = new string[datos.Tables[0].Rows.Count];
                if (datos.Tables[0].Rows.Count > 0)
                {
                    for(int i = 0; i < datos.Tables[0].Rows.Count; i++)
                    {
                        los_datos[i] = datos.Tables[0].Rows[i].ItemArray[0].ToString();
                    }
                    return los_datos;
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

        public string ObtenerUno(string key)
        {
            throw new NotImplementedException();
        }

        public string Insertar(clPelicula pelicula)
        {
            try
            {
                Conectar();

                comando = new SqlCommand("upsert_pelicula");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = conexion;
                comando.Parameters.AddWithValue("@pelicula_id", pelicula.pelicula_id);
                comando.Parameters.AddWithValue("@titulo", pelicula.titulo);
                comando.Parameters.AddWithValue("@genero", pelicula.genero);
                comando.Parameters.AddWithValue("@año", pelicula.año);
                comando.Parameters.AddWithValue("@director", pelicula.director);
                comando.Parameters.AddWithValue("@formato", pelicula.formato);
                comando.Parameters.AddWithValue("@precio_alquiler", pelicula.precio_alquiler);
                comando.ExecuteNonQuery();
                return "Realizado!";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error";
            }
            finally
            {
                Desconectar();
            }
        }

        public void Modificar(clPelicula obj)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int pelcula_id)
        {
            try
            {
                Conectar();
                comando = new SqlCommand(String.Format("delete from pelicula where pelicula_id = {0}", pelcula_id));
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro borrado.", "Borrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
        }
    }
}
