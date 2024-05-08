namespace CASA_FUNERARIA
{
    partial class frmBusquedaClientes
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
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.cliidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliDomicilioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliEstadoCivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliHijosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliIngresosMensualesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliIngresosAcumulablesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliPlanSugeridoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCliente = new CASA_FUNERARIA.dsCliente();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.clientesTableAdapter = new CASA_FUNERARIA.dsClienteTableAdapters.ClientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgClientes
            // 
            this.dgClientes.AllowUserToAddRows = false;
            this.dgClientes.AllowUserToDeleteRows = false;
            this.dgClientes.AutoGenerateColumns = false;
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cliidDataGridViewTextBoxColumn,
            this.cliNombreDataGridViewTextBoxColumn,
            this.cliDomicilioDataGridViewTextBoxColumn,
            this.cliEstadoCivilDataGridViewTextBoxColumn,
            this.cliHijosDataGridViewTextBoxColumn,
            this.cliIngresosMensualesDataGridViewTextBoxColumn,
            this.cliIngresosAcumulablesDataGridViewTextBoxColumn,
            this.cliPlanSugeridoDataGridViewTextBoxColumn});
            this.dgClientes.DataSource = this.clientesBindingSource;
            this.dgClientes.Location = new System.Drawing.Point(300, 271);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.ReadOnly = true;
            this.dgClientes.RowHeadersWidth = 51;
            this.dgClientes.RowTemplate.Height = 24;
            this.dgClientes.Size = new System.Drawing.Size(1052, 443);
            this.dgClientes.TabIndex = 0;
            this.dgClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellClick);
            this.dgClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cliidDataGridViewTextBoxColumn
            // 
            this.cliidDataGridViewTextBoxColumn.DataPropertyName = "Cli_id";
            this.cliidDataGridViewTextBoxColumn.HeaderText = "Cli_id";
            this.cliidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cliidDataGridViewTextBoxColumn.Name = "cliidDataGridViewTextBoxColumn";
            this.cliidDataGridViewTextBoxColumn.ReadOnly = true;
            this.cliidDataGridViewTextBoxColumn.Width = 125;
            // 
            // cliNombreDataGridViewTextBoxColumn
            // 
            this.cliNombreDataGridViewTextBoxColumn.DataPropertyName = "Cli_Nombre";
            this.cliNombreDataGridViewTextBoxColumn.HeaderText = "Cli_Nombre";
            this.cliNombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cliNombreDataGridViewTextBoxColumn.Name = "cliNombreDataGridViewTextBoxColumn";
            this.cliNombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.cliNombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // cliDomicilioDataGridViewTextBoxColumn
            // 
            this.cliDomicilioDataGridViewTextBoxColumn.DataPropertyName = "Cli_Domicilio";
            this.cliDomicilioDataGridViewTextBoxColumn.HeaderText = "Cli_Domicilio";
            this.cliDomicilioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cliDomicilioDataGridViewTextBoxColumn.Name = "cliDomicilioDataGridViewTextBoxColumn";
            this.cliDomicilioDataGridViewTextBoxColumn.ReadOnly = true;
            this.cliDomicilioDataGridViewTextBoxColumn.Width = 125;
            // 
            // cliEstadoCivilDataGridViewTextBoxColumn
            // 
            this.cliEstadoCivilDataGridViewTextBoxColumn.DataPropertyName = "Cli_EstadoCivil";
            this.cliEstadoCivilDataGridViewTextBoxColumn.HeaderText = "Cli_EstadoCivil";
            this.cliEstadoCivilDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cliEstadoCivilDataGridViewTextBoxColumn.Name = "cliEstadoCivilDataGridViewTextBoxColumn";
            this.cliEstadoCivilDataGridViewTextBoxColumn.ReadOnly = true;
            this.cliEstadoCivilDataGridViewTextBoxColumn.Width = 125;
            // 
            // cliHijosDataGridViewTextBoxColumn
            // 
            this.cliHijosDataGridViewTextBoxColumn.DataPropertyName = "Cli_Hijos";
            this.cliHijosDataGridViewTextBoxColumn.HeaderText = "Cli_Hijos";
            this.cliHijosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cliHijosDataGridViewTextBoxColumn.Name = "cliHijosDataGridViewTextBoxColumn";
            this.cliHijosDataGridViewTextBoxColumn.ReadOnly = true;
            this.cliHijosDataGridViewTextBoxColumn.Width = 125;
            // 
            // cliIngresosMensualesDataGridViewTextBoxColumn
            // 
            this.cliIngresosMensualesDataGridViewTextBoxColumn.DataPropertyName = "Cli_IngresosMensuales";
            this.cliIngresosMensualesDataGridViewTextBoxColumn.HeaderText = "Cli_IngresosMensuales";
            this.cliIngresosMensualesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cliIngresosMensualesDataGridViewTextBoxColumn.Name = "cliIngresosMensualesDataGridViewTextBoxColumn";
            this.cliIngresosMensualesDataGridViewTextBoxColumn.ReadOnly = true;
            this.cliIngresosMensualesDataGridViewTextBoxColumn.Width = 125;
            // 
            // cliIngresosAcumulablesDataGridViewTextBoxColumn
            // 
            this.cliIngresosAcumulablesDataGridViewTextBoxColumn.DataPropertyName = "Cli_IngresosAcumulables";
            this.cliIngresosAcumulablesDataGridViewTextBoxColumn.HeaderText = "Cli_IngresosAcumulables";
            this.cliIngresosAcumulablesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cliIngresosAcumulablesDataGridViewTextBoxColumn.Name = "cliIngresosAcumulablesDataGridViewTextBoxColumn";
            this.cliIngresosAcumulablesDataGridViewTextBoxColumn.ReadOnly = true;
            this.cliIngresosAcumulablesDataGridViewTextBoxColumn.Width = 125;
            // 
            // cliPlanSugeridoDataGridViewTextBoxColumn
            // 
            this.cliPlanSugeridoDataGridViewTextBoxColumn.DataPropertyName = "Cli_PlanSugerido";
            this.cliPlanSugeridoDataGridViewTextBoxColumn.HeaderText = "Cli_PlanSugerido";
            this.cliPlanSugeridoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cliPlanSugeridoDataGridViewTextBoxColumn.Name = "cliPlanSugeridoDataGridViewTextBoxColumn";
            this.cliPlanSugeridoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cliPlanSugeridoDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.dsCliente;
            // 
            // dsCliente
            // 
            this.dsCliente.DataSetName = "dsCliente";
            this.dsCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(296, 161);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(371, 22);
            this.txtBusqueda.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre del Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Location = new System.Drawing.Point(673, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // frmBusquedaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 758);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.dgClientes);
            this.Name = "frmBusquedaClientes";
            this.Text = "frmBusquedaClientes";
            this.Load += new System.EventHandler(this.frmBusquedaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private dsCliente dsCliente;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private dsClienteTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliDomicilioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliEstadoCivilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliHijosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliIngresosMensualesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliIngresosAcumulablesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliPlanSugeridoDataGridViewTextBoxColumn;
    }
}