namespace Cafe_Daaws_2._0_Servidor.GUI
{
    partial class Frm_Principal
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
            this.components = new System.ComponentModel.Container();
            this.Rtb_Mensajes = new System.Windows.Forms.RichTextBox();
            this.Lbl_TitMensajes = new System.Windows.Forms.Label();
            this.Lbl_TitEquipos = new System.Windows.Forms.Label();
            this.Cmb_Equipos = new System.Windows.Forms.ComboBox();
            this.Txt_Mensaje = new System.Windows.Forms.TextBox();
            this.Lbl_SelEquipo = new System.Windows.Forms.Label();
            this.Lbl_Mensaje = new System.Windows.Forms.Label();
            this.Mst_Opciones = new System.Windows.Forms.MenuStrip();
            this.Lbl_Convenciones = new System.Windows.Forms.Label();
            this.Lbl_Disponible = new System.Windows.Forms.Label();
            this.Lbl_Detenido = new System.Windows.Forms.Label();
            this.Lbl_Ocupado = new System.Windows.Forms.Label();
            this.Lbl_Apagado = new System.Windows.Forms.Label();
            this.Lbl_Ilimitado = new System.Windows.Forms.Label();
            this.Tmr_Servidor = new System.Windows.Forms.Timer(this.components);
            this.Tmr_Cliente = new System.Windows.Forms.Timer(this.components);
            this.Tmr_Estados = new System.Windows.Forms.Timer(this.components);
            this.Tmr_Temporales = new System.Windows.Forms.Timer(this.components);
            this.Pnl_Notificaciones = new System.Windows.Forms.Panel();
            this.Lbl_Notif = new System.Windows.Forms.Label();
            this.Ctrl_Terminales = new Cafe_Daaws_2._0_Servidor.CTRL.ContTerminales_CTRL();
            this.Pnl_Notif = new System.Windows.Forms.PictureBox();
            this.Btn_ApagarEquipos = new System.Windows.Forms.Button();
            this.Ptb_Ilimitado = new System.Windows.Forms.PictureBox();
            this.Ptb_Apagado = new System.Windows.Forms.PictureBox();
            this.Ptb_Ocupado = new System.Windows.Forms.PictureBox();
            this.Ptb_Detenido = new System.Windows.Forms.PictureBox();
            this.Ptb_Disponible = new System.Windows.Forms.PictureBox();
            this.Ptb_DivConv = new System.Windows.Forms.PictureBox();
            this.Ptb_DivEquipos = new System.Windows.Forms.PictureBox();
            this.Btn_Enviar = new System.Windows.Forms.Button();
            this.Ptb_DivChat = new System.Windows.Forms.PictureBox();
            this.Tsmi_Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_CambiarUsu = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_VerUltimos = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Div = new System.Windows.Forms.ToolStripSeparator();
            this.Tsmi_Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Auditoria = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Consolidado = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Configuraciones = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Creditos = new System.Windows.Forms.ToolStripMenuItem();
            this.Mst_Opciones.SuspendLayout();
            this.Pnl_Notificaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pnl_Notif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Ilimitado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Apagado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Ocupado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Detenido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Disponible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_DivConv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_DivEquipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_DivChat)).BeginInit();
            this.SuspendLayout();
            // 
            // Rtb_Mensajes
            // 
            this.Rtb_Mensajes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rtb_Mensajes.BackColor = System.Drawing.Color.White;
            this.Rtb_Mensajes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rtb_Mensajes.Location = new System.Drawing.Point(634, 56);
            this.Rtb_Mensajes.Name = "Rtb_Mensajes";
            this.Rtb_Mensajes.ReadOnly = true;
            this.Rtb_Mensajes.Size = new System.Drawing.Size(229, 170);
            this.Rtb_Mensajes.TabIndex = 2;
            this.Rtb_Mensajes.Text = "";
            this.Rtb_Mensajes.TextChanged += new System.EventHandler(this.Rtb_Mensajes_TextChanged);
            // 
            // Lbl_TitMensajes
            // 
            this.Lbl_TitMensajes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_TitMensajes.AutoSize = true;
            this.Lbl_TitMensajes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TitMensajes.Location = new System.Drawing.Point(634, 31);
            this.Lbl_TitMensajes.Name = "Lbl_TitMensajes";
            this.Lbl_TitMensajes.Size = new System.Drawing.Size(73, 21);
            this.Lbl_TitMensajes.TabIndex = 3;
            this.Lbl_TitMensajes.Text = "Mensajes";
            // 
            // Lbl_TitEquipos
            // 
            this.Lbl_TitEquipos.AutoSize = true;
            this.Lbl_TitEquipos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TitEquipos.Location = new System.Drawing.Point(4, 31);
            this.Lbl_TitEquipos.Name = "Lbl_TitEquipos";
            this.Lbl_TitEquipos.Size = new System.Drawing.Size(64, 21);
            this.Lbl_TitEquipos.TabIndex = 4;
            this.Lbl_TitEquipos.Text = "Equipos";
            // 
            // Cmb_Equipos
            // 
            this.Cmb_Equipos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cmb_Equipos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Equipos.FormattingEnabled = true;
            this.Cmb_Equipos.Location = new System.Drawing.Point(635, 245);
            this.Cmb_Equipos.Name = "Cmb_Equipos";
            this.Cmb_Equipos.Size = new System.Drawing.Size(229, 23);
            this.Cmb_Equipos.TabIndex = 5;
            this.Cmb_Equipos.SelectedValueChanged += new System.EventHandler(this.Cmb_Equipos_SelectedValueChanged);
            // 
            // Txt_Mensaje
            // 
            this.Txt_Mensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Mensaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Mensaje.Location = new System.Drawing.Point(635, 285);
            this.Txt_Mensaje.Multiline = true;
            this.Txt_Mensaje.Name = "Txt_Mensaje";
            this.Txt_Mensaje.Size = new System.Drawing.Size(229, 61);
            this.Txt_Mensaje.TabIndex = 6;
            this.Txt_Mensaje.TextChanged += new System.EventHandler(this.Txt_Mensaje_TextChanged);
            // 
            // Lbl_SelEquipo
            // 
            this.Lbl_SelEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_SelEquipo.AutoSize = true;
            this.Lbl_SelEquipo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SelEquipo.Location = new System.Drawing.Point(636, 229);
            this.Lbl_SelEquipo.Name = "Lbl_SelEquipo";
            this.Lbl_SelEquipo.Size = new System.Drawing.Size(150, 13);
            this.Lbl_SelEquipo.TabIndex = 8;
            this.Lbl_SelEquipo.Text = "Seleccione destino del mensaje";
            // 
            // Lbl_Mensaje
            // 
            this.Lbl_Mensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Mensaje.AutoSize = true;
            this.Lbl_Mensaje.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Mensaje.Location = new System.Drawing.Point(636, 271);
            this.Lbl_Mensaje.Name = "Lbl_Mensaje";
            this.Lbl_Mensaje.Size = new System.Drawing.Size(92, 13);
            this.Lbl_Mensaje.TabIndex = 9;
            this.Lbl_Mensaje.Text = "Escriba el mensaje";
            // 
            // Mst_Opciones
            // 
            this.Mst_Opciones.BackColor = System.Drawing.Color.Transparent;
            this.Mst_Opciones.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mst_Opciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsmi_Archivo,
            this.Tsmi_Auditoria,
            this.Tsmi_Consolidado,
            this.Tsmi_Configuraciones,
            this.Tsmi_Creditos});
            this.Mst_Opciones.Location = new System.Drawing.Point(0, 0);
            this.Mst_Opciones.Name = "Mst_Opciones";
            this.Mst_Opciones.Size = new System.Drawing.Size(875, 25);
            this.Mst_Opciones.TabIndex = 10;
            // 
            // Lbl_Convenciones
            // 
            this.Lbl_Convenciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_Convenciones.AutoSize = true;
            this.Lbl_Convenciones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Convenciones.Location = new System.Drawing.Point(5, 346);
            this.Lbl_Convenciones.Name = "Lbl_Convenciones";
            this.Lbl_Convenciones.Size = new System.Drawing.Size(79, 15);
            this.Lbl_Convenciones.TabIndex = 12;
            this.Lbl_Convenciones.Text = "Convenciones";
            // 
            // Lbl_Disponible
            // 
            this.Lbl_Disponible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_Disponible.AutoSize = true;
            this.Lbl_Disponible.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Disponible.Location = new System.Drawing.Point(19, 363);
            this.Lbl_Disponible.Name = "Lbl_Disponible";
            this.Lbl_Disponible.Size = new System.Drawing.Size(65, 17);
            this.Lbl_Disponible.TabIndex = 15;
            this.Lbl_Disponible.Text = "Disponible";
            // 
            // Lbl_Detenido
            // 
            this.Lbl_Detenido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_Detenido.AutoSize = true;
            this.Lbl_Detenido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Detenido.Location = new System.Drawing.Point(128, 363);
            this.Lbl_Detenido.Name = "Lbl_Detenido";
            this.Lbl_Detenido.Size = new System.Drawing.Size(57, 17);
            this.Lbl_Detenido.TabIndex = 17;
            this.Lbl_Detenido.Text = "Detenido";
            // 
            // Lbl_Ocupado
            // 
            this.Lbl_Ocupado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_Ocupado.AutoSize = true;
            this.Lbl_Ocupado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Ocupado.Location = new System.Drawing.Point(226, 363);
            this.Lbl_Ocupado.Name = "Lbl_Ocupado";
            this.Lbl_Ocupado.Size = new System.Drawing.Size(59, 17);
            this.Lbl_Ocupado.TabIndex = 19;
            this.Lbl_Ocupado.Text = "Ocupado";
            // 
            // Lbl_Apagado
            // 
            this.Lbl_Apagado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_Apagado.AutoSize = true;
            this.Lbl_Apagado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Apagado.Location = new System.Drawing.Point(322, 363);
            this.Lbl_Apagado.Name = "Lbl_Apagado";
            this.Lbl_Apagado.Size = new System.Drawing.Size(85, 17);
            this.Lbl_Apagado.TabIndex = 21;
            this.Lbl_Apagado.Text = "Desconectado";
            // 
            // Lbl_Ilimitado
            // 
            this.Lbl_Ilimitado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_Ilimitado.AutoSize = true;
            this.Lbl_Ilimitado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Ilimitado.Location = new System.Drawing.Point(441, 363);
            this.Lbl_Ilimitado.Name = "Lbl_Ilimitado";
            this.Lbl_Ilimitado.Size = new System.Drawing.Size(56, 17);
            this.Lbl_Ilimitado.TabIndex = 23;
            this.Lbl_Ilimitado.Text = "Ilimitado";
            // 
            // Tmr_Servidor
            // 
            this.Tmr_Servidor.Tick += new System.EventHandler(this.Tmr_Servidor_Tick);
            // 
            // Tmr_Cliente
            // 
            this.Tmr_Cliente.Tick += new System.EventHandler(this.Tmr_Cliente_Tick);
            // 
            // Tmr_Estados
            // 
            this.Tmr_Estados.Interval = 5000;
            this.Tmr_Estados.Tick += new System.EventHandler(this.Tmr_Estados_Tick);
            // 
            // Tmr_Temporales
            // 
            this.Tmr_Temporales.Enabled = true;
            this.Tmr_Temporales.Interval = 5000;
            this.Tmr_Temporales.Tick += new System.EventHandler(this.Tmr_Temporales_Tick);
            // 
            // Pnl_Notificaciones
            // 
            this.Pnl_Notificaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Notificaciones.BackColor = System.Drawing.Color.LightBlue;
            this.Pnl_Notificaciones.Controls.Add(this.Lbl_Notif);
            this.Pnl_Notificaciones.Controls.Add(this.Pnl_Notif);
            this.Pnl_Notificaciones.Location = new System.Drawing.Point(0, 386);
            this.Pnl_Notificaciones.Name = "Pnl_Notificaciones";
            this.Pnl_Notificaciones.Size = new System.Drawing.Size(875, 25);
            this.Pnl_Notificaciones.TabIndex = 25;
            // 
            // Lbl_Notif
            // 
            this.Lbl_Notif.AutoSize = true;
            this.Lbl_Notif.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Notif.Location = new System.Drawing.Point(31, 3);
            this.Lbl_Notif.Name = "Lbl_Notif";
            this.Lbl_Notif.Size = new System.Drawing.Size(0, 20);
            this.Lbl_Notif.TabIndex = 27;
            // 
            // Ctrl_Terminales
            // 
            this.Ctrl_Terminales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ctrl_Terminales.AutoScroll = true;
            this.Ctrl_Terminales.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Ctrl_Terminales.Location = new System.Drawing.Point(4, 56);
            this.Ctrl_Terminales.Name = "Ctrl_Terminales";
            this.Ctrl_Terminales.Size = new System.Drawing.Size(617, 250);
            this.Ctrl_Terminales.TabIndex = 0;
            // 
            // Pnl_Notif
            // 
            this.Pnl_Notif.BackgroundImage = global::Cafe_Daaws_2._0_Servidor.Properties.Resources.Massage;
            this.Pnl_Notif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pnl_Notif.Location = new System.Drawing.Point(2, 0);
            this.Pnl_Notif.Name = "Pnl_Notif";
            this.Pnl_Notif.Size = new System.Drawing.Size(26, 25);
            this.Pnl_Notif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pnl_Notif.TabIndex = 26;
            this.Pnl_Notif.TabStop = false;
            // 
            // Btn_ApagarEquipos
            // 
            this.Btn_ApagarEquipos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_ApagarEquipos.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_ApagarEquipos.FlatAppearance.BorderSize = 0;
            this.Btn_ApagarEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ApagarEquipos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ApagarEquipos.Image = global::Cafe_Daaws_2._0_Servidor.Properties.Resources.Network;
            this.Btn_ApagarEquipos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ApagarEquipos.Location = new System.Drawing.Point(4, 316);
            this.Btn_ApagarEquipos.Name = "Btn_ApagarEquipos";
            this.Btn_ApagarEquipos.Size = new System.Drawing.Size(181, 28);
            this.Btn_ApagarEquipos.TabIndex = 24;
            this.Btn_ApagarEquipos.Text = "Apagar Equipos de la Red";
            this.Btn_ApagarEquipos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_ApagarEquipos.UseVisualStyleBackColor = false;
            this.Btn_ApagarEquipos.Click += new System.EventHandler(this.Btn_ApagarEquipos_Click);
            // 
            // Ptb_Ilimitado
            // 
            this.Ptb_Ilimitado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Ptb_Ilimitado.BackColor = System.Drawing.Color.Black;
            this.Ptb_Ilimitado.Location = new System.Drawing.Point(430, 361);
            this.Ptb_Ilimitado.Name = "Ptb_Ilimitado";
            this.Ptb_Ilimitado.Size = new System.Drawing.Size(10, 20);
            this.Ptb_Ilimitado.TabIndex = 22;
            this.Ptb_Ilimitado.TabStop = false;
            // 
            // Ptb_Apagado
            // 
            this.Ptb_Apagado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Ptb_Apagado.BackColor = System.Drawing.Color.DarkRed;
            this.Ptb_Apagado.Location = new System.Drawing.Point(311, 361);
            this.Ptb_Apagado.Name = "Ptb_Apagado";
            this.Ptb_Apagado.Size = new System.Drawing.Size(10, 20);
            this.Ptb_Apagado.TabIndex = 20;
            this.Ptb_Apagado.TabStop = false;
            // 
            // Ptb_Ocupado
            // 
            this.Ptb_Ocupado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Ptb_Ocupado.BackColor = System.Drawing.Color.Yellow;
            this.Ptb_Ocupado.Location = new System.Drawing.Point(215, 361);
            this.Ptb_Ocupado.Name = "Ptb_Ocupado";
            this.Ptb_Ocupado.Size = new System.Drawing.Size(10, 20);
            this.Ptb_Ocupado.TabIndex = 18;
            this.Ptb_Ocupado.TabStop = false;
            // 
            // Ptb_Detenido
            // 
            this.Ptb_Detenido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Ptb_Detenido.BackColor = System.Drawing.Color.Violet;
            this.Ptb_Detenido.Location = new System.Drawing.Point(117, 361);
            this.Ptb_Detenido.Name = "Ptb_Detenido";
            this.Ptb_Detenido.Size = new System.Drawing.Size(10, 20);
            this.Ptb_Detenido.TabIndex = 16;
            this.Ptb_Detenido.TabStop = false;
            // 
            // Ptb_Disponible
            // 
            this.Ptb_Disponible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Ptb_Disponible.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Ptb_Disponible.Location = new System.Drawing.Point(8, 361);
            this.Ptb_Disponible.Name = "Ptb_Disponible";
            this.Ptb_Disponible.Size = new System.Drawing.Size(10, 20);
            this.Ptb_Disponible.TabIndex = 14;
            this.Ptb_Disponible.TabStop = false;
            // 
            // Ptb_DivConv
            // 
            this.Ptb_DivConv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ptb_DivConv.BackColor = System.Drawing.Color.Black;
            this.Ptb_DivConv.Location = new System.Drawing.Point(88, 354);
            this.Ptb_DivConv.Name = "Ptb_DivConv";
            this.Ptb_DivConv.Size = new System.Drawing.Size(532, 1);
            this.Ptb_DivConv.TabIndex = 13;
            this.Ptb_DivConv.TabStop = false;
            // 
            // Ptb_DivEquipos
            // 
            this.Ptb_DivEquipos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ptb_DivEquipos.BackColor = System.Drawing.Color.Black;
            this.Ptb_DivEquipos.Location = new System.Drawing.Point(4, 309);
            this.Ptb_DivEquipos.Name = "Ptb_DivEquipos";
            this.Ptb_DivEquipos.Size = new System.Drawing.Size(617, 1);
            this.Ptb_DivEquipos.TabIndex = 11;
            this.Ptb_DivEquipos.TabStop = false;
            // 
            // Btn_Enviar
            // 
            this.Btn_Enviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Enviar.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Enviar.Enabled = false;
            this.Btn_Enviar.FlatAppearance.BorderSize = 0;
            this.Btn_Enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Enviar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Enviar.Image = global::Cafe_Daaws_2._0_Servidor.Properties.Resources.E_Mail;
            this.Btn_Enviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Enviar.Location = new System.Drawing.Point(682, 349);
            this.Btn_Enviar.Name = "Btn_Enviar";
            this.Btn_Enviar.Size = new System.Drawing.Size(140, 31);
            this.Btn_Enviar.TabIndex = 7;
            this.Btn_Enviar.Text = "Enviar Mensaje";
            this.Btn_Enviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Enviar.UseVisualStyleBackColor = false;
            this.Btn_Enviar.Click += new System.EventHandler(this.Btn_Enviar_Click);
            // 
            // Ptb_DivChat
            // 
            this.Ptb_DivChat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ptb_DivChat.BackColor = System.Drawing.Color.Black;
            this.Ptb_DivChat.Location = new System.Drawing.Point(627, 25);
            this.Ptb_DivChat.Name = "Ptb_DivChat";
            this.Ptb_DivChat.Size = new System.Drawing.Size(1, 360);
            this.Ptb_DivChat.TabIndex = 1;
            this.Ptb_DivChat.TabStop = false;
            // 
            // Tsmi_Archivo
            // 
            this.Tsmi_Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsmi_Usuarios,
            this.Tsmi_CambiarUsu,
            this.Tsmi_VerUltimos,
            this.Tsmi_Div,
            this.Tsmi_Salir});
            this.Tsmi_Archivo.Image = global::Cafe_Daaws_2._0_Servidor.Properties.Resources.Folder1;
            this.Tsmi_Archivo.Name = "Tsmi_Archivo";
            this.Tsmi_Archivo.Size = new System.Drawing.Size(79, 21);
            this.Tsmi_Archivo.Text = "Archivo";
            // 
            // Tsmi_Usuarios
            // 
            this.Tsmi_Usuarios.Image = global::Cafe_Daaws_2._0_Servidor.Properties.Resources.MSN;
            this.Tsmi_Usuarios.Name = "Tsmi_Usuarios";
            this.Tsmi_Usuarios.Size = new System.Drawing.Size(214, 22);
            this.Tsmi_Usuarios.Text = "Administrador Usuarios";
            this.Tsmi_Usuarios.Click += new System.EventHandler(this.Tsmi_Usuarios_Click);
            // 
            // Tsmi_CambiarUsu
            // 
            this.Tsmi_CambiarUsu.Image = global::Cafe_Daaws_2._0_Servidor.Properties.Resources.Contact;
            this.Tsmi_CambiarUsu.Name = "Tsmi_CambiarUsu";
            this.Tsmi_CambiarUsu.Size = new System.Drawing.Size(214, 22);
            this.Tsmi_CambiarUsu.Text = "Cambiar Usuario";
            this.Tsmi_CambiarUsu.Click += new System.EventHandler(this.Tsmi_CambiarUsu_Click);
            // 
            // Tsmi_VerUltimos
            // 
            this.Tsmi_VerUltimos.Image = global::Cafe_Daaws_2._0_Servidor.Properties.Resources.Broadcast;
            this.Tsmi_VerUltimos.Name = "Tsmi_VerUltimos";
            this.Tsmi_VerUltimos.Size = new System.Drawing.Size(214, 22);
            this.Tsmi_VerUltimos.Text = "Ver Ultimas Conexiones";
            this.Tsmi_VerUltimos.Click += new System.EventHandler(this.Tsmi_VerUltimos_Click);
            // 
            // Tsmi_Div
            // 
            this.Tsmi_Div.Name = "Tsmi_Div";
            this.Tsmi_Div.Size = new System.Drawing.Size(211, 6);
            // 
            // Tsmi_Salir
            // 
            this.Tsmi_Salir.Image = global::Cafe_Daaws_2._0_Servidor.Properties.Resources.Closed;
            this.Tsmi_Salir.Name = "Tsmi_Salir";
            this.Tsmi_Salir.Size = new System.Drawing.Size(214, 22);
            this.Tsmi_Salir.Text = "Salir";
            this.Tsmi_Salir.Click += new System.EventHandler(this.Tsmi_Salir_Click);
            // 
            // Tsmi_Auditoria
            // 
            this.Tsmi_Auditoria.Image = global::Cafe_Daaws_2._0_Servidor.Properties.Resources.List;
            this.Tsmi_Auditoria.Name = "Tsmi_Auditoria";
            this.Tsmi_Auditoria.Size = new System.Drawing.Size(89, 21);
            this.Tsmi_Auditoria.Text = "Auditoria";
            this.Tsmi_Auditoria.Click += new System.EventHandler(this.Tsmi_Auditoria_Click);
            // 
            // Tsmi_Consolidado
            // 
            this.Tsmi_Consolidado.Image = global::Cafe_Daaws_2._0_Servidor.Properties.Resources.currency;
            this.Tsmi_Consolidado.Name = "Tsmi_Consolidado";
            this.Tsmi_Consolidado.Size = new System.Drawing.Size(110, 21);
            this.Tsmi_Consolidado.Text = "Consolidado";
            this.Tsmi_Consolidado.Click += new System.EventHandler(this.Tsmi_Consolidado_Click);
            // 
            // Tsmi_Configuraciones
            // 
            this.Tsmi_Configuraciones.Image = global::Cafe_Daaws_2._0_Servidor.Properties.Resources.Work;
            this.Tsmi_Configuraciones.Name = "Tsmi_Configuraciones";
            this.Tsmi_Configuraciones.Size = new System.Drawing.Size(130, 21);
            this.Tsmi_Configuraciones.Text = "Configuraciones";
            this.Tsmi_Configuraciones.Click += new System.EventHandler(this.Tsmi_Configuraciones_Click);
            // 
            // Tsmi_Creditos
            // 
            this.Tsmi_Creditos.Image = global::Cafe_Daaws_2._0_Servidor.Properties.Resources.Videos;
            this.Tsmi_Creditos.Name = "Tsmi_Creditos";
            this.Tsmi_Creditos.Size = new System.Drawing.Size(85, 21);
            this.Tsmi_Creditos.Text = "Creditos";
            this.Tsmi_Creditos.Click += new System.EventHandler(this.Tsmi_Creditos_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 411);
            this.Controls.Add(this.Pnl_Notificaciones);
            this.Controls.Add(this.Btn_ApagarEquipos);
            this.Controls.Add(this.Lbl_Ilimitado);
            this.Controls.Add(this.Ptb_Ilimitado);
            this.Controls.Add(this.Lbl_Apagado);
            this.Controls.Add(this.Ptb_Apagado);
            this.Controls.Add(this.Lbl_Ocupado);
            this.Controls.Add(this.Ptb_Ocupado);
            this.Controls.Add(this.Lbl_Detenido);
            this.Controls.Add(this.Ptb_Detenido);
            this.Controls.Add(this.Lbl_Disponible);
            this.Controls.Add(this.Ptb_Disponible);
            this.Controls.Add(this.Ptb_DivConv);
            this.Controls.Add(this.Lbl_Convenciones);
            this.Controls.Add(this.Ptb_DivEquipos);
            this.Controls.Add(this.Lbl_Mensaje);
            this.Controls.Add(this.Lbl_SelEquipo);
            this.Controls.Add(this.Btn_Enviar);
            this.Controls.Add(this.Txt_Mensaje);
            this.Controls.Add(this.Cmb_Equipos);
            this.Controls.Add(this.Lbl_TitEquipos);
            this.Controls.Add(this.Lbl_TitMensajes);
            this.Controls.Add(this.Rtb_Mensajes);
            this.Controls.Add(this.Ptb_DivChat);
            this.Controls.Add(this.Ctrl_Terminales);
            this.Controls.Add(this.Mst_Opciones);
            this.MainMenuStrip = this.Mst_Opciones;
            this.Name = "Frm_Principal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Frm_Principal_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Principal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Principal_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.Mst_Opciones.ResumeLayout(false);
            this.Mst_Opciones.PerformLayout();
            this.Pnl_Notificaciones.ResumeLayout(false);
            this.Pnl_Notificaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pnl_Notif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Ilimitado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Apagado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Ocupado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Detenido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Disponible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_DivConv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_DivEquipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_DivChat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CTRL.ContTerminales_CTRL Ctrl_Terminales;
        private System.Windows.Forms.PictureBox Ptb_DivChat;
        private System.Windows.Forms.RichTextBox Rtb_Mensajes;
        private System.Windows.Forms.Label Lbl_TitMensajes;
        private System.Windows.Forms.Label Lbl_TitEquipos;
        private System.Windows.Forms.ComboBox Cmb_Equipos;
        private System.Windows.Forms.TextBox Txt_Mensaje;
        private System.Windows.Forms.Button Btn_Enviar;
        private System.Windows.Forms.Label Lbl_SelEquipo;
        private System.Windows.Forms.Label Lbl_Mensaje;
        private System.Windows.Forms.MenuStrip Mst_Opciones;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Archivo;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Auditoria;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Consolidado;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Configuraciones;
        private System.Windows.Forms.PictureBox Ptb_DivEquipos;
        private System.Windows.Forms.Label Lbl_Convenciones;
        private System.Windows.Forms.PictureBox Ptb_DivConv;
        private System.Windows.Forms.PictureBox Ptb_Disponible;
        private System.Windows.Forms.Label Lbl_Disponible;
        private System.Windows.Forms.Label Lbl_Detenido;
        private System.Windows.Forms.PictureBox Ptb_Detenido;
        private System.Windows.Forms.Label Lbl_Ocupado;
        private System.Windows.Forms.PictureBox Ptb_Ocupado;
        private System.Windows.Forms.Label Lbl_Apagado;
        private System.Windows.Forms.PictureBox Ptb_Apagado;
        private System.Windows.Forms.Label Lbl_Ilimitado;
        private System.Windows.Forms.PictureBox Ptb_Ilimitado;
        private System.Windows.Forms.Button Btn_ApagarEquipos;
        private System.Windows.Forms.Timer Tmr_Servidor;
        private System.Windows.Forms.Timer Tmr_Cliente;
        private System.Windows.Forms.Timer Tmr_Estados;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Usuarios;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_CambiarUsu;
        private System.Windows.Forms.ToolStripSeparator Tsmi_Div;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Salir;
        private System.Windows.Forms.Timer Tmr_Temporales;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_VerUltimos;
        private System.Windows.Forms.Panel Pnl_Notificaciones;
        private System.Windows.Forms.PictureBox Pnl_Notif;
        private System.Windows.Forms.Label Lbl_Notif;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Creditos;
    }
}