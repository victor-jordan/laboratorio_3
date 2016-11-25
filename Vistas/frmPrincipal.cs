using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace video_club
{
    public partial class frmPrincipal : Form
    {       
       public frmPrincipal()
        {
            InitializeComponent();
        }

        public frmPrincipal(clUsuario usuario)
        {
            InitializeComponent();
            if (usuario.denominacion != "") {
                this.Text = this.Text + " - " + usuario.denominacion;
            }
        }

        private bool validarDatosVacios()
        {
            try {
                int dato_vacio = 0;
                foreach (Control item in this.gbDatos.Controls)
                {
                    if ((item.GetType() == typeof(TextBox) || item.GetType() == typeof(ComboBox)) && item.Text == string.Empty)
                    {
                        dato_vacio += 1;
                        item.BackColor = Color.Red;
                    }
                    else if ((item.GetType() == typeof(TextBox) || item.GetType() == typeof(ComboBox)) && item.Text != string.Empty)
                    {
                        item.BackColor = Color.White;
                    }
                }
                return (dato_vacio != 0);
            }
            catch { return false; }
        }

        private void cargarDatos()
        {
            Controladores.clPeliculaControlador oPelicula = new Controladores.clPeliculaControlador();
            DataTable las_peliculas = oPelicula.ObtenerTodos();
            dgvPeliculas.DataSource = las_peliculas;
            tbDirector.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbDirector.AutoCompleteMode = AutoCompleteMode.Suggest;
            AutoCompleteStringCollection Directores = new AutoCompleteStringCollection();
            Directores.AddRange(oPelicula.Colecciones("director"));
            tbDirector.AutoCompleteCustomSource = Directores;
            tbGenero.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbGenero.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection Generos = new AutoCompleteStringCollection();
            Generos.AddRange(oPelicula.Colecciones("genero"));
            tbGenero.AutoCompleteCustomSource = Generos;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cargarDatos();
            btnReset.PerformClick();
            tbTitulo.Select();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgvPeliculas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = this.dgvPeliculas.Rows[e.RowIndex];
            lblId.Text = fila.Cells[0].Value.ToString();
            tbTitulo.Text = fila.Cells[1].Value.ToString();
            tbGenero.Text = fila.Cells[2].Value.ToString();
            tbAnio.Text = fila.Cells[3].Value.ToString();
            tbDirector.Text = fila.Cells[4].Value.ToString();
            cbFormato.Text = fila.Cells[5].Value.ToString();
            tbPrecio.Text = fila.Cells[6].Value.ToString();
            btnAgregar.Text = "Modificar";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvPeliculas.ClearSelection();
            lblId.ResetText();
            tbTitulo.Clear();
            tbGenero.Clear();
            tbAnio.Clear();
            tbDirector.Clear();
            cbFormato.ResetText();
            tbPrecio.Clear();
            foreach (Control item in this.gbDatos.Controls)
            {
                if ((item.GetType() == typeof(TextBox) || item.GetType() == typeof(ComboBox)) && item.Text == string.Empty)
                {
                    if(item.BackColor.Equals(Color.Red))
                    {
                        item.BackColor = Color.White;
                    }
                }
            }
            btnAgregar.Text = "Agregar";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tbTitulo.Text = tbTitulo.Text.Trim();
            tbGenero.Text = tbGenero.Text.Trim();
            tbAnio.Text = tbAnio.Text.Trim();
            tbDirector.Text = tbDirector.Text.Trim();
            tbPrecio.Text = tbPrecio.Text.Trim();

            if (validarDatosVacios())
            {
                MessageBox.Show("Ningún campo puede estar vacío!");
            }
            else
            {
                Modelos.clPelicula oPelicula = new Modelos.clPelicula();
                oPelicula.pelicula_id = Convert.ToInt32(String.IsNullOrEmpty(lblId.Text.ToString()) ? null : lblId.Text.ToString());
                oPelicula.titulo = tbTitulo.Text;
                oPelicula.genero = tbGenero.Text;
                oPelicula.año = tbAnio.Text;
                oPelicula.director = tbDirector.Text;
                oPelicula.formato = cbFormato.Text;
                oPelicula.precio_alquiler = Convert.ToInt32(tbPrecio.Text);
                Controladores.clPeliculaControlador oCPelicula = new Controladores.clPeliculaControlador();
                MessageBox.Show(oCPelicula.Insertar(oPelicula).ToString());
                cargarDatos();
                btnReset.PerformClick();
                tbTitulo.Select();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Modelos.clPelicula oPelicula = new Modelos.clPelicula();
            oPelicula.pelicula_id = Convert.ToInt32(String.IsNullOrEmpty(lblId.Text.ToString()) ? null : lblId.Text.ToString());
            oPelicula.titulo = tbTitulo.Text;
            oPelicula.genero = tbGenero.Text;
            oPelicula.año = tbAnio.Text;
            oPelicula.director = tbDirector.Text;
            oPelicula.formato = cbFormato.Text;
            oPelicula.precio_alquiler = Convert.ToInt32(tbPrecio.Text);
            String mensaje = String.Format("Borrar: {0}, {1}", oPelicula.titulo, oPelicula.año) + Environment.NewLine + "Está seguro?";
            DialogResult borrar = MessageBox.Show(mensaje, "Borrando", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (borrar == DialogResult.Yes)
            {
                Controladores.clPeliculaControlador oCPelicula = new Controladores.clPeliculaControlador();
                oCPelicula.Borrar(oPelicula.pelicula_id);
                cargarDatos();
                btnReset.PerformClick();
            }
        }
    }
}
