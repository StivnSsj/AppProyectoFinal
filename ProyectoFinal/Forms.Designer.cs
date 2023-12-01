namespace ProyectoFinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbcGestion = new System.Windows.Forms.TabControl();
            this.tpRegistro = new System.Windows.Forms.TabPage();
            this.pnlRegistro = new System.Windows.Forms.Panel();
            this.cbxHabitat = new System.Windows.Forms.ComboBox();
            this.lbHabitat = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.lbTipo = new System.Windows.Forms.Label();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.lbEspecie = new System.Windows.Forms.Label();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lbGenero = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.tpConsulta = new System.Windows.Forms.TabPage();
            this.pnlConsulta = new System.Windows.Forms.Panel();
            this.lbTitConsulta = new System.Windows.Forms.Label();
            this.dvgDatos = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.tpBusqueda = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbResHabitat = new System.Windows.Forms.Label();
            this.lbResTipo = new System.Windows.Forms.Label();
            this.lbResGenero = new System.Windows.Forms.Label();
            this.lbMostrarHabitat = new System.Windows.Forms.Label();
            this.lbMostrarTipo = new System.Windows.Forms.Label();
            this.lbMostrarGenero = new System.Windows.Forms.Label();
            this.lbResEspecie = new System.Windows.Forms.Label();
            this.lbMostrarEspecie = new System.Windows.Forms.Label();
            this.lblTitBusqueda = new System.Windows.Forms.Label();
            this.btnBuscarXId = new System.Windows.Forms.Button();
            this.lbResNombre = new System.Windows.Forms.Label();
            this.lbMostrarNombre = new System.Windows.Forms.Label();
            this.txtBuscarXId = new System.Windows.Forms.TextBox();
            this.lbMms = new System.Windows.Forms.Label();
            this.tpCronograma = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTitCronograma = new System.Windows.Forms.Label();
            this.dvgCronograma = new System.Windows.Forms.DataGridView();
            this.btnCronograma = new System.Windows.Forms.Button();
            this.tbcGestion.SuspendLayout();
            this.tpRegistro.SuspendLayout();
            this.pnlRegistro.SuspendLayout();
            this.tpConsulta.SuspendLayout();
            this.pnlConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDatos)).BeginInit();
            this.tpBusqueda.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpCronograma.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCronograma)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcGestion
            // 
            this.tbcGestion.Controls.Add(this.tpRegistro);
            this.tbcGestion.Controls.Add(this.tpConsulta);
            this.tbcGestion.Controls.Add(this.tpBusqueda);
            this.tbcGestion.Controls.Add(this.tpCronograma);
            this.tbcGestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcGestion.Location = new System.Drawing.Point(-1, -1);
            this.tbcGestion.Name = "tbcGestion";
            this.tbcGestion.SelectedIndex = 0;
            this.tbcGestion.Size = new System.Drawing.Size(803, 532);
            this.tbcGestion.TabIndex = 0;
            // 
            // tpRegistro
            // 
            this.tpRegistro.Controls.Add(this.pnlRegistro);
            this.tpRegistro.Location = new System.Drawing.Point(4, 29);
            this.tpRegistro.Name = "tpRegistro";
            this.tpRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegistro.Size = new System.Drawing.Size(795, 499);
            this.tpRegistro.TabIndex = 0;
            this.tpRegistro.Text = "RegistroAnimal";
            this.tpRegistro.UseVisualStyleBackColor = true;
            this.tpRegistro.Click += new System.EventHandler(this.tpRegistro_Click);
            // 
            // pnlRegistro
            // 
            this.pnlRegistro.BackColor = System.Drawing.Color.Azure;
            this.pnlRegistro.Controls.Add(this.cbxHabitat);
            this.pnlRegistro.Controls.Add(this.lbHabitat);
            this.pnlRegistro.Controls.Add(this.cbxTipo);
            this.pnlRegistro.Controls.Add(this.lbTipo);
            this.pnlRegistro.Controls.Add(this.txtEspecie);
            this.pnlRegistro.Controls.Add(this.lbEspecie);
            this.pnlRegistro.Controls.Add(this.rbFemenino);
            this.pnlRegistro.Controls.Add(this.rbMasculino);
            this.pnlRegistro.Controls.Add(this.btnGuardar);
            this.pnlRegistro.Controls.Add(this.lbGenero);
            this.pnlRegistro.Controls.Add(this.txtNombre);
            this.pnlRegistro.Controls.Add(this.lbNombre);
            this.pnlRegistro.Controls.Add(this.txtCodigo);
            this.pnlRegistro.Controls.Add(this.lbCodigo);
            this.pnlRegistro.Controls.Add(this.lbMensaje);
            this.pnlRegistro.ForeColor = System.Drawing.Color.Black;
            this.pnlRegistro.Location = new System.Drawing.Point(159, 77);
            this.pnlRegistro.Name = "pnlRegistro";
            this.pnlRegistro.Size = new System.Drawing.Size(423, 297);
            this.pnlRegistro.TabIndex = 1;
            // 
            // cbxHabitat
            // 
            this.cbxHabitat.FormattingEnabled = true;
            this.cbxHabitat.Items.AddRange(new object[] {
            "Africa",
            "Asia",
            "Acuario",
            "America"});
            this.cbxHabitat.Location = new System.Drawing.Point(193, 171);
            this.cbxHabitat.Name = "cbxHabitat";
            this.cbxHabitat.Size = new System.Drawing.Size(121, 28);
            this.cbxHabitat.TabIndex = 15;
            // 
            // lbHabitat
            // 
            this.lbHabitat.AutoSize = true;
            this.lbHabitat.BackColor = System.Drawing.Color.Transparent;
            this.lbHabitat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHabitat.Location = new System.Drawing.Point(94, 169);
            this.lbHabitat.Name = "lbHabitat";
            this.lbHabitat.Size = new System.Drawing.Size(72, 24);
            this.lbHabitat.TabIndex = 14;
            this.lbHabitat.Text = "Habitat:";
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Acuatico",
            "Aereo",
            "Terrestre"});
            this.cbxTipo.Location = new System.Drawing.Point(193, 140);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(121, 28);
            this.cbxTipo.TabIndex = 13;
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.BackColor = System.Drawing.Color.Transparent;
            this.lbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipo.Location = new System.Drawing.Point(105, 141);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(53, 24);
            this.lbTipo.TabIndex = 12;
            this.lbTipo.Text = "Tipo:";
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(193, 76);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(121, 26);
            this.txtEspecie.TabIndex = 11;
            // 
            // lbEspecie
            // 
            this.lbEspecie.AutoSize = true;
            this.lbEspecie.BackColor = System.Drawing.Color.Transparent;
            this.lbEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEspecie.Location = new System.Drawing.Point(87, 76);
            this.lbEspecie.Name = "lbEspecie";
            this.lbEspecie.Size = new System.Drawing.Size(84, 24);
            this.lbEspecie.TabIndex = 10;
            this.lbEspecie.Text = "Especie:";
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.BackColor = System.Drawing.Color.Transparent;
            this.rbFemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemenino.Location = new System.Drawing.Point(292, 210);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(100, 22);
            this.rbFemenino.TabIndex = 9;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = false;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.BackColor = System.Drawing.Color.Transparent;
            this.rbMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasculino.Location = new System.Drawing.Point(182, 210);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(103, 22);
            this.rbMasculino.TabIndex = 8;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(184, 246);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 26);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.BackColor = System.Drawing.Color.Transparent;
            this.lbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenero.Location = new System.Drawing.Point(98, 207);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(79, 24);
            this.lbGenero.TabIndex = 5;
            this.lbGenero.Text = "Genero:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(193, 109);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 26);
            this.txtNombre.TabIndex = 4;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.BackColor = System.Drawing.Color.Transparent;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(88, 109);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(84, 24);
            this.lbNombre.TabIndex = 3;
            this.lbNombre.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigo.Location = new System.Drawing.Point(193, 45);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 26);
            this.txtCodigo.TabIndex = 2;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Location = new System.Drawing.Point(94, 45);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(76, 24);
            this.lbCodigo.TabIndex = 1;
            this.lbCodigo.Text = "Codigo:";
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lbMensaje.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje.Location = new System.Drawing.Point(51, 0);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(341, 31);
            this.lbMensaje.TabIndex = 0;
            this.lbMensaje.Text = "Digite los datos del Animal";
            // 
            // tpConsulta
            // 
            this.tpConsulta.Controls.Add(this.pnlConsulta);
            this.tpConsulta.Location = new System.Drawing.Point(4, 29);
            this.tpConsulta.Name = "tpConsulta";
            this.tpConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsulta.Size = new System.Drawing.Size(795, 499);
            this.tpConsulta.TabIndex = 1;
            this.tpConsulta.Text = "Consultar Animal";
            this.tpConsulta.UseVisualStyleBackColor = true;
            // 
            // pnlConsulta
            // 
            this.pnlConsulta.Controls.Add(this.lbTitConsulta);
            this.pnlConsulta.Controls.Add(this.dvgDatos);
            this.pnlConsulta.Controls.Add(this.btnConsultar);
            this.pnlConsulta.Location = new System.Drawing.Point(0, 0);
            this.pnlConsulta.Name = "pnlConsulta";
            this.pnlConsulta.Size = new System.Drawing.Size(799, 503);
            this.pnlConsulta.TabIndex = 0;
            // 
            // lbTitConsulta
            // 
            this.lbTitConsulta.AutoSize = true;
            this.lbTitConsulta.BackColor = System.Drawing.Color.White;
            this.lbTitConsulta.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitConsulta.Location = new System.Drawing.Point(272, 40);
            this.lbTitConsulta.Name = "lbTitConsulta";
            this.lbTitConsulta.Size = new System.Drawing.Size(250, 31);
            this.lbTitConsulta.TabIndex = 6;
            this.lbTitConsulta.Text = "Consultar Animales";
            // 
            // dvgDatos
            // 
            this.dvgDatos.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dvgDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dvgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDatos.Location = new System.Drawing.Point(121, 172);
            this.dvgDatos.Name = "dvgDatos";
            this.dvgDatos.Size = new System.Drawing.Size(555, 260);
            this.dvgDatos.TabIndex = 1;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(338, 94);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(120, 33);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // tpBusqueda
            // 
            this.tpBusqueda.Controls.Add(this.panel1);
            this.tpBusqueda.Location = new System.Drawing.Point(4, 29);
            this.tpBusqueda.Name = "tpBusqueda";
            this.tpBusqueda.Padding = new System.Windows.Forms.Padding(3);
            this.tpBusqueda.Size = new System.Drawing.Size(795, 499);
            this.tpBusqueda.TabIndex = 2;
            this.tpBusqueda.Text = "Busqueda Animal";
            this.tpBusqueda.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.lbResHabitat);
            this.panel1.Controls.Add(this.lbResTipo);
            this.panel1.Controls.Add(this.lbResGenero);
            this.panel1.Controls.Add(this.lbMostrarHabitat);
            this.panel1.Controls.Add(this.lbMostrarTipo);
            this.panel1.Controls.Add(this.lbMostrarGenero);
            this.panel1.Controls.Add(this.lbResEspecie);
            this.panel1.Controls.Add(this.lbMostrarEspecie);
            this.panel1.Controls.Add(this.lblTitBusqueda);
            this.panel1.Controls.Add(this.btnBuscarXId);
            this.panel1.Controls.Add(this.lbResNombre);
            this.panel1.Controls.Add(this.lbMostrarNombre);
            this.panel1.Controls.Add(this.txtBuscarXId);
            this.panel1.Controls.Add(this.lbMms);
            this.panel1.Location = new System.Drawing.Point(158, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 340);
            this.panel1.TabIndex = 0;
            // 
            // lbResHabitat
            // 
            this.lbResHabitat.AutoSize = true;
            this.lbResHabitat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResHabitat.Location = new System.Drawing.Point(231, 254);
            this.lbResHabitat.Name = "lbResHabitat";
            this.lbResHabitat.Size = new System.Drawing.Size(16, 24);
            this.lbResHabitat.TabIndex = 13;
            this.lbResHabitat.Text = "-";
            // 
            // lbResTipo
            // 
            this.lbResTipo.AutoSize = true;
            this.lbResTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResTipo.Location = new System.Drawing.Point(231, 214);
            this.lbResTipo.Name = "lbResTipo";
            this.lbResTipo.Size = new System.Drawing.Size(16, 24);
            this.lbResTipo.TabIndex = 12;
            this.lbResTipo.Text = "-";
            // 
            // lbResGenero
            // 
            this.lbResGenero.AutoSize = true;
            this.lbResGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResGenero.Location = new System.Drawing.Point(231, 175);
            this.lbResGenero.Name = "lbResGenero";
            this.lbResGenero.Size = new System.Drawing.Size(16, 24);
            this.lbResGenero.TabIndex = 11;
            this.lbResGenero.Text = "-";
            // 
            // lbMostrarHabitat
            // 
            this.lbMostrarHabitat.AutoSize = true;
            this.lbMostrarHabitat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMostrarHabitat.Location = new System.Drawing.Point(137, 254);
            this.lbMostrarHabitat.Name = "lbMostrarHabitat";
            this.lbMostrarHabitat.Size = new System.Drawing.Size(72, 24);
            this.lbMostrarHabitat.TabIndex = 10;
            this.lbMostrarHabitat.Text = "Habitat:";
            // 
            // lbMostrarTipo
            // 
            this.lbMostrarTipo.AutoSize = true;
            this.lbMostrarTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMostrarTipo.Location = new System.Drawing.Point(156, 214);
            this.lbMostrarTipo.Name = "lbMostrarTipo";
            this.lbMostrarTipo.Size = new System.Drawing.Size(53, 24);
            this.lbMostrarTipo.TabIndex = 9;
            this.lbMostrarTipo.Text = "Tipo:";
            // 
            // lbMostrarGenero
            // 
            this.lbMostrarGenero.AutoSize = true;
            this.lbMostrarGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMostrarGenero.Location = new System.Drawing.Point(130, 175);
            this.lbMostrarGenero.Name = "lbMostrarGenero";
            this.lbMostrarGenero.Size = new System.Drawing.Size(79, 24);
            this.lbMostrarGenero.TabIndex = 8;
            this.lbMostrarGenero.Text = "Genero:";
            // 
            // lbResEspecie
            // 
            this.lbResEspecie.AutoSize = true;
            this.lbResEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResEspecie.Location = new System.Drawing.Point(231, 134);
            this.lbResEspecie.Name = "lbResEspecie";
            this.lbResEspecie.Size = new System.Drawing.Size(16, 24);
            this.lbResEspecie.TabIndex = 7;
            this.lbResEspecie.Text = "-";
            // 
            // lbMostrarEspecie
            // 
            this.lbMostrarEspecie.AutoSize = true;
            this.lbMostrarEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMostrarEspecie.Location = new System.Drawing.Point(125, 134);
            this.lbMostrarEspecie.Name = "lbMostrarEspecie";
            this.lbMostrarEspecie.Size = new System.Drawing.Size(84, 24);
            this.lbMostrarEspecie.TabIndex = 6;
            this.lbMostrarEspecie.Text = "Especie:";
            // 
            // lblTitBusqueda
            // 
            this.lblTitBusqueda.AutoSize = true;
            this.lblTitBusqueda.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitBusqueda.Location = new System.Drawing.Point(108, 6);
            this.lblTitBusqueda.Name = "lblTitBusqueda";
            this.lblTitBusqueda.Size = new System.Drawing.Size(264, 31);
            this.lblTitBusqueda.TabIndex = 5;
            this.lblTitBusqueda.Text = "Busqueda de Animal";
            // 
            // btnBuscarXId
            // 
            this.btnBuscarXId.Location = new System.Drawing.Point(372, 53);
            this.btnBuscarXId.Name = "btnBuscarXId";
            this.btnBuscarXId.Size = new System.Drawing.Size(75, 26);
            this.btnBuscarXId.TabIndex = 4;
            this.btnBuscarXId.Text = "Buscar";
            this.btnBuscarXId.UseVisualStyleBackColor = true;
            this.btnBuscarXId.Click += new System.EventHandler(this.btnBuscarXId_Click);
            // 
            // lbResNombre
            // 
            this.lbResNombre.AutoSize = true;
            this.lbResNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResNombre.Location = new System.Drawing.Point(231, 95);
            this.lbResNombre.Name = "lbResNombre";
            this.lbResNombre.Size = new System.Drawing.Size(16, 24);
            this.lbResNombre.TabIndex = 3;
            this.lbResNombre.Text = "-";
            // 
            // lbMostrarNombre
            // 
            this.lbMostrarNombre.AutoSize = true;
            this.lbMostrarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMostrarNombre.Location = new System.Drawing.Point(125, 95);
            this.lbMostrarNombre.Name = "lbMostrarNombre";
            this.lbMostrarNombre.Size = new System.Drawing.Size(89, 24);
            this.lbMostrarNombre.TabIndex = 2;
            this.lbMostrarNombre.Text = "Nombre: ";
            // 
            // txtBuscarXId
            // 
            this.txtBuscarXId.Location = new System.Drawing.Point(253, 55);
            this.txtBuscarXId.Name = "txtBuscarXId";
            this.txtBuscarXId.Size = new System.Drawing.Size(100, 26);
            this.txtBuscarXId.TabIndex = 1;
            // 
            // lbMms
            // 
            this.lbMms.AutoSize = true;
            this.lbMms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMms.Location = new System.Drawing.Point(20, 55);
            this.lbMms.Name = "lbMms";
            this.lbMms.Size = new System.Drawing.Size(227, 24);
            this.lbMms.TabIndex = 0;
            this.lbMms.Text = "Digite el codigo a buscar: ";
            // 
            // tpCronograma
            // 
            this.tpCronograma.Controls.Add(this.panel2);
            this.tpCronograma.Location = new System.Drawing.Point(4, 29);
            this.tpCronograma.Name = "tpCronograma";
            this.tpCronograma.Size = new System.Drawing.Size(795, 499);
            this.tpCronograma.TabIndex = 3;
            this.tpCronograma.Text = "Cronograma Salud";
            this.tpCronograma.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbTitCronograma);
            this.panel2.Controls.Add(this.dvgCronograma);
            this.panel2.Controls.Add(this.btnCronograma);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 493);
            this.panel2.TabIndex = 0;
            // 
            // lbTitCronograma
            // 
            this.lbTitCronograma.AutoSize = true;
            this.lbTitCronograma.BackColor = System.Drawing.Color.White;
            this.lbTitCronograma.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitCronograma.Location = new System.Drawing.Point(251, 40);
            this.lbTitCronograma.Name = "lbTitCronograma";
            this.lbTitCronograma.Size = new System.Drawing.Size(290, 31);
            this.lbTitCronograma.TabIndex = 7;
            this.lbTitCronograma.Text = "Consultar Cronograma";
            // 
            // dvgCronograma
            // 
            this.dvgCronograma.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dvgCronograma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCronograma.Location = new System.Drawing.Point(120, 162);
            this.dvgCronograma.Name = "dvgCronograma";
            this.dvgCronograma.Size = new System.Drawing.Size(558, 241);
            this.dvgCronograma.TabIndex = 2;
            // 
            // btnCronograma
            // 
            this.btnCronograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCronograma.Location = new System.Drawing.Point(344, 93);
            this.btnCronograma.Name = "btnCronograma";
            this.btnCronograma.Size = new System.Drawing.Size(115, 33);
            this.btnCronograma.TabIndex = 1;
            this.btnCronograma.Text = "Consultar";
            this.btnCronograma.UseVisualStyleBackColor = true;
            this.btnCronograma.Click += new System.EventHandler(this.btnCronograma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.tbcGestion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tbcGestion.ResumeLayout(false);
            this.tpRegistro.ResumeLayout(false);
            this.pnlRegistro.ResumeLayout(false);
            this.pnlRegistro.PerformLayout();
            this.tpConsulta.ResumeLayout(false);
            this.pnlConsulta.ResumeLayout(false);
            this.pnlConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDatos)).EndInit();
            this.tpBusqueda.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tpCronograma.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCronograma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcGestion;
        private System.Windows.Forms.TabPage tpRegistro;
        private System.Windows.Forms.TabPage tpConsulta;
        private System.Windows.Forms.Panel pnlConsulta;
        private System.Windows.Forms.DataGridView dvgDatos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TabPage tpBusqueda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbMms;
        private System.Windows.Forms.TextBox txtBuscarXId;
        private System.Windows.Forms.Label lbResNombre;
        private System.Windows.Forms.Label lbMostrarNombre;
        private System.Windows.Forms.Button btnBuscarXId;
        private System.Windows.Forms.Panel pnlRegistro;
        private System.Windows.Forms.ComboBox cbxHabitat;
        private System.Windows.Forms.Label lbHabitat;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.Label lbEspecie;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.Label lblTitBusqueda;
        private System.Windows.Forms.Label lbTitConsulta;
        private System.Windows.Forms.Label lbMostrarEspecie;
        private System.Windows.Forms.Label lbMostrarTipo;
        private System.Windows.Forms.Label lbMostrarGenero;
        private System.Windows.Forms.Label lbResEspecie;
        private System.Windows.Forms.Label lbResHabitat;
        private System.Windows.Forms.Label lbResTipo;
        private System.Windows.Forms.Label lbResGenero;
        private System.Windows.Forms.Label lbMostrarHabitat;
        private System.Windows.Forms.TabPage tpCronograma;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dvgCronograma;
        private System.Windows.Forms.Button btnCronograma;
        private System.Windows.Forms.Label lbTitCronograma;
    }
}

