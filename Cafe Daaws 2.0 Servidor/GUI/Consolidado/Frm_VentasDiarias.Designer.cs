namespace Cafe_Daaws_2._0_Servidor.GUI.Consolidado
{
    partial class Frm_VentasDiarias
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
            this.Dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Ptb_DivBusqueda = new System.Windows.Forms.PictureBox();
            this.Cmb_Usuario = new System.Windows.Forms.ComboBox();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Dtg_Reporte = new System.Windows.Forms.DataGridView();
            this.Btn_ExportarPdf = new System.Windows.Forms.Button();
            this.Lbl_ValRegistros = new System.Windows.Forms.Label();
            this.Lbl_TitRegistros = new System.Windows.Forms.Label();
            this.Lbl_ValFacturado = new System.Windows.Forms.Label();
            this.Lbl_TitFacturado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_DivBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Reporte)).BeginInit();
            this.SuspendLayout();
            // 
            // Dtp_Fecha
            // 
            this.Dtp_Fecha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Fecha.Location = new System.Drawing.Point(10, 28);
            this.Dtp_Fecha.Name = "Dtp_Fecha";
            this.Dtp_Fecha.Size = new System.Drawing.Size(157, 25);
            this.Dtp_Fecha.TabIndex = 6;
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.Location = new System.Drawing.Point(10, 9);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(104, 13);
            this.Lbl_Fecha.TabIndex = 5;
            this.Lbl_Fecha.Text = "Fecha Consolidación";
            // 
            // Ptb_DivBusqueda
            // 
            this.Ptb_DivBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Ptb_DivBusqueda.BackColor = System.Drawing.Color.Black;
            this.Ptb_DivBusqueda.Location = new System.Drawing.Point(175, 9);
            this.Ptb_DivBusqueda.Name = "Ptb_DivBusqueda";
            this.Ptb_DivBusqueda.Size = new System.Drawing.Size(1, 294);
            this.Ptb_DivBusqueda.TabIndex = 4;
            this.Ptb_DivBusqueda.TabStop = false;
            // 
            // Cmb_Usuario
            // 
            this.Cmb_Usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Usuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Usuario.FormattingEnabled = true;
            this.Cmb_Usuario.Location = new System.Drawing.Point(10, 83);
            this.Cmb_Usuario.Name = "Cmb_Usuario";
            this.Cmb_Usuario.Size = new System.Drawing.Size(157, 25);
            this.Cmb_Usuario.TabIndex = 8;
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Usuario.Location = new System.Drawing.Point(10, 67);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(100, 13);
            this.Lbl_Usuario.TabIndex = 7;
            this.Lbl_Usuario.Text = "Seleccionar Usuario";
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Salir.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Salir.FlatAppearance.BorderSize = 0;
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Location = new System.Drawing.Point(7, 150);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(162, 30);
            this.Btn_Salir.TabIndex = 10;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Aceptar.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Aceptar.FlatAppearance.BorderSize = 0;
            this.Btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Aceptar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Aceptar.Location = new System.Drawing.Point(7, 116);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(162, 30);
            this.Btn_Aceptar.TabIndex = 9;
            this.Btn_Aceptar.Text = "Aplicar";
            this.Btn_Aceptar.UseVisualStyleBackColor = false;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
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
            this.Dtg_Reporte.Location = new System.Drawing.Point(181, 45);
            this.Dtg_Reporte.Name = "Dtg_Reporte";
            this.Dtg_Reporte.ReadOnly = true;
            this.Dtg_Reporte.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dtg_Reporte.RowHeadersVisible = false;
            this.Dtg_Reporte.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtg_Reporte.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dtg_Reporte.Size = new System.Drawing.Size(589, 234);
            this.Dtg_Reporte.TabIndex = 12;
            // 
            // Btn_ExportarPdf
            // 
            this.Btn_ExportarPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_ExportarPdf.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_ExportarPdf.FlatAppearance.BorderSize = 0;
            this.Btn_ExportarPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ExportarPdf.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ExportarPdf.Location = new System.Drawing.Point(611, 9);
            this.Btn_ExportarPdf.Name = "Btn_ExportarPdf";
            this.Btn_ExportarPdf.Size = new System.Drawing.Size(159, 30);
            this.Btn_ExportarPdf.TabIndex = 11;
            this.Btn_ExportarPdf.Text = "Exportar a PDF";
            this.Btn_ExportarPdf.UseVisualStyleBackColor = false;
            this.Btn_ExportarPdf.Click += new System.EventHandler(this.Btn_ExportarPdf_Click);
            // 
            // Lbl_ValRegistros
            // 
            this.Lbl_ValRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_ValRegistros.AutoSize = true;
            this.Lbl_ValRegistros.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ValRegistros.Location = new System.Drawing.Point(270, 282);
            this.Lbl_ValRegistros.Name = "Lbl_ValRegistros";
            this.Lbl_ValRegistros.Size = new System.Drawing.Size(15, 17);
            this.Lbl_ValRegistros.TabIndex = 14;
            this.Lbl_ValRegistros.Text = "0";
            // 
            // Lbl_TitRegistros
            // 
            this.Lbl_TitRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_TitRegistros.AutoSize = true;
            this.Lbl_TitRegistros.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TitRegistros.Location = new System.Drawing.Point(182, 282);
            this.Lbl_TitRegistros.Name = "Lbl_TitRegistros";
            this.Lbl_TitRegistros.Size = new System.Drawing.Size(90, 17);
            this.Lbl_TitRegistros.TabIndex = 13;
            this.Lbl_TitRegistros.Text = "Total Registros";
            // 
            // Lbl_ValFacturado
            // 
            this.Lbl_ValFacturado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_ValFacturado.AutoSize = true;
            this.Lbl_ValFacturado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ValFacturado.Location = new System.Drawing.Point(447, 282);
            this.Lbl_ValFacturado.Name = "Lbl_ValFacturado";
            this.Lbl_ValFacturado.Size = new System.Drawing.Size(15, 17);
            this.Lbl_ValFacturado.TabIndex = 16;
            this.Lbl_ValFacturado.Text = "0";
            // 
            // Lbl_TitFacturado
            // 
            this.Lbl_TitFacturado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_TitFacturado.AutoSize = true;
            this.Lbl_TitFacturado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TitFacturado.Location = new System.Drawing.Point(355, 282);
            this.Lbl_TitFacturado.Name = "Lbl_TitFacturado";
            this.Lbl_TitFacturado.Size = new System.Drawing.Size(96, 17);
            this.Lbl_TitFacturado.TabIndex = 15;
            this.Lbl_TitFacturado.Text = "Total Facturado";
            // 
            // Frm_VentasDiarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(775, 313);
            this.Controls.Add(this.Lbl_ValFacturado);
            this.Controls.Add(this.Lbl_TitFacturado);
            this.Controls.Add(this.Lbl_ValRegistros);
            this.Controls.Add(this.Lbl_TitRegistros);
            this.Controls.Add(this.Dtg_Reporte);
            this.Controls.Add(this.Btn_ExportarPdf);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Cmb_Usuario);
            this.Controls.Add(this.Lbl_Usuario);
            this.Controls.Add(this.Dtp_Fecha);
            this.Controls.Add(this.Lbl_Fecha);
            this.Controls.Add(this.Ptb_DivBusqueda);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_VentasDiarias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consolidado Ventas";
            this.Load += new System.EventHandler(this.Frm_VentasDiarias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_DivBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Reporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Dtp_Fecha;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.PictureBox Ptb_DivBusqueda;
        private System.Windows.Forms.ComboBox Cmb_Usuario;
        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.DataGridView Dtg_Reporte;
        private System.Windows.Forms.Button Btn_ExportarPdf;
        private System.Windows.Forms.Label Lbl_ValRegistros;
        private System.Windows.Forms.Label Lbl_TitRegistros;
        private System.Windows.Forms.Label Lbl_ValFacturado;
        private System.Windows.Forms.Label Lbl_TitFacturado;
    }
}