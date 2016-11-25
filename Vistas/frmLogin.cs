using System;
using System.Drawing;
using System.Windows.Forms;

namespace video_club
{
    public partial class frmLogin : Form
    {
        // Variable para determinar fallos de login
        public int intento = 1;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tbUsuario.Focus();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            clUsuario oUsuario = new clUsuario();
            clAcceso oAcceso = new clAcceso();
            string estado;
            string mensaje;

            // Iniciando conexion a BBDD
            try
            {
                oUsuario.denominacion = tbUsuario.Text.Trim();
                oUsuario.clave = tbClave.Text.Trim();
                estado = oAcceso.Validacion(oUsuario);

                switch (estado)
                {
                    case "Activo":
                        this.Hide();
                        frmPrincipal principal = new frmPrincipal(oUsuario);
                        principal.Show();
                        break;
                    case "Inactivo":
                        mensaje = String.Format("Usuario: {0} {1} inactivo!", oUsuario.nombre, oUsuario.apellido) + Environment.NewLine + "Favor contactar con el administrador.";
                        this.BackColor = System.Drawing.Color.NavajoWhite;
                        this.pbImagen.BackColor = System.Drawing.Color.NavajoWhite;
                        MessageBox.Show(mensaje, "Usuario inactivo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.tbUsuario.Clear();
                        this.tbClave.Clear();
                        this.tbUsuario.Focus();
                        this.BackColor = SystemColors.ControlDark;
                        this.pbImagen.BackColor = SystemColors.ControlDark;
                        break;
                    default:
                        mensaje = String.Format("Combinacion usuario/password incorrecta..." + Environment.NewLine + "o Usuario: {0} inexistente", oUsuario.denominacion);
                        this.BackColor = System.Drawing.Color.DarkSalmon;
                        this.pbImagen.BackColor = System.Drawing.Color.DarkSalmon;
                        MessageBox.Show(mensaje, "Verificar!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.tbClave.Clear();
                        this.tbClave.Focus();
                        this.BackColor = SystemColors.ControlDark;
                        this.pbImagen.BackColor = SystemColors.ControlDark;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
            intento = intento + 1;
            if(intento == 4)
            {
                mensaje = "Tres intentos de acceso fallidos." + Environment.NewLine + "Favor contactar con el administrador.";
                MessageBox.Show(mensaje, "Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
