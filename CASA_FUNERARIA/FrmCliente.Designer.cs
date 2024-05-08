namespace CASA_FUNERARIA
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.TXTNOMBRE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTDOMICILIO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CBHIJOS = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTINGRESOMENSUAL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTINGRESOSACOMULABLES = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TXTPLANSUGERIDO = new System.Windows.Forms.TextBox();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.CBESTADOCIVIL = new System.Windows.Forms.ComboBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnRegresarregistroC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(473, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // TXTNOMBRE
            // 
            this.TXTNOMBRE.Location = new System.Drawing.Point(579, 292);
            this.TXTNOMBRE.Name = "TXTNOMBRE";
            this.TXTNOMBRE.Size = new System.Drawing.Size(541, 30);
            this.TXTNOMBRE.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(473, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Domicilio";
            // 
            // TXTDOMICILIO
            // 
            this.TXTDOMICILIO.Location = new System.Drawing.Point(579, 350);
            this.TXTDOMICILIO.Name = "TXTDOMICILIO";
            this.TXTDOMICILIO.Size = new System.Drawing.Size(541, 30);
            this.TXTDOMICILIO.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(473, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estado Civil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(785, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hijos";
            // 
            // CBHIJOS
            // 
            this.CBHIJOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBHIJOS.FormattingEnabled = true;
            this.CBHIJOS.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4 O MÁS"});
            this.CBHIJOS.Location = new System.Drawing.Point(848, 416);
            this.CBHIJOS.Name = "CBHIJOS";
            this.CBHIJOS.Size = new System.Drawing.Size(121, 32);
            this.CBHIJOS.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(473, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ingresos Mensuales";
            // 
            // TXTINGRESOMENSUAL
            // 
            this.TXTINGRESOMENSUAL.Location = new System.Drawing.Point(641, 474);
            this.TXTINGRESOMENSUAL.Name = "TXTINGRESOMENSUAL";
            this.TXTINGRESOMENSUAL.Size = new System.Drawing.Size(121, 30);
            this.TXTINGRESOMENSUAL.TabIndex = 5;
            this.TXTINGRESOMENSUAL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIngMen_KeyPress);
            this.TXTINGRESOMENSUAL.Leave += new System.EventHandler(this.TxtIngMen_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(785, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ingresos Acumulables";
            // 
            // TXTINGRESOSACOMULABLES
            // 
            this.TXTINGRESOSACOMULABLES.Enabled = false;
            this.TXTINGRESOSACOMULABLES.Location = new System.Drawing.Point(999, 477);
            this.TXTINGRESOSACOMULABLES.Name = "TXTINGRESOSACOMULABLES";
            this.TXTINGRESOSACOMULABLES.Size = new System.Drawing.Size(121, 30);
            this.TXTINGRESOSACOMULABLES.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(473, 547);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "PLAN SUGERIDO";
            // 
            // TXTPLANSUGERIDO
            // 
            this.TXTPLANSUGERIDO.Enabled = false;
            this.TXTPLANSUGERIDO.Location = new System.Drawing.Point(641, 540);
            this.TXTPLANSUGERIDO.Name = "TXTPLANSUGERIDO";
            this.TXTPLANSUGERIDO.Size = new System.Drawing.Size(192, 30);
            this.TXTPLANSUGERIDO.TabIndex = 7;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRegistrar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.Location = new System.Drawing.Point(889, 540);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(91, 26);
            this.BtnRegistrar.TabIndex = 8;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // CBESTADOCIVIL
            // 
            this.CBESTADOCIVIL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBESTADOCIVIL.FormattingEnabled = true;
            this.CBESTADOCIVIL.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Divorciado"});
            this.CBESTADOCIVIL.Location = new System.Drawing.Point(641, 411);
            this.CBESTADOCIVIL.Name = "CBESTADOCIVIL";
            this.CBESTADOCIVIL.Size = new System.Drawing.Size(121, 32);
            this.CBESTADOCIVIL.TabIndex = 3;
            this.CBESTADOCIVIL.SelectedIndexChanged += new System.EventHandler(this.CbEstCiv_SelectedIndexChanged);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClear.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(999, 540);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(91, 26);
            this.BtnClear.TabIndex = 16;
            this.BtnClear.Text = "Limpiar";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CASA_FUNERARIA.Properties.Resources.Logo_CFLE;
            this.pictureBox1.Location = new System.Drawing.Point(716, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // BtnRegresarregistroC
            // 
            this.BtnRegresarregistroC.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnRegresarregistroC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRegresarregistroC.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresarregistroC.Location = new System.Drawing.Point(1111, 540);
            this.BtnRegresarregistroC.Name = "BtnRegresarregistroC";
            this.BtnRegresarregistroC.Size = new System.Drawing.Size(91, 26);
            this.BtnRegresarregistroC.TabIndex = 18;
            this.BtnRegresarregistroC.Text = "Regresar";
            this.BtnRegresarregistroC.UseVisualStyleBackColor = false;
            this.BtnRegresarregistroC.Click += new System.EventHandler(this.BtnRegresarregistroC_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CASA_FUNERARIA.Properties.Resources.UV_1301;
            this.ClientSize = new System.Drawing.Size(1284, 625);
            this.Controls.Add(this.BtnRegresarregistroC);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.CBESTADOCIVIL);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.TXTPLANSUGERIDO);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TXTINGRESOSACOMULABLES);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TXTINGRESOMENSUAL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBHIJOS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTDOMICILIO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTNOMBRE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTNOMBRE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTDOMICILIO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBHIJOS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTINGRESOMENSUAL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXTINGRESOSACOMULABLES;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXTPLANSUGERIDO;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.ComboBox CBESTADOCIVIL;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnRegresarregistroC;
    }
}