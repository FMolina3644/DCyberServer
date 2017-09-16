namespace Cafe_Daaws_2._0_Servidor.GUI
{
    partial class Frm_Creditos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Creditos));
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Rtb_Body = new System.Windows.Forms.RichTextBox();
            this.Lbl_TitAgadece = new System.Windows.Forms.Label();
            this.Rtb_Agradece = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Tel = new System.Windows.Forms.Label();
            this.Ptb_Logo = new System.Windows.Forms.PictureBox();
            this.Lbl_Correo = new System.Windows.Forms.Label();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(12, 9);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(271, 50);
            this.Lbl_Titulo.TabIndex = 1;
            this.Lbl_Titulo.Text = "Cafe Daaws 2.0";
            // 
            // Rtb_Body
            // 
            this.Rtb_Body.BackColor = System.Drawing.Color.White;
            this.Rtb_Body.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rtb_Body.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rtb_Body.Location = new System.Drawing.Point(12, 81);
            this.Rtb_Body.Name = "Rtb_Body";
            this.Rtb_Body.ReadOnly = true;
            this.Rtb_Body.Size = new System.Drawing.Size(381, 111);
            this.Rtb_Body.TabIndex = 2;
            this.Rtb_Body.Text = resources.GetString("Rtb_Body.Text");
            // 
            // Lbl_TitAgadece
            // 
            this.Lbl_TitAgadece.AutoSize = true;
            this.Lbl_TitAgadece.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TitAgadece.Location = new System.Drawing.Point(8, 207);
            this.Lbl_TitAgadece.Name = "Lbl_TitAgadece";
            this.Lbl_TitAgadece.Size = new System.Drawing.Size(116, 20);
            this.Lbl_TitAgadece.TabIndex = 3;
            this.Lbl_TitAgadece.Text = "Agradecimientos";
            // 
            // Rtb_Agradece
            // 
            this.Rtb_Agradece.BackColor = System.Drawing.Color.White;
            this.Rtb_Agradece.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rtb_Agradece.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rtb_Agradece.Location = new System.Drawing.Point(12, 230);
            this.Rtb_Agradece.Name = "Rtb_Agradece";
            this.Rtb_Agradece.ReadOnly = true;
            this.Rtb_Agradece.Size = new System.Drawing.Size(381, 67);
            this.Rtb_Agradece.TabIndex = 4;
            this.Rtb_Agradece.Text = "Farid Molina - Programador - Fase 1.0, Fase 2.0\nBrayan Torres - Programador - Fas" +
    "e 1.0";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "Para realizar sugerencias o aclarar inquietudes, escríbenos o llámanos:";
            // 
            // Lbl_Tel
            // 
            this.Lbl_Tel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tel.Image = global::Cafe_Daaws_2._0_Servidor.Properties.Resources.Cell;
            this.Lbl_Tel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Tel.Location = new System.Drawing.Point(9, 355);
            this.Lbl_Tel.Name = "Lbl_Tel";
            this.Lbl_Tel.Size = new System.Drawing.Size(144, 30);
            this.Lbl_Tel.TabIndex = 6;
            this.Lbl_Tel.Text = "301 - 733 - 4863";
            this.Lbl_Tel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Ptb_Logo
            // 
            this.Ptb_Logo.Image = global::Cafe_Daaws_2._0_Servidor.Properties.Resources.DaawsLogo;
            this.Ptb_Logo.Location = new System.Drawing.Point(315, 2);
            this.Ptb_Logo.Name = "Ptb_Logo";
            this.Ptb_Logo.Size = new System.Drawing.Size(88, 73);
            this.Ptb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ptb_Logo.TabIndex = 0;
            this.Ptb_Logo.TabStop = false;
            // 
            // Lbl_Correo
            // 
            this.Lbl_Correo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Correo.Image = global::Cafe_Daaws_2._0_Servidor.Properties.Resources.E_Mail;
            this.Lbl_Correo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Correo.Location = new System.Drawing.Point(159, 355);
            this.Lbl_Correo.Name = "Lbl_Correo";
            this.Lbl_Correo.Size = new System.Drawing.Size(204, 30);
            this.Lbl_Correo.TabIndex = 7;
            this.Lbl_Correo.Text = "daawsquilla@gmail.com";
            this.Lbl_Correo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.BackColor = System.Drawing.Color.LightBlue;
            this.Btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cerrar.Location = new System.Drawing.Point(124, 390);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(124, 33);
            this.Btn_Cerrar.TabIndex = 8;
            this.Btn_Cerrar.Text = "Cerrar";
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Frm_Creditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(405, 435);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.Lbl_Correo);
            this.Controls.Add(this.Lbl_Tel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rtb_Agradece);
            this.Controls.Add(this.Lbl_TitAgadece);
            this.Controls.Add(this.Rtb_Body);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.Ptb_Logo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe WP", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_Creditos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ptb_Logo;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.RichTextBox Rtb_Body;
        private System.Windows.Forms.Label Lbl_TitAgadece;
        private System.Windows.Forms.RichTextBox Rtb_Agradece;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Tel;
        private System.Windows.Forms.Label Lbl_Correo;
        private System.Windows.Forms.Button Btn_Cerrar;
    }
}