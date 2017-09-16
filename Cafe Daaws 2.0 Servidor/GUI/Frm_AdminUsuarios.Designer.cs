namespace Cafe_Daaws_2._0_Servidor.GUI
{
    partial class Frm_AdminUsuarios
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
            this.Dtg_Usuarios = new System.Windows.Forms.DataGridView();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Pnl_Crear = new System.Windows.Forms.Panel();
            this.Lbl_TipUsuario = new System.Windows.Forms.Label();
            this.Lbl_DetAccionEdic = new System.Windows.Forms.Label();
            this.Btn_RegNuevo = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Ptb_DivCrear = new System.Windows.Forms.PictureBox();
            this.Txt_RepContraseña = new System.Windows.Forms.TextBox();
            this.Lbl_Confirma = new System.Windows.Forms.Label();
            this.Txt_Contraseña = new System.Windows.Forms.TextBox();
            this.Lbl_Contraseña = new System.Windows.Forms.Label();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Pnl_Listas = new System.Windows.Forms.Panel();
            this.Btn_CambiarContra = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Ptb_DivBusqueda = new System.Windows.Forms.PictureBox();
            this.Pnl_Edicion = new System.Windows.Forms.Panel();
            this.Lbl_DetAccion = new System.Windows.Forms.Label();
            this.Lbl_UsuEditar = new System.Windows.Forms.Label();
            this.Btn_RegresarEdit = new System.Windows.Forms.Button();
            this.Btn_GuardarContraseña = new System.Windows.Forms.Button();
            this.Ptb_DivEdicion = new System.Windows.Forms.PictureBox();
            this.Txt_ConfNueContraseña = new System.Windows.Forms.TextBox();
            this.Lbl_ConfNueContraseña = new System.Windows.Forms.Label();
            this.Txt_NueContraseña = new System.Windows.Forms.TextBox();
            this.Lbl_NueContraseña = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Usuarios)).BeginInit();
            this.Pnl_Crear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_DivCrear)).BeginInit();
            this.Pnl_Listas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_DivBusqueda)).BeginInit();
            this.Pnl_Edicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_DivEdicion)).BeginInit();
            this.SuspendLayout();
            // 
            // Dtg_Usuarios
            // 
            this.Dtg_Usuarios.AllowUserToAddRows = false;
            this.Dtg_Usuarios.AllowUserToDeleteRows = false;
            this.Dtg_Usuarios.AllowUserToResizeColumns = false;
            this.Dtg_Usuarios.AllowUserToResizeRows = false;
            this.Dtg_Usuarios.BackgroundColor = System.Drawing.Color.White;
            this.Dtg_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtg_Usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usuario,
            this.TipoUsuario,
            this.Estado});
            this.Dtg_Usuarios.Location = new System.Drawing.Point(3, 4);
            this.Dtg_Usuarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dtg_Usuarios.Name = "Dtg_Usuarios";
            this.Dtg_Usuarios.ReadOnly = true;
            this.Dtg_Usuarios.RowHeadersVisible = false;
            this.Dtg_Usuarios.Size = new System.Drawing.Size(385, 240);
            this.Dtg_Usuarios.TabIndex = 0;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "Usuario";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 150;
            // 
            // TipoUsuario
            // 
            this.TipoUsuario.DataPropertyName = "TipoUsuario";
            this.TipoUsuario.HeaderText = "Tipo Usuario";
            this.TipoUsuario.Name = "TipoUsuario";
            this.TipoUsuario.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Nuevo.FlatAppearance.BorderSize = 0;
            this.Btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Nuevo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Nuevo.Location = new System.Drawing.Point(3, 6);
            this.Btn_Nuevo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(185, 30);
            this.Btn_Nuevo.TabIndex = 1;
            this.Btn_Nuevo.Text = "Nuevo Usuario";
            this.Btn_Nuevo.UseVisualStyleBackColor = false;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Salir.FlatAppearance.BorderSize = 0;
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Location = new System.Drawing.Point(3, 40);
            this.Btn_Salir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(185, 30);
            this.Btn_Salir.TabIndex = 2;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Pnl_Crear
            // 
            this.Pnl_Crear.Controls.Add(this.Lbl_TipUsuario);
            this.Pnl_Crear.Controls.Add(this.Lbl_DetAccionEdic);
            this.Pnl_Crear.Controls.Add(this.Btn_RegNuevo);
            this.Pnl_Crear.Controls.Add(this.Btn_Guardar);
            this.Pnl_Crear.Controls.Add(this.Ptb_DivCrear);
            this.Pnl_Crear.Controls.Add(this.Txt_RepContraseña);
            this.Pnl_Crear.Controls.Add(this.Lbl_Confirma);
            this.Pnl_Crear.Controls.Add(this.Txt_Contraseña);
            this.Pnl_Crear.Controls.Add(this.Lbl_Contraseña);
            this.Pnl_Crear.Controls.Add(this.Txt_Usuario);
            this.Pnl_Crear.Controls.Add(this.Lbl_Usuario);
            this.Pnl_Crear.Location = new System.Drawing.Point(195, 6);
            this.Pnl_Crear.Name = "Pnl_Crear";
            this.Pnl_Crear.Size = new System.Drawing.Size(390, 288);
            this.Pnl_Crear.TabIndex = 4;
            this.Pnl_Crear.Visible = false;
            // 
            // Lbl_TipUsuario
            // 
            this.Lbl_TipUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Lbl_TipUsuario.Location = new System.Drawing.Point(15, 87);
            this.Lbl_TipUsuario.Name = "Lbl_TipUsuario";
            this.Lbl_TipUsuario.Size = new System.Drawing.Size(317, 13);
            this.Lbl_TipUsuario.TabIndex = 12;
            this.Lbl_TipUsuario.Text = "El nombre de usuario no debe contener espacios";
            // 
            // Lbl_DetAccionEdic
            // 
            this.Lbl_DetAccionEdic.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Lbl_DetAccionEdic.ForeColor = System.Drawing.Color.White;
            this.Lbl_DetAccionEdic.Location = new System.Drawing.Point(13, 9);
            this.Lbl_DetAccionEdic.Name = "Lbl_DetAccionEdic";
            this.Lbl_DetAccionEdic.Size = new System.Drawing.Size(121, 16);
            this.Lbl_DetAccionEdic.TabIndex = 11;
            this.Lbl_DetAccionEdic.Text = "Creación Usuario";
            // 
            // Btn_RegNuevo
            // 
            this.Btn_RegNuevo.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_RegNuevo.FlatAppearance.BorderSize = 0;
            this.Btn_RegNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_RegNuevo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RegNuevo.Image = global::Cafe_Daaws_2._0_Servidor.Properties.Resources.MSN;
            this.Btn_RegNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_RegNuevo.Location = new System.Drawing.Point(199, 254);
            this.Btn_RegNuevo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_RegNuevo.Name = "Btn_RegNuevo";
            this.Btn_RegNuevo.Size = new System.Drawing.Size(182, 30);
            this.Btn_RegNuevo.TabIndex = 8;
            this.Btn_RegNuevo.Text = "Regresar al listado";
            this.Btn_RegNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_RegNuevo.UseVisualStyleBackColor = false;
            this.Btn_RegNuevo.Click += new System.EventHandler(this.Btn_RegNuevo_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Guardar.FlatAppearance.BorderSize = 0;
            this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.Image = global::Cafe_Daaws_2._0_Servidor.Properties.Resources.Floppy;
            this.Btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Guardar.Location = new System.Drawing.Point(8, 254);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(185, 30);
            this.Btn_Guardar.TabIndex = 7;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Ptb_DivCrear
            // 
            this.Ptb_DivCrear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Ptb_DivCrear.BackColor = System.Drawing.Color.Black;
            this.Ptb_DivCrear.Location = new System.Drawing.Point(3, 237);
            this.Ptb_DivCrear.Name = "Ptb_DivCrear";
            this.Ptb_DivCrear.Size = new System.Drawing.Size(384, 1);
            this.Ptb_DivCrear.TabIndex = 6;
            this.Ptb_DivCrear.TabStop = false;
            // 
            // Txt_RepContraseña
            // 
            this.Txt_RepContraseña.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_RepContraseña.Location = new System.Drawing.Point(16, 189);
            this.Txt_RepContraseña.Name = "Txt_RepContraseña";
            this.Txt_RepContraseña.Size = new System.Drawing.Size(316, 29);
            this.Txt_RepContraseña.TabIndex = 5;
            this.Txt_RepContraseña.UseSystemPasswordChar = true;
            // 
            // Lbl_Confirma
            // 
            this.Lbl_Confirma.AutoSize = true;
            this.Lbl_Confirma.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Confirma.Location = new System.Drawing.Point(13, 171);
            this.Lbl_Confirma.Name = "Lbl_Confirma";
            this.Lbl_Confirma.Size = new System.Drawing.Size(185, 15);
            this.Lbl_Confirma.TabIndex = 4;
            this.Lbl_Confirma.Text = "Confirme la contraseña ingresada";
            // 
            // Txt_Contraseña
            // 
            this.Txt_Contraseña.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Contraseña.Location = new System.Drawing.Point(16, 126);
            this.Txt_Contraseña.Name = "Txt_Contraseña";
            this.Txt_Contraseña.Size = new System.Drawing.Size(316, 29);
            this.Txt_Contraseña.TabIndex = 3;
            this.Txt_Contraseña.UseSystemPasswordChar = true;
            // 
            // Lbl_Contraseña
            // 
            this.Lbl_Contraseña.AutoSize = true;
            this.Lbl_Contraseña.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Contraseña.Location = new System.Drawing.Point(13, 108);
            this.Lbl_Contraseña.Name = "Lbl_Contraseña";
            this.Lbl_Contraseña.Size = new System.Drawing.Size(208, 15);
            this.Lbl_Contraseña.TabIndex = 2;
            this.Lbl_Contraseña.Text = "Contraseña que utilizará para acceder";
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Usuario.Location = new System.Drawing.Point(16, 56);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(316, 29);
            this.Txt_Usuario.TabIndex = 1;
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Usuario.Location = new System.Drawing.Point(13, 38);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(201, 15);
            this.Lbl_Usuario.TabIndex = 0;
            this.Lbl_Usuario.Text = "Usuario que utilizará en la aplicación";
            // 
            // Pnl_Listas
            // 
            this.Pnl_Listas.Controls.Add(this.Btn_CambiarContra);
            this.Pnl_Listas.Controls.Add(this.Btn_Eliminar);
            this.Pnl_Listas.Controls.Add(this.Dtg_Usuarios);
            this.Pnl_Listas.Location = new System.Drawing.Point(195, 6);
            this.Pnl_Listas.Name = "Pnl_Listas";
            this.Pnl_Listas.Size = new System.Drawing.Size(390, 288);
            this.Pnl_Listas.TabIndex = 5;
            // 
            // Btn_CambiarContra
            // 
            this.Btn_CambiarContra.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_CambiarContra.FlatAppearance.BorderSize = 0;
            this.Btn_CambiarContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CambiarContra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CambiarContra.Image = global::Cafe_Daaws_2._0_Servidor.Properties.Resources.Key;
            this.Btn_CambiarContra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_CambiarContra.Location = new System.Drawing.Point(199, 254);
            this.Btn_CambiarContra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_CambiarContra.Name = "Btn_CambiarContra";
            this.Btn_CambiarContra.Size = new System.Drawing.Size(185, 30);
            this.Btn_CambiarContra.TabIndex = 3;
            this.Btn_CambiarContra.Text = "Cambiar Contraseña";
            this.Btn_CambiarContra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_CambiarContra.UseVisualStyleBackColor = false;
            this.Btn_CambiarContra.Click += new System.EventHandler(this.Btn_CambiarContra_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.Image = global::Cafe_Daaws_2._0_Servidor.Properties.Resources.Recycle_Open;
            this.Btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Eliminar.Location = new System.Drawing.Point(8, 254);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(185, 30);
            this.Btn_Eliminar.TabIndex = 2;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Ptb_DivBusqueda
            // 
            this.Ptb_DivBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Ptb_DivBusqueda.BackColor = System.Drawing.Color.Black;
            this.Ptb_DivBusqueda.Location = new System.Drawing.Point(192, 6);
            this.Ptb_DivBusqueda.Name = "Ptb_DivBusqueda";
            this.Ptb_DivBusqueda.Size = new System.Drawing.Size(1, 288);
            this.Ptb_DivBusqueda.TabIndex = 3;
            this.Ptb_DivBusqueda.TabStop = false;
            // 
            // Pnl_Edicion
            // 
            this.Pnl_Edicion.Controls.Add(this.Lbl_DetAccion);
            this.Pnl_Edicion.Controls.Add(this.Lbl_UsuEditar);
            this.Pnl_Edicion.Controls.Add(this.Btn_RegresarEdit);
            this.Pnl_Edicion.Controls.Add(this.Btn_GuardarContraseña);
            this.Pnl_Edicion.Controls.Add(this.Ptb_DivEdicion);
            this.Pnl_Edicion.Controls.Add(this.Txt_ConfNueContraseña);
            this.Pnl_Edicion.Controls.Add(this.Lbl_ConfNueContraseña);
            this.Pnl_Edicion.Controls.Add(this.Txt_NueContraseña);
            this.Pnl_Edicion.Controls.Add(this.Lbl_NueContraseña);
            this.Pnl_Edicion.Location = new System.Drawing.Point(195, 6);
            this.Pnl_Edicion.Name = "Pnl_Edicion";
            this.Pnl_Edicion.Size = new System.Drawing.Size(390, 288);
            this.Pnl_Edicion.TabIndex = 9;
            this.Pnl_Edicion.Visible = false;
            // 
            // Lbl_DetAccion
            // 
            this.Lbl_DetAccion.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Lbl_DetAccion.ForeColor = System.Drawing.Color.White;
            this.Lbl_DetAccion.Location = new System.Drawing.Point(13, 9);
            this.Lbl_DetAccion.Name = "Lbl_DetAccion";
            this.Lbl_DetAccion.Size = new System.Drawing.Size(121, 16);
            this.Lbl_DetAccion.TabIndex = 10;
            this.Lbl_DetAccion.Text = "Cambio Contraseña";
            // 
            // Lbl_UsuEditar
            // 
            this.Lbl_UsuEditar.BackColor = System.Drawing.Color.White;
            this.Lbl_UsuEditar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_UsuEditar.Location = new System.Drawing.Point(13, 31);
            this.Lbl_UsuEditar.Name = "Lbl_UsuEditar";
            this.Lbl_UsuEditar.Size = new System.Drawing.Size(319, 33);
            this.Lbl_UsuEditar.TabIndex = 9;
            this.Lbl_UsuEditar.Text = ". . .";
            // 
            // Btn_RegresarEdit
            // 
            this.Btn_RegresarEdit.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_RegresarEdit.FlatAppearance.BorderSize = 0;
            this.Btn_RegresarEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_RegresarEdit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RegresarEdit.Image = global::Cafe_Daaws_2._0_Servidor.Properties.Resources.MSN;
            this.Btn_RegresarEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_RegresarEdit.Location = new System.Drawing.Point(199, 254);
            this.Btn_RegresarEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_RegresarEdit.Name = "Btn_RegresarEdit";
            this.Btn_RegresarEdit.Size = new System.Drawing.Size(182, 30);
            this.Btn_RegresarEdit.TabIndex = 8;
            this.Btn_RegresarEdit.Text = "Regresar al listado";
            this.Btn_RegresarEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_RegresarEdit.UseVisualStyleBackColor = false;
            this.Btn_RegresarEdit.Click += new System.EventHandler(this.Btn_RegNuevo_Click);
            // 
            // Btn_GuardarContraseña
            // 
            this.Btn_GuardarContraseña.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_GuardarContraseña.FlatAppearance.BorderSize = 0;
            this.Btn_GuardarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_GuardarContraseña.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GuardarContraseña.Image = global::Cafe_Daaws_2._0_Servidor.Properties.Resources.Floppy;
            this.Btn_GuardarContraseña.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_GuardarContraseña.Location = new System.Drawing.Point(8, 254);
            this.Btn_GuardarContraseña.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_GuardarContraseña.Name = "Btn_GuardarContraseña";
            this.Btn_GuardarContraseña.Size = new System.Drawing.Size(185, 30);
            this.Btn_GuardarContraseña.TabIndex = 7;
            this.Btn_GuardarContraseña.Text = "Guardar";
            this.Btn_GuardarContraseña.UseVisualStyleBackColor = false;
            this.Btn_GuardarContraseña.Click += new System.EventHandler(this.Btn_GuardarContraseña_Click);
            // 
            // Ptb_DivEdicion
            // 
            this.Ptb_DivEdicion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Ptb_DivEdicion.BackColor = System.Drawing.Color.Black;
            this.Ptb_DivEdicion.Location = new System.Drawing.Point(3, 237);
            this.Ptb_DivEdicion.Name = "Ptb_DivEdicion";
            this.Ptb_DivEdicion.Size = new System.Drawing.Size(384, 1);
            this.Ptb_DivEdicion.TabIndex = 6;
            this.Ptb_DivEdicion.TabStop = false;
            // 
            // Txt_ConfNueContraseña
            // 
            this.Txt_ConfNueContraseña.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ConfNueContraseña.Location = new System.Drawing.Point(16, 163);
            this.Txt_ConfNueContraseña.Name = "Txt_ConfNueContraseña";
            this.Txt_ConfNueContraseña.Size = new System.Drawing.Size(316, 29);
            this.Txt_ConfNueContraseña.TabIndex = 5;
            this.Txt_ConfNueContraseña.UseSystemPasswordChar = true;
            // 
            // Lbl_ConfNueContraseña
            // 
            this.Lbl_ConfNueContraseña.AutoSize = true;
            this.Lbl_ConfNueContraseña.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ConfNueContraseña.Location = new System.Drawing.Point(13, 145);
            this.Lbl_ConfNueContraseña.Name = "Lbl_ConfNueContraseña";
            this.Lbl_ConfNueContraseña.Size = new System.Drawing.Size(185, 15);
            this.Lbl_ConfNueContraseña.TabIndex = 4;
            this.Lbl_ConfNueContraseña.Text = "Confirme la contraseña ingresada";
            // 
            // Txt_NueContraseña
            // 
            this.Txt_NueContraseña.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NueContraseña.Location = new System.Drawing.Point(16, 100);
            this.Txt_NueContraseña.Name = "Txt_NueContraseña";
            this.Txt_NueContraseña.Size = new System.Drawing.Size(316, 29);
            this.Txt_NueContraseña.TabIndex = 3;
            this.Txt_NueContraseña.UseSystemPasswordChar = true;
            // 
            // Lbl_NueContraseña
            // 
            this.Lbl_NueContraseña.AutoSize = true;
            this.Lbl_NueContraseña.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NueContraseña.Location = new System.Drawing.Point(13, 82);
            this.Lbl_NueContraseña.Name = "Lbl_NueContraseña";
            this.Lbl_NueContraseña.Size = new System.Drawing.Size(208, 15);
            this.Lbl_NueContraseña.TabIndex = 2;
            this.Lbl_NueContraseña.Text = "Contraseña que utilizará para acceder";
            // 
            // Frm_AdminUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(589, 301);
            this.Controls.Add(this.Ptb_DivBusqueda);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.Pnl_Edicion);
            this.Controls.Add(this.Pnl_Crear);
            this.Controls.Add(this.Pnl_Listas);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_AdminUsuarios";
            this.Text = "Administrador de Usuarios";
            this.Load += new System.EventHandler(this.Frm_AdminUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Usuarios)).EndInit();
            this.Pnl_Crear.ResumeLayout(false);
            this.Pnl_Crear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_DivCrear)).EndInit();
            this.Pnl_Listas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_DivBusqueda)).EndInit();
            this.Pnl_Edicion.ResumeLayout(false);
            this.Pnl_Edicion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_DivEdicion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dtg_Usuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.PictureBox Ptb_DivBusqueda;
        private System.Windows.Forms.Panel Pnl_Crear;
        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.TextBox Txt_Contraseña;
        private System.Windows.Forms.Label Lbl_Contraseña;
        private System.Windows.Forms.TextBox Txt_RepContraseña;
        private System.Windows.Forms.Label Lbl_Confirma;
        private System.Windows.Forms.PictureBox Ptb_DivCrear;
        private System.Windows.Forms.Button Btn_RegNuevo;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Panel Pnl_Listas;
        private System.Windows.Forms.Button Btn_CambiarContra;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Panel Pnl_Edicion;
        private System.Windows.Forms.Button Btn_RegresarEdit;
        private System.Windows.Forms.Button Btn_GuardarContraseña;
        private System.Windows.Forms.PictureBox Ptb_DivEdicion;
        private System.Windows.Forms.TextBox Txt_ConfNueContraseña;
        private System.Windows.Forms.Label Lbl_ConfNueContraseña;
        private System.Windows.Forms.TextBox Txt_NueContraseña;
        private System.Windows.Forms.Label Lbl_NueContraseña;
        private System.Windows.Forms.Label Lbl_UsuEditar;
        private System.Windows.Forms.Label Lbl_DetAccion;
        private System.Windows.Forms.Label Lbl_DetAccionEdic;
        private System.Windows.Forms.Label Lbl_TipUsuario;
    }
}