namespace Cafe_Daaws_2._0_Servidor.GUI
{
    partial class Frm_SelRango
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
            this.Lbl_Descripcion = new System.Windows.Forms.Label();
            this.Cmb_Rango = new System.Windows.Forms.ComboBox();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Pnl_Advertencia = new System.Windows.Forms.Panel();
            this.Lbl_Detalle = new System.Windows.Forms.Label();
            this.Ptb_Idea = new System.Windows.Forms.PictureBox();
            this.Pnl_Advertencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Idea)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Descripcion
            // 
            this.Lbl_Descripcion.AutoSize = true;
            this.Lbl_Descripcion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Descripcion.Location = new System.Drawing.Point(8, 28);
            this.Lbl_Descripcion.Name = "Lbl_Descripcion";
            this.Lbl_Descripcion.Size = new System.Drawing.Size(160, 13);
            this.Lbl_Descripcion.TabIndex = 0;
            this.Lbl_Descripcion.Text = "Selecciona el tiempo a adicionar";
            // 
            // Cmb_Rango
            // 
            this.Cmb_Rango.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Rango.FormattingEnabled = true;
            this.Cmb_Rango.Location = new System.Drawing.Point(8, 44);
            this.Cmb_Rango.Name = "Cmb_Rango";
            this.Cmb_Rango.Size = new System.Drawing.Size(190, 28);
            this.Cmb_Rango.TabIndex = 1;
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Aceptar.FlatAppearance.BorderSize = 0;
            this.Btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Aceptar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Aceptar.Location = new System.Drawing.Point(8, 78);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(190, 27);
            this.Btn_Aceptar.TabIndex = 2;
            this.Btn_Aceptar.Text = "Aplicar";
            this.Btn_Aceptar.UseVisualStyleBackColor = false;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.BackColor = System.Drawing.Color.Azure;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(8, 4);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(190, 24);
            this.Lbl_Titulo.TabIndex = 3;
            this.Lbl_Titulo.Text = ". . .";
            this.Lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Pnl_Advertencia
            // 
            this.Pnl_Advertencia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pnl_Advertencia.Controls.Add(this.Ptb_Idea);
            this.Pnl_Advertencia.Controls.Add(this.Lbl_Detalle);
            this.Pnl_Advertencia.Location = new System.Drawing.Point(1, 111);
            this.Pnl_Advertencia.Name = "Pnl_Advertencia";
            this.Pnl_Advertencia.Size = new System.Drawing.Size(209, 70);
            this.Pnl_Advertencia.TabIndex = 4;
            // 
            // Lbl_Detalle
            // 
            this.Lbl_Detalle.Location = new System.Drawing.Point(54, 2);
            this.Lbl_Detalle.Name = "Lbl_Detalle";
            this.Lbl_Detalle.Size = new System.Drawing.Size(152, 67);
            this.Lbl_Detalle.TabIndex = 0;
            this.Lbl_Detalle.Text = "Tambien puedes ingresar el tiempo en minutos. Por Ejemplo: si vas a ingresar 2 ho" +
    "ras ingresarias 120.";
            // 
            // Ptb_Idea
            // 
            this.Ptb_Idea.BackgroundImage = global::Cafe_Daaws_2._0_Servidor.Properties.Resources.Bulb;
            this.Ptb_Idea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ptb_Idea.Location = new System.Drawing.Point(4, 8);
            this.Ptb_Idea.Name = "Ptb_Idea";
            this.Ptb_Idea.Size = new System.Drawing.Size(48, 48);
            this.Ptb_Idea.TabIndex = 1;
            this.Ptb_Idea.TabStop = false;
            // 
            // Frm_SelRango
            // 
            this.AcceptButton = this.Btn_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(210, 182);
            this.Controls.Add(this.Pnl_Advertencia);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Cmb_Rango);
            this.Controls.Add(this.Lbl_Descripcion);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_SelRango";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Frm_SelRango_Load);
            this.Pnl_Advertencia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Idea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Descripcion;
        private System.Windows.Forms.ComboBox Cmb_Rango;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Panel Pnl_Advertencia;
        private System.Windows.Forms.Label Lbl_Detalle;
        private System.Windows.Forms.PictureBox Ptb_Idea;
    }
}