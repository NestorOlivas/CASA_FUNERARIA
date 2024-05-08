namespace CASA_FUNERARIA
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.BtnPaquetes = new System.Windows.Forms.Button();
            this.BtnResumen = new System.Windows.Forms.Button();
            this.BtnFichas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CASA_FUNERARIA.Properties.Resources.Logo_CFLE;
            this.pictureBox1.Location = new System.Drawing.Point(21, -41);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 476);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnCliente
            // 
            this.BtnCliente.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCliente.Location = new System.Drawing.Point(10, 400);
            this.BtnCliente.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(104, 73);
            this.BtnCliente.TabIndex = 1;
            this.BtnCliente.Text = "Registro Cliente";
            this.BtnCliente.UseVisualStyleBackColor = false;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // BtnPaquetes
            // 
            this.BtnPaquetes.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnPaquetes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPaquetes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPaquetes.Location = new System.Drawing.Point(234, 400);
            this.BtnPaquetes.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPaquetes.Name = "BtnPaquetes";
            this.BtnPaquetes.Size = new System.Drawing.Size(104, 73);
            this.BtnPaquetes.TabIndex = 2;
            this.BtnPaquetes.Text = "Paquetes";
            this.BtnPaquetes.UseVisualStyleBackColor = false;
            this.BtnPaquetes.Click += new System.EventHandler(this.BtnPaquetes_Click);
            // 
            // BtnResumen
            // 
            this.BtnResumen.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnResumen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnResumen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResumen.Location = new System.Drawing.Point(122, 400);
            this.BtnResumen.Margin = new System.Windows.Forms.Padding(4);
            this.BtnResumen.Name = "BtnResumen";
            this.BtnResumen.Size = new System.Drawing.Size(104, 73);
            this.BtnResumen.TabIndex = 3;
            this.BtnResumen.Text = "Generar Resumen";
            this.BtnResumen.UseVisualStyleBackColor = false;
            this.BtnResumen.Click += new System.EventHandler(this.BtnResumen_Click);
            // 
            // BtnFichas
            // 
            this.BtnFichas.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnFichas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFichas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFichas.Location = new System.Drawing.Point(346, 400);
            this.BtnFichas.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFichas.Name = "BtnFichas";
            this.BtnFichas.Size = new System.Drawing.Size(104, 73);
            this.BtnFichas.TabIndex = 4;
            this.BtnFichas.Text = "Fichas";
            this.BtnFichas.UseVisualStyleBackColor = false;
            this.BtnFichas.Click += new System.EventHandler(this.BtnFichas_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CASA_FUNERARIA.Properties.Resources.miya_geo_panel_textured_wallpaper_natural_by_fine_decor_fd43153_p10063_28630_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(459, 476);
            this.Controls.Add(this.BtnFichas);
            this.Controls.Add(this.BtnResumen);
            this.Controls.Add(this.BtnPaquetes);
            this.Controls.Add(this.BtnCliente);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.Button BtnPaquetes;
        private System.Windows.Forms.Button BtnResumen;
        private System.Windows.Forms.Button BtnFichas;
    }
}