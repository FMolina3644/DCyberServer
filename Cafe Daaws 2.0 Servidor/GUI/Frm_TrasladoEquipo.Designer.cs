namespace Cafe_Daaws_2._0_Servidor.GUI
{
    partial class Frm_TrasladoEquipo
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
            this.Lbl_Origen = new System.Windows.Forms.Label();
            this.Lbl_Destino = new System.Windows.Forms.Label();
            this.Cmb_Destino = new System.Windows.Forms.ComboBox();
            this.Btn_Traslado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Origen
            // 
            this.Lbl_Origen.BackColor = System.Drawing.Color.LightCoral;
            this.Lbl_Origen.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Origen.Location = new System.Drawing.Point(9, 7);
            this.Lbl_Origen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Origen.Name = "Lbl_Origen";
            this.Lbl_Origen.Size = new System.Drawing.Size(227, 27);
            this.Lbl_Origen.TabIndex = 0;
            this.Lbl_Origen.Text = "De:";
            // 
            // Lbl_Destino
            // 
            this.Lbl_Destino.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Lbl_Destino.Location = new System.Drawing.Point(9, 38);
            this.Lbl_Destino.Name = "Lbl_Destino";
            this.Lbl_Destino.Size = new System.Drawing.Size(228, 38);
            this.Lbl_Destino.TabIndex = 1;
            this.Lbl_Destino.Text = "A:";
            // 
            // Cmb_Destino
            // 
            this.Cmb_Destino.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Cmb_Destino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Destino.FormattingEnabled = true;
            this.Cmb_Destino.Location = new System.Drawing.Point(41, 42);
            this.Cmb_Destino.Name = "Cmb_Destino";
            this.Cmb_Destino.Size = new System.Drawing.Size(191, 28);
            this.Cmb_Destino.TabIndex = 2;
            // 
            // Btn_Traslado
            // 
            this.Btn_Traslado.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Traslado.FlatAppearance.BorderSize = 0;
            this.Btn_Traslado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Traslado.Location = new System.Drawing.Point(9, 79);
            this.Btn_Traslado.Name = "Btn_Traslado";
            this.Btn_Traslado.Size = new System.Drawing.Size(228, 27);
            this.Btn_Traslado.TabIndex = 3;
            this.Btn_Traslado.Text = "Aplicar";
            this.Btn_Traslado.UseVisualStyleBackColor = false;
            this.Btn_Traslado.Click += new System.EventHandler(this.Btn_Traslado_Click);
            // 
            // Frm_TrasladoEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(245, 114);
            this.Controls.Add(this.Btn_Traslado);
            this.Controls.Add(this.Cmb_Destino);
            this.Controls.Add(this.Lbl_Destino);
            this.Controls.Add(this.Lbl_Origen);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_TrasladoEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_TrasladoEquipo_FormClosing);
            this.Load += new System.EventHandler(this.Frm_TrasladoEquipo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Origen;
        private System.Windows.Forms.Label Lbl_Destino;
        private System.Windows.Forms.ComboBox Cmb_Destino;
        private System.Windows.Forms.Button Btn_Traslado;
    }
}