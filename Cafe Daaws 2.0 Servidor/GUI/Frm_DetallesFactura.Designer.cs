namespace Cafe_Daaws_2._0_Servidor.GUI
{
    partial class Frm_DetallesFactura
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
            this.Lbl_Equipo = new System.Windows.Forms.Label();
            this.Dtg_Detalles = new System.Windows.Forms.DataGridView();
            this.Lbl_TitItems = new System.Windows.Forms.Label();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Pnl_Detalles = new System.Windows.Forms.Panel();
            this.Ptb_DivBusqueda = new System.Windows.Forms.PictureBox();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Pnl_Nuevo = new System.Windows.Forms.Panel();
            this.Btn_Regresar = new System.Windows.Forms.Button();
            this.Lbl_TitNuevo = new System.Windows.Forms.Label();
            this.Txt_Producto = new System.Windows.Forms.TextBox();
            this.Txt_ValorUnidad = new System.Windows.Forms.TextBox();
            this.Txt_Unidades = new System.Windows.Forms.TextBox();
            this.Lbl_ValTotal = new System.Windows.Forms.Label();
            this.Lbl_TitProducto = new System.Windows.Forms.Label();
            this.Lbl_TitValor = new System.Windows.Forms.Label();
            this.Lbl_TitUnid = new System.Windows.Forms.Label();
            this.Lbl_TitTotal = new System.Windows.Forms.Label();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Ptb_DivEdicion = new System.Windows.Forms.PictureBox();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Detalles)).BeginInit();
            this.Pnl_Detalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_DivBusqueda)).BeginInit();
            this.Pnl_Nuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_DivEdicion)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Equipo
            // 
            this.Lbl_Equipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Equipo.BackColor = System.Drawing.Color.LightBlue;
            this.Lbl_Equipo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Equipo.Location = new System.Drawing.Point(199, 6);
            this.Lbl_Equipo.Name = "Lbl_Equipo";
            this.Lbl_Equipo.Size = new System.Drawing.Size(412, 32);
            this.Lbl_Equipo.TabIndex = 0;
            this.Lbl_Equipo.Text = ". . .";
            // 
            // Dtg_Detalles
            // 
            this.Dtg_Detalles.AllowUserToAddRows = false;
            this.Dtg_Detalles.AllowUserToDeleteRows = false;
            this.Dtg_Detalles.AllowUserToResizeColumns = false;
            this.Dtg_Detalles.AllowUserToResizeRows = false;
            this.Dtg_Detalles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dtg_Detalles.BackgroundColor = System.Drawing.Color.White;
            this.Dtg_Detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtg_Detalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.ValorUnidad,
            this.Cantidad,
            this.Subtotal});
            this.Dtg_Detalles.Location = new System.Drawing.Point(4, 28);
            this.Dtg_Detalles.Name = "Dtg_Detalles";
            this.Dtg_Detalles.RowHeadersVisible = false;
            this.Dtg_Detalles.Size = new System.Drawing.Size(403, 169);
            this.Dtg_Detalles.TabIndex = 1;
            this.Dtg_Detalles.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtg_Detalles_CellValueChanged);
            this.Dtg_Detalles.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Dtg_Detalles_DataError);
            // 
            // Lbl_TitItems
            // 
            this.Lbl_TitItems.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Lbl_TitItems.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TitItems.ForeColor = System.Drawing.Color.White;
            this.Lbl_TitItems.Location = new System.Drawing.Point(9, 7);
            this.Lbl_TitItems.Name = "Lbl_TitItems";
            this.Lbl_TitItems.Size = new System.Drawing.Size(131, 16);
            this.Lbl_TitItems.TabIndex = 2;
            this.Lbl_TitItems.Text = "Detalles de factura";
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Salir.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Salir.FlatAppearance.BorderSize = 0;
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Location = new System.Drawing.Point(3, 36);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(185, 30);
            this.Btn_Salir.TabIndex = 11;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Pnl_Detalles
            // 
            this.Pnl_Detalles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Detalles.Controls.Add(this.Btn_Eliminar);
            this.Pnl_Detalles.Controls.Add(this.Dtg_Detalles);
            this.Pnl_Detalles.Controls.Add(this.Lbl_TitItems);
            this.Pnl_Detalles.Location = new System.Drawing.Point(199, 41);
            this.Pnl_Detalles.Name = "Pnl_Detalles";
            this.Pnl_Detalles.Size = new System.Drawing.Size(412, 236);
            this.Pnl_Detalles.TabIndex = 12;
            // 
            // Ptb_DivBusqueda
            // 
            this.Ptb_DivBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Ptb_DivBusqueda.BackColor = System.Drawing.Color.Black;
            this.Ptb_DivBusqueda.Location = new System.Drawing.Point(192, 3);
            this.Ptb_DivBusqueda.Name = "Ptb_DivBusqueda";
            this.Ptb_DivBusqueda.Size = new System.Drawing.Size(1, 275);
            this.Ptb_DivBusqueda.TabIndex = 15;
            this.Ptb_DivBusqueda.TabStop = false;
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Nuevo.FlatAppearance.BorderSize = 0;
            this.Btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Nuevo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Nuevo.Location = new System.Drawing.Point(3, 3);
            this.Btn_Nuevo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(185, 30);
            this.Btn_Nuevo.TabIndex = 13;
            this.Btn_Nuevo.Text = "Agregar Detalle";
            this.Btn_Nuevo.UseVisualStyleBackColor = false;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.Image = global::Cafe_Daaws_2._0_Servidor.Properties.Resources.Recycle_Open;
            this.Btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Eliminar.Location = new System.Drawing.Point(222, 202);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(185, 30);
            this.Btn_Eliminar.TabIndex = 14;
            this.Btn_Eliminar.Text = "Eliminar Detalle";
            this.Btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Pnl_Nuevo
            // 
            this.Pnl_Nuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Nuevo.Controls.Add(this.Ptb_DivEdicion);
            this.Pnl_Nuevo.Controls.Add(this.Btn_Agregar);
            this.Pnl_Nuevo.Controls.Add(this.Lbl_TitTotal);
            this.Pnl_Nuevo.Controls.Add(this.Lbl_TitUnid);
            this.Pnl_Nuevo.Controls.Add(this.Lbl_TitValor);
            this.Pnl_Nuevo.Controls.Add(this.Lbl_TitProducto);
            this.Pnl_Nuevo.Controls.Add(this.Lbl_ValTotal);
            this.Pnl_Nuevo.Controls.Add(this.Txt_Unidades);
            this.Pnl_Nuevo.Controls.Add(this.Txt_ValorUnidad);
            this.Pnl_Nuevo.Controls.Add(this.Txt_Producto);
            this.Pnl_Nuevo.Controls.Add(this.Btn_Regresar);
            this.Pnl_Nuevo.Controls.Add(this.Lbl_TitNuevo);
            this.Pnl_Nuevo.Location = new System.Drawing.Point(199, 41);
            this.Pnl_Nuevo.Name = "Pnl_Nuevo";
            this.Pnl_Nuevo.Size = new System.Drawing.Size(412, 236);
            this.Pnl_Nuevo.TabIndex = 15;
            this.Pnl_Nuevo.Visible = false;
            // 
            // Btn_Regresar
            // 
            this.Btn_Regresar.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Regresar.FlatAppearance.BorderSize = 0;
            this.Btn_Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Regresar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Regresar.Image = global::Cafe_Daaws_2._0_Servidor.Properties.Resources.List;
            this.Btn_Regresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Regresar.Location = new System.Drawing.Point(222, 202);
            this.Btn_Regresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Regresar.Name = "Btn_Regresar";
            this.Btn_Regresar.Size = new System.Drawing.Size(185, 30);
            this.Btn_Regresar.TabIndex = 19;
            this.Btn_Regresar.Text = "Regresar al listado";
            this.Btn_Regresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Regresar.UseVisualStyleBackColor = false;
            this.Btn_Regresar.Click += new System.EventHandler(this.Btn_Regresar_Click);
            // 
            // Lbl_TitNuevo
            // 
            this.Lbl_TitNuevo.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Lbl_TitNuevo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TitNuevo.ForeColor = System.Drawing.Color.White;
            this.Lbl_TitNuevo.Location = new System.Drawing.Point(9, 7);
            this.Lbl_TitNuevo.Name = "Lbl_TitNuevo";
            this.Lbl_TitNuevo.Size = new System.Drawing.Size(131, 16);
            this.Lbl_TitNuevo.TabIndex = 2;
            this.Lbl_TitNuevo.Text = "Agregar Detalle";
            // 
            // Txt_Producto
            // 
            this.Txt_Producto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Producto.Location = new System.Drawing.Point(141, 46);
            this.Txt_Producto.MaxLength = 20;
            this.Txt_Producto.Name = "Txt_Producto";
            this.Txt_Producto.Size = new System.Drawing.Size(235, 29);
            this.Txt_Producto.TabIndex = 15;
            this.Txt_Producto.Leave += new System.EventHandler(this.Txt_Producto_Leave);
            // 
            // Txt_ValorUnidad
            // 
            this.Txt_ValorUnidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ValorUnidad.Location = new System.Drawing.Point(141, 81);
            this.Txt_ValorUnidad.MaxLength = 6;
            this.Txt_ValorUnidad.Name = "Txt_ValorUnidad";
            this.Txt_ValorUnidad.Size = new System.Drawing.Size(103, 29);
            this.Txt_ValorUnidad.TabIndex = 16;
            this.Txt_ValorUnidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_ValorUnidad_KeyPress);
            this.Txt_ValorUnidad.Leave += new System.EventHandler(this.Txt_ValorUnidad_Leave);
            // 
            // Txt_Unidades
            // 
            this.Txt_Unidades.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Unidades.Location = new System.Drawing.Point(141, 116);
            this.Txt_Unidades.MaxLength = 3;
            this.Txt_Unidades.Name = "Txt_Unidades";
            this.Txt_Unidades.Size = new System.Drawing.Size(61, 29);
            this.Txt_Unidades.TabIndex = 17;
            this.Txt_Unidades.TextChanged += new System.EventHandler(this.Txt_Unidades_TextChanged);
            this.Txt_Unidades.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Unidades_KeyPress);
            this.Txt_Unidades.Leave += new System.EventHandler(this.Txt_Unidades_Leave);
            // 
            // Lbl_ValTotal
            // 
            this.Lbl_ValTotal.AutoSize = true;
            this.Lbl_ValTotal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ValTotal.ForeColor = System.Drawing.Color.DarkGreen;
            this.Lbl_ValTotal.Location = new System.Drawing.Point(141, 148);
            this.Lbl_ValTotal.Name = "Lbl_ValTotal";
            this.Lbl_ValTotal.Size = new System.Drawing.Size(24, 30);
            this.Lbl_ValTotal.TabIndex = 18;
            this.Lbl_ValTotal.Text = "0";
            // 
            // Lbl_TitProducto
            // 
            this.Lbl_TitProducto.AutoSize = true;
            this.Lbl_TitProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TitProducto.Location = new System.Drawing.Point(9, 54);
            this.Lbl_TitProducto.Name = "Lbl_TitProducto";
            this.Lbl_TitProducto.Size = new System.Drawing.Size(115, 15);
            this.Lbl_TitProducto.TabIndex = 19;
            this.Lbl_TitProducto.Text = "Producto a adicionar";
            // 
            // Lbl_TitValor
            // 
            this.Lbl_TitValor.AutoSize = true;
            this.Lbl_TitValor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TitValor.Location = new System.Drawing.Point(9, 89);
            this.Lbl_TitValor.Name = "Lbl_TitValor";
            this.Lbl_TitValor.Size = new System.Drawing.Size(97, 15);
            this.Lbl_TitValor.TabIndex = 20;
            this.Lbl_TitValor.Text = "Valor Por Unidad";
            // 
            // Lbl_TitUnid
            // 
            this.Lbl_TitUnid.AutoSize = true;
            this.Lbl_TitUnid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TitUnid.Location = new System.Drawing.Point(9, 124);
            this.Lbl_TitUnid.Name = "Lbl_TitUnid";
            this.Lbl_TitUnid.Size = new System.Drawing.Size(102, 15);
            this.Lbl_TitUnid.TabIndex = 21;
            this.Lbl_TitUnid.Text = "Numero Unidades";
            // 
            // Lbl_TitTotal
            // 
            this.Lbl_TitTotal.AutoSize = true;
            this.Lbl_TitTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TitTotal.Location = new System.Drawing.Point(9, 157);
            this.Lbl_TitTotal.Name = "Lbl_TitTotal";
            this.Lbl_TitTotal.Size = new System.Drawing.Size(33, 15);
            this.Lbl_TitTotal.TabIndex = 22;
            this.Lbl_TitTotal.Text = "Total";
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Agregar.FlatAppearance.BorderSize = 0;
            this.Btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Agregar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar.Image = global::Cafe_Daaws_2._0_Servidor.Properties.Resources.Cart;
            this.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Agregar.Location = new System.Drawing.Point(31, 202);
            this.Btn_Agregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(185, 30);
            this.Btn_Agregar.TabIndex = 18;
            this.Btn_Agregar.Text = "Agregar al carrito";
            this.Btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Agregar.UseVisualStyleBackColor = false;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Ptb_DivEdicion
            // 
            this.Ptb_DivEdicion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Ptb_DivEdicion.BackColor = System.Drawing.Color.Black;
            this.Ptb_DivEdicion.Location = new System.Drawing.Point(9, 194);
            this.Ptb_DivEdicion.Name = "Ptb_DivEdicion";
            this.Ptb_DivEdicion.Size = new System.Drawing.Size(395, 1);
            this.Ptb_DivEdicion.TabIndex = 24;
            this.Ptb_DivEdicion.TabStop = false;
            // 
            // Item
            // 
            this.Item.DataPropertyName = "Producto";
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 120;
            // 
            // ValorUnidad
            // 
            this.ValorUnidad.DataPropertyName = "ValorUnidad";
            this.ValorUnidad.HeaderText = "Vlr. Unidad";
            this.ValorUnidad.Name = "ValorUnidad";
            this.ValorUnidad.ReadOnly = true;
            this.ValorUnidad.Width = 90;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 70;
            // 
            // Subtotal
            // 
            this.Subtotal.DataPropertyName = "ValorTotal";
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // Frm_DetallesFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(616, 284);
            this.Controls.Add(this.Ptb_DivBusqueda);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Lbl_Equipo);
            this.Controls.Add(this.Pnl_Detalles);
            this.Controls.Add(this.Pnl_Nuevo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_DetallesFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalles de Factura";
            this.Load += new System.EventHandler(this.Frm_DetallesFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Detalles)).EndInit();
            this.Pnl_Detalles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_DivBusqueda)).EndInit();
            this.Pnl_Nuevo.ResumeLayout(false);
            this.Pnl_Nuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_DivEdicion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Equipo;
        private System.Windows.Forms.DataGridView Dtg_Detalles;
        private System.Windows.Forms.Label Lbl_TitItems;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Panel Pnl_Detalles;
        private System.Windows.Forms.PictureBox Ptb_DivBusqueda;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Panel Pnl_Nuevo;
        private System.Windows.Forms.Button Btn_Regresar;
        private System.Windows.Forms.Label Lbl_TitNuevo;
        private System.Windows.Forms.TextBox Txt_Unidades;
        private System.Windows.Forms.TextBox Txt_ValorUnidad;
        private System.Windows.Forms.TextBox Txt_Producto;
        private System.Windows.Forms.Label Lbl_ValTotal;
        private System.Windows.Forms.Label Lbl_TitProducto;
        private System.Windows.Forms.Label Lbl_TitValor;
        private System.Windows.Forms.Label Lbl_TitUnid;
        private System.Windows.Forms.Label Lbl_TitTotal;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.PictureBox Ptb_DivEdicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
    }
}