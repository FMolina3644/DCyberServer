namespace Cafe_Daaws_2._0_Servidor.GUI
{
    partial class Frm_Presentacion
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
            this.Tm_Permitido = new System.Windows.Forms.Timer(this.components);
            this.Ptb_Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Tm_Permitido
            // 
            this.Tm_Permitido.Enabled = true;
            this.Tm_Permitido.Interval = 1000;
            this.Tm_Permitido.Tick += new System.EventHandler(this.Tm_Permitido_Tick);
            // 
            // Ptb_Logo
            // 
            this.Ptb_Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ptb_Logo.Image = global::Cafe_Daaws_2._0_Servidor.Properties.Resources.IMG_20150715_WA0018;
            this.Ptb_Logo.Location = new System.Drawing.Point(0, 0);
            this.Ptb_Logo.Name = "Ptb_Logo";
            this.Ptb_Logo.Size = new System.Drawing.Size(580, 312);
            this.Ptb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ptb_Logo.TabIndex = 0;
            this.Ptb_Logo.TabStop = false;
            // 
            // Frm_Presentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 312);
            this.ControlBox = false;
            this.Controls.Add(this.Ptb_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Presentacion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Presentacion";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Presentacion_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Presentacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Tm_Permitido;
        private System.Windows.Forms.PictureBox Ptb_Logo;
    }
}