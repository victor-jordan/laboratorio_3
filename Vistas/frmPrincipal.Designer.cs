namespace video_club
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.cbFormato = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.lblFormato = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.tbDirector = new System.Windows.Forms.TextBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.tbAnio = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.tbGenero = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.gbAcciones = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            this.gbDatos.SuspendLayout();
            this.gbAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvPeliculas.AllowUserToAddRows = false;
            this.dgvPeliculas.AllowUserToDeleteRows = false;
            this.dgvPeliculas.AllowUserToOrderColumns = true;
            this.dgvPeliculas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeliculas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPeliculas.Location = new System.Drawing.Point(12, 175);
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPeliculas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Navy;
            this.dgvPeliculas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvPeliculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeliculas.Size = new System.Drawing.Size(763, 206);
            this.dgvPeliculas.TabIndex = 0;
            this.dgvPeliculas.TabStop = false;
            this.dgvPeliculas.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeliculas_CellEnter);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.cbFormato);
            this.gbDatos.Controls.Add(this.lblPrecio);
            this.gbDatos.Controls.Add(this.tbPrecio);
            this.gbDatos.Controls.Add(this.lblFormato);
            this.gbDatos.Controls.Add(this.lblDirector);
            this.gbDatos.Controls.Add(this.tbDirector);
            this.gbDatos.Controls.Add(this.lblAnio);
            this.gbDatos.Controls.Add(this.tbAnio);
            this.gbDatos.Controls.Add(this.lblGenero);
            this.gbDatos.Controls.Add(this.tbGenero);
            this.gbDatos.Controls.Add(this.lblTitulo);
            this.gbDatos.Controls.Add(this.lblId);
            this.gbDatos.Controls.Add(this.tbTitulo);
            this.gbDatos.Location = new System.Drawing.Point(13, 13);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(571, 156);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos de Película";
            // 
            // cbFormato
            // 
            this.cbFormato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFormato.FormattingEnabled = true;
            this.cbFormato.Items.AddRange(new object[] {
            "VHS",
            "DVD",
            "BRY",
            "TDI",
            "HD"});
            this.cbFormato.Location = new System.Drawing.Point(362, 79);
            this.cbFormato.Name = "cbFormato";
            this.cbFormato.Size = new System.Drawing.Size(130, 21);
            this.cbFormato.TabIndex = 5;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(359, 109);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 0;
            this.lblPrecio.Text = "Precio";
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(362, 125);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(130, 20);
            this.tbPrecio.TabIndex = 6;
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Location = new System.Drawing.Point(359, 62);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(45, 13);
            this.lblFormato.TabIndex = 0;
            this.lblFormato.Text = "Formato";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(359, 15);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(44, 13);
            this.lblDirector.TabIndex = 0;
            this.lblDirector.Text = "Director";
            // 
            // tbDirector
            // 
            this.tbDirector.Location = new System.Drawing.Point(362, 31);
            this.tbDirector.Name = "tbDirector";
            this.tbDirector.Size = new System.Drawing.Size(130, 20);
            this.tbDirector.TabIndex = 4;
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(116, 109);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(26, 13);
            this.lblAnio.TabIndex = 0;
            this.lblAnio.Text = "Año";
            // 
            // tbAnio
            // 
            this.tbAnio.Location = new System.Drawing.Point(119, 125);
            this.tbAnio.Name = "tbAnio";
            this.tbAnio.Size = new System.Drawing.Size(82, 20);
            this.tbAnio.TabIndex = 3;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(116, 62);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 0;
            this.lblGenero.Text = "Genero";
            // 
            // tbGenero
            // 
            this.tbGenero.Location = new System.Drawing.Point(119, 78);
            this.tbGenero.Name = "tbGenero";
            this.tbGenero.Size = new System.Drawing.Size(130, 20);
            this.tbGenero.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(116, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(17, 78);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(57, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "pelicula_id";
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(119, 31);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(130, 20);
            this.tbTitulo.TabIndex = 1;
            // 
            // gbAcciones
            // 
            this.gbAcciones.Controls.Add(this.btnReset);
            this.gbAcciones.Controls.Add(this.btnCancelar);
            this.gbAcciones.Controls.Add(this.btnBorrar);
            this.gbAcciones.Controls.Add(this.btnAgregar);
            this.gbAcciones.Location = new System.Drawing.Point(591, 13);
            this.gbAcciones.Name = "gbAcciones";
            this.gbAcciones.Size = new System.Drawing.Size(184, 156);
            this.gbAcciones.TabIndex = 0;
            this.gbAcciones.TabStop = false;
            this.gbAcciones.Text = "Acciones";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(21, 88);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(140, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(21, 124);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(21, 52);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(140, 23);
            this.btnBorrar.TabIndex = 9;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(21, 16);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(140, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmPrincipal
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(787, 393);
            this.Controls.Add(this.gbAcciones);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.dgvPeliculas);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.GroupBox gbAcciones;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.TextBox tbAnio;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox tbGenero;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label lblFormato;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.TextBox tbDirector;
        private System.Windows.Forms.ComboBox cbFormato;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvPeliculas;
        private System.Windows.Forms.Button btnReset;
    }
}