namespace Cafe_Daaws_2._0_Servidor.GUI.Auditoria
{
    partial class Frm_Auditoria
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
            this.Ptb_DivBusqueda = new System.Windows.Forms.PictureBox();
            this.Pnl_Acciones = new System.Windows.Forms.Panel();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Cmb_Usuario = new System.Windows.Forms.ComboBox();
            this.Lbl_Acciones = new System.Windows.Forms.Label();
            this.Chb_IniSesion = new System.Windows.Forms.CheckBox();
            this.Chb_CieSesion = new System.Windows.Forms.CheckBox();
            this.Chb_AsigTiempo = new System.Windows.Forms.CheckBox();
            this.Chb_AnuFactura = new System.Windows.Forms.CheckBox();
            this.Chb_TraTiempo = new System.Windows.Forms.CheckBox();
            this.Chb_FacTiempo = new System.Windows.Forms.CheckBox();
            this.Chb_Todos = new System.Windows.Forms.CheckBox();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_ExportarPdf = new System.Windows.Forms.Button();
            this.Dtg_Reporte = new System.Windows.Forms.DataGridView();
            this.Lbl_TitRegistros = new System.Windows.Forms.Label();
            this.Lbl_ValRegistros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_DivBusqueda)).BeginInit();
            this.Pnl_Acciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Reporte)).BeginInit();
            this.SuspendLayout();
            // 
            // Ptb_DivBusqueda
            // 
            this.Ptb_DivBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Ptb_DivBusqueda.BackColor = System.Drawing.Color.Black;
            this.Ptb_DivBusqueda.Location = new System.Drawing.Point(168, 9);
            this.Ptb_DivBusqueda.Name = "Ptb_DivBusqueda";
            this.Ptb_DivBusqueda.Size = new System.Drawing.Size(1, 375);
            this.Ptb_DivBusqueda.TabIndex = 0;
            this.Ptb_DivBusqueda.TabStop = false;
            // 
            // Pnl_Acciones
            // 
            this.Pnl_Acciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Pnl_Acciones.AutoScroll = true;
            this.Pnl_Acciones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pnl_Acciones.Controls.Add(this.Chb_Todos);
            this.Pnl_Acciones.Controls.Add(this.Chb_FacTiempo);
            this.Pnl_Acciones.Controls.Add(this.Chb_TraTiempo);
            this.Pnl_Acciones.Controls.Add(this.Chb_AnuFactura);
            this.Pnl_Acciones.Controls.Add(this.Chb_AsigTiempo);
            this.Pnl_Acciones.Controls.Add(this.Chb_CieSesion);
            this.Pnl_Acciones.Controls.Add(this.Chb_IniSesion);
            this.Pnl_Acciones.Location = new System.Drawing.Point(2, 130);
            this.Pnl_Acciones.Name = "Pnl_Acciones";
            this.Pnl_Acciones.Size = new System.Drawing.Size(162, 184);
            this.Pnl_Acciones.TabIndex = 1;
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.Location = new System.Drawing.Point(4, 9);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(73, 13);
            this.Lbl_Fecha.TabIndex = 2;
            this.Lbl_Fecha.Text = "Fecha Auditar";
            // 
            // Dtp_Fecha
            // 
            this.Dtp_Fecha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Fecha.Location = new System.Drawing.Point(7, 25);
            this.Dtp_Fecha.Name = "Dtp_Fecha";
            this.Dtp_Fecha.Size = new System.Drawing.Size(157, 25);
            this.Dtp_Fecha.TabIndex = 3;
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Usuario.Location = new System.Drawing.Point(4, 62);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(100, 13);
            this.Lbl_Usuario.TabIndex = 4;
            this.Lbl_Usuario.Text = "Seleccionar Usuario";
            // 
            // Cmb_Usuario
            // 
            this.Cmb_Usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Usuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Usuario.FormattingEnabled = true;
            this.Cmb_Usuario.Location = new System.Drawing.Point(7, 78);
            this.Cmb_Usuario.Name = "Cmb_Usuario";
            this.Cmb_Usuario.Size = new System.Drawing.Size(157, 25);
            this.Cmb_Usuario.TabIndex = 5;
            // 
            // Lbl_Acciones
            // 
            this.Lbl_Acciones.AutoSize = true;
            this.Lbl_Acciones.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Acciones.Location = new System.Drawing.Point(4, 114);
            this.Lbl_Acciones.Name = "Lbl_Acciones";
            this.Lbl_Acciones.Size = new System.Drawing.Size(104, 13);
            this.Lbl_Acciones.TabIndex = 6;
            this.Lbl_Acciones.Text = "Seleccionar Acciones";
            // 
            // Chb_IniSesion
            // 
            this.Chb_IniSesion.AutoSize = true;
            this.Chb_IniSesion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chb_IniSesion.Location = new System.Drawing.Point(5, 3);
            this.Chb_IniSesion.Name = "Chb_IniSesion";
            this.Chb_IniSesion.Size = new System.Drawing.Size(94, 21);
            this.Chb_IniSesion.TabIndex = 0;
            this.Chb_IniSesion.Tag = "1";
            this.Chb_IniSesion.Text = "Inició Sesión";
            this.Chb_IniSesion.UseVisualStyleBackColor = true;
            // 
            // Chb_CieSesion
            // 
            this.Chb_CieSesion.AutoSize = true;
            this.Chb_CieSesion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chb_CieSesion.Location = new System.Drawing.Point(5, 28);
            this.Chb_CieSesion.Name = "Chb_CieSesion";
            this.Chb_CieSesion.Size = new System.Drawing.Size(96, 21);
            this.Chb_CieSesion.TabIndex = 1;
            this.Chb_CieSesion.Tag = "2";
            this.Chb_CieSesion.Text = "Cerró Sesión";
            this.Chb_CieSesion.UseVisualStyleBackColor = true;
            // 
            // Chb_AsigTiempo
            // 
            this.Chb_AsigTiempo.AutoSize = true;
            this.Chb_AsigTiempo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chb_AsigTiempo.Location = new System.Drawing.Point(5, 53);
            this.Chb_AsigTiempo.Name = "Chb_AsigTiempo";
            this.Chb_AsigTiempo.Size = new System.Drawing.Size(109, 21);
            this.Chb_AsigTiempo.TabIndex = 2;
            this.Chb_AsigTiempo.Tag = "3";
            this.Chb_AsigTiempo.Text = "Asignó Tiempo";
            this.Chb_AsigTiempo.UseVisualStyleBackColor = true;
            // 
            // Chb_AnuFactura
            // 
            this.Chb_AnuFactura.AutoSize = true;
            this.Chb_AnuFactura.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chb_AnuFactura.Location = new System.Drawing.Point(5, 78);
            this.Chb_AnuFactura.Name = "Chb_AnuFactura";
            this.Chb_AnuFactura.Size = new System.Drawing.Size(105, 21);
            this.Chb_AnuFactura.TabIndex = 3;
            this.Chb_AnuFactura.Tag = "4";
            this.Chb_AnuFactura.Text = "Anuló Factura";
            this.Chb_AnuFactura.UseVisualStyleBackColor = true;
            // 
            // Chb_TraTiempo
            // 
            this.Chb_TraTiempo.AutoSize = true;
            this.Chb_TraTiempo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chb_TraTiempo.Location = new System.Drawing.Point(5, 103);
            this.Chb_TraTiempo.Name = "Chb_TraTiempo";
            this.Chb_TraTiempo.Size = new System.Drawing.Size(120, 21);
            this.Chb_TraTiempo.TabIndex = 4;
            this.Chb_TraTiempo.Tag = "5";
            this.Chb_TraTiempo.Text = "Trasladó Tiempo";
            this.Chb_TraTiempo.UseVisualStyleBackColor = true;
            // 
            // Chb_FacTiempo
            // 
            this.Chb_FacTiempo.AutoSize = true;
            this.Chb_FacTiempo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chb_FacTiempo.Location = new System.Drawing.Point(5, 128);
            this.Chb_FacTiempo.Name = "Chb_FacTiempo";
            this.Chb_FacTiempo.Size = new System.Drawing.Size(114, 21);
            this.Chb_FacTiempo.TabIndex = 5;
            this.Chb_FacTiempo.Tag = "6";
            this.Chb_FacTiempo.Text = "Facturó Tiempo";
            this.Chb_FacTiempo.UseVisualStyleBackColor = true;
            // 
            // Chb_Todos
            // 
            this.Chb_Todos.AutoSize = true;
            this.Chb_Todos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chb_Todos.Location = new System.Drawing.Point(3, 153);
            this.Chb_Todos.Name = "Chb_Todos";
            this.Chb_Todos.Size = new System.Drawing.Size(60, 21);
            this.Chb_Todos.TabIndex = 6;
            this.Chb_Todos.Text = "Todos";
            this.Chb_Todos.UseVisualStyleBackColor = true;
            this.Chb_Todos.CheckedChanged += new System.EventHandler(this.Chb_Todos_CheckedChanged);
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Aceptar.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Aceptar.FlatAppearance.BorderSize = 0;
            this.Btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Aceptar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Aceptar.Location = new System.Drawing.Point(2, 319);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(162, 30);
            this.Btn_Aceptar.TabIndex = 7;
            this.Btn_Aceptar.Text = "Aplicar";
            this.Btn_Aceptar.UseVisualStyleBackColor = false;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Salir.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Salir.FlatAppearance.BorderSize = 0;
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Location = new System.Drawing.Point(2, 353);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(162, 30);
            this.Btn_Salir.TabIndex = 8;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_ExportarPdf
            // 
            this.Btn_ExportarPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_ExportarPdf.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_ExportarPdf.FlatAppearance.BorderSize = 0;
            this.Btn_ExportarPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ExportarPdf.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ExportarPdf.Location = new System.Drawing.Point(562, 4);
            this.Btn_ExportarPdf.Name = "Btn_ExportarPdf";
            this.Btn_ExportarPdf.Size = new System.Drawing.Size(159, 30);
            this.Btn_ExportarPdf.TabIndex = 9;
            this.Btn_ExportarPdf.Text = "Exportar a PDF";
            this.Btn_ExportarPdf.UseVisualStyleBackColor = false;
            this.Btn_ExportarPdf.Click += new System.EventHandler(this.Btn_ExportarPdf_Click);
            // 
            // Dtg_Reporte
            // 
            this.Dtg_Reporte.AllowUserToAddRows = false;
            this.Dtg_Reporte.AllowUserToDeleteRows = false;
            this.Dtg_Reporte.AllowUserToResizeColumns = false;
            this.Dtg_Reporte.AllowUserToResizeRows = false;
            this.Dtg_Reporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dtg_Reporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dtg_Reporte.BackgroundColor = System.Drawing.Color.White;
            this.Dtg_Reporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtg_Reporte.Location = new System.Drawing.Point(172, 40);
            this.Dtg_Reporte.Name = "Dtg_Reporte";
            this.Dtg_Reporte.ReadOnly = true;
            this.Dtg_Reporte.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dtg_Reporte.RowHeadersVisible = false;
            this.Dtg_Reporte.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtg_Reporte.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dtg_Reporte.Size = new System.Drawing.Size(549, 327);
            this.Dtg_Reporte.TabIndex = 10;
            // 
            // Lbl_TitRegistros
            // 
            this.Lbl_TitRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_TitRegistros.AutoSize = true;
            this.Lbl_TitRegistros.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TitRegistros.Location = new System.Drawing.Point(175, 370);
            this.Lbl_TitRegistros.Name = "Lbl_TitRegistros";
            this.Lbl_TitRegistros.Size = new System.Drawing.Size(90, 17);
            this.Lbl_TitRegistros.TabIndex = 11;
            this.Lbl_TitRegistros.Text = "Total Registros";
            // 
            // Lbl_ValRegistros
            // 
            this.Lbl_ValRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_ValRegistros.AutoSize = true;
            this.Lbl_ValRegistros.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ValRegistros.Location = new System.Drawing.Point(263, 370);
            this.Lbl_ValRegistros.Name = "Lbl_ValRegistros";
            this.Lbl_ValRegistros.Size = new System.Drawing.Size(15, 17);
            this.Lbl_ValRegistros.TabIndex = 12;
            this.Lbl_ValRegistros.Text = "0";
            // 
            // Frm_Auditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 393);
            this.Controls.Add(this.Lbl_ValRegistros);
            this.Controls.Add(this.Lbl_TitRegistros);
            this.Controls.Add(this.Dtg_Reporte);
            this.Controls.Add(this.Btn_ExportarPdf);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Lbl_Acciones);
            this.Controls.Add(this.Cmb_Usuario);
            this.Controls.Add(this.Lbl_Usuario);
            this.Controls.Add(this.Dtp_Fecha);
            this.Controls.Add(this.Lbl_Fecha);
            this.Controls.Add(this.Pnl_Acciones);
            this.Controls.Add(this.Ptb_DivBusqueda);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_Auditoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Auditoría";
            this.Load += new System.EventHandler(this.Frm_Auditoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_DivBusqueda)).EndInit();
            this.Pnl_Acciones.ResumeLayout(false);
            this.Pnl_Acciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Reporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ptb_DivBusqueda;
        private System.Windows.Forms.Panel Pnl_Acciones;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha;
        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.ComboBox Cmb_Usuario;
        private System.Windows.Forms.Label Lbl_Acciones;
        private System.Windows.Forms.CheckBox Chb_Todos;
        private System.Windows.Forms.CheckBox Chb_FacTiempo;
        private System.Windows.Forms.CheckBox Chb_TraTiempo;
        private System.Windows.Forms.CheckBox Chb_AnuFactura;
        private System.Windows.Forms.CheckBox Chb_AsigTiempo;
        private System.Windows.Forms.CheckBox Chb_CieSesion;
        private System.Windows.Forms.CheckBox Chb_IniSesion;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_ExportarPdf;
        private System.Windows.Forms.DataGridView Dtg_Reporte;
        private System.Windows.Forms.Label Lbl_TitRegistros;
        private System.Windows.Forms.Label Lbl_ValRegistros;
    }
}