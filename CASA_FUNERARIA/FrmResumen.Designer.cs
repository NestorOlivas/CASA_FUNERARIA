namespace CASA_FUNERARIA
{
    partial class FrmResumen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmResumen));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.LBMOSTRARENGACHE = new System.Windows.Forms.Label();
            this.LBMOSTRARMESES = new System.Windows.Forms.Label();
            this.LBMOSTRARMENSUALIDAD = new System.Windows.Forms.Label();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbPlan = new System.Windows.Forms.ComboBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label8 = new System.Windows.Forms.Label();
            this.LBCANTIDADFINANCIAR = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(584, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(444, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Resumen de la Adquisición de Plan Funerario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(465, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Plan Sugerido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(465, 529);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "ENGANCHE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(465, 562);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "MESES";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(465, 599);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "MENSUALIDAD";
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnClear.Location = new System.Drawing.Point(779, 641);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(175, 33);
            this.BtnClear.TabIndex = 18;
            this.BtnClear.Text = "Limpiar";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(593, 529);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 24);
            this.label7.TabIndex = 19;
            // 
            // LBMOSTRARENGACHE
            // 
            this.LBMOSTRARENGACHE.AutoSize = true;
            this.LBMOSTRARENGACHE.BackColor = System.Drawing.Color.Transparent;
            this.LBMOSTRARENGACHE.Enabled = false;
            this.LBMOSTRARENGACHE.Location = new System.Drawing.Point(599, 529);
            this.LBMOSTRARENGACHE.Name = "LBMOSTRARENGACHE";
            this.LBMOSTRARENGACHE.Size = new System.Drawing.Size(16, 24);
            this.LBMOSTRARENGACHE.TabIndex = 20;
            this.LBMOSTRARENGACHE.Text = ".";
            // 
            // LBMOSTRARMESES
            // 
            this.LBMOSTRARMESES.AutoSize = true;
            this.LBMOSTRARMESES.BackColor = System.Drawing.Color.Transparent;
            this.LBMOSTRARMESES.Enabled = false;
            this.LBMOSTRARMESES.Location = new System.Drawing.Point(599, 562);
            this.LBMOSTRARMESES.Name = "LBMOSTRARMESES";
            this.LBMOSTRARMESES.Size = new System.Drawing.Size(16, 24);
            this.LBMOSTRARMESES.TabIndex = 21;
            this.LBMOSTRARMESES.Text = ".";
            // 
            // LBMOSTRARMENSUALIDAD
            // 
            this.LBMOSTRARMENSUALIDAD.AutoSize = true;
            this.LBMOSTRARMENSUALIDAD.BackColor = System.Drawing.Color.Transparent;
            this.LBMOSTRARMENSUALIDAD.Enabled = false;
            this.LBMOSTRARMENSUALIDAD.Location = new System.Drawing.Point(599, 599);
            this.LBMOSTRARMENSUALIDAD.Name = "LBMOSTRARMENSUALIDAD";
            this.LBMOSTRARMENSUALIDAD.Size = new System.Drawing.Size(16, 24);
            this.LBMOSTRARMENSUALIDAD.TabIndex = 22;
            this.LBMOSTRARMENSUALIDAD.Text = ".";
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnImprimir.Location = new System.Drawing.Point(597, 641);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(175, 33);
            this.BtnImprimir.TabIndex = 23;
            this.BtnImprimir.Text = "Imprimir Resumen";
            this.BtnImprimir.UseVisualStyleBackColor = false;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CASA_FUNERARIA.Properties.Resources.Logo_CFLE;
            this.pictureBox1.Location = new System.Drawing.Point(597, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(603, 417);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(339, 30);
            this.txtCliente.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(469, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Cliente";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBuscar.Location = new System.Drawing.Point(948, 416);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(136, 33);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbPlan
            // 
            this.cbPlan.FormattingEnabled = true;
            this.cbPlan.Items.AddRange(new object[] {
            "ECONOMICO",
            "ESTANDAR",
            "ORO",
            "DIAMANTE"});
            this.cbPlan.Location = new System.Drawing.Point(606, 469);
            this.cbPlan.Name = "cbPlan";
            this.cbPlan.Size = new System.Drawing.Size(336, 32);
            this.cbPlan.TabIndex = 28;
            this.cbPlan.SelectedIndexChanged += new System.EventHandler(this.cbPlan_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(847, 529);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(237, 24);
            this.label8.TabIndex = 29;
            this.label8.Text = "CANTIDAD A FINANCIAR";
            // 
            // LBCANTIDADFINANCIAR
            // 
            this.LBCANTIDADFINANCIAR.AutoSize = true;
            this.LBCANTIDADFINANCIAR.BackColor = System.Drawing.Color.Transparent;
            this.LBCANTIDADFINANCIAR.Enabled = false;
            this.LBCANTIDADFINANCIAR.Location = new System.Drawing.Point(926, 562);
            this.LBCANTIDADFINANCIAR.Name = "LBCANTIDADFINANCIAR";
            this.LBCANTIDADFINANCIAR.Size = new System.Drawing.Size(16, 24);
            this.LBCANTIDADFINANCIAR.TabIndex = 30;
            this.LBCANTIDADFINANCIAR.Text = ".";
            // 
            // FrmResumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CASA_FUNERARIA.Properties.Resources.wanderlust_vertical_texture_beige_wallpaper_from_wall_fashion_by_grandeco_pm1315_p10132_28940_zoom;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1528, 796);
            this.Controls.Add(this.LBCANTIDADFINANCIAR);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbPlan);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.LBMOSTRARMENSUALIDAD);
            this.Controls.Add(this.LBMOSTRARMESES);
            this.Controls.Add(this.LBMOSTRARENGACHE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmResumen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmResumen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LBMOSTRARENGACHE;
        private System.Windows.Forms.Label LBMOSTRARMESES;
        private System.Windows.Forms.Label LBMOSTRARMENSUALIDAD;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbPlan;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LBCANTIDADFINANCIAR;
    }
}