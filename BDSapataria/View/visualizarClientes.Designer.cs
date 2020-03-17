namespace BDSapataria.View
{
    partial class visualizarClientes
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
            this.Clientes = new System.Windows.Forms.TabPage();
            this.materialRaisedButtonVisualizarCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Clientes
            // 
            this.Clientes.Controls.Add(this.materialRaisedButtonVisualizarCliente);
            this.Clientes.Controls.Add(this.dataGridViewCliente);
            this.Clientes.Location = new System.Drawing.Point(4, 22);
            this.Clientes.Name = "Clientes";
            this.Clientes.Padding = new System.Windows.Forms.Padding(3);
            this.Clientes.Size = new System.Drawing.Size(592, 335);
            this.Clientes.TabIndex = 0;
            this.Clientes.Text = "Clientes";
            this.Clientes.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButtonVisualizarCliente
            // 
            this.materialRaisedButtonVisualizarCliente.AutoSize = true;
            this.materialRaisedButtonVisualizarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButtonVisualizarCliente.Depth = 0;
            this.materialRaisedButtonVisualizarCliente.Icon = null;
            this.materialRaisedButtonVisualizarCliente.Location = new System.Drawing.Point(185, 11);
            this.materialRaisedButtonVisualizarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonVisualizarCliente.Name = "materialRaisedButtonVisualizarCliente";
            this.materialRaisedButtonVisualizarCliente.Primary = true;
            this.materialRaisedButtonVisualizarCliente.Size = new System.Drawing.Size(94, 36);
            this.materialRaisedButtonVisualizarCliente.TabIndex = 1;
            this.materialRaisedButtonVisualizarCliente.Text = "Pesquisar";
            this.materialRaisedButtonVisualizarCliente.UseVisualStyleBackColor = true;
            this.materialRaisedButtonVisualizarCliente.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewCliente.Location = new System.Drawing.Point(1, 53);
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.RowHeadersVisible = false;
            this.dataGridViewCliente.Size = new System.Drawing.Size(444, 292);
            this.dataGridViewCliente.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cpf";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Endereço";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Telefone";
            this.Column4.Name = "Column4";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Clientes);
            this.tabControl1.Location = new System.Drawing.Point(12, 77);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 361);
            this.tabControl1.TabIndex = 1;
            // 
            // visualizarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 456);
            this.Controls.Add(this.tabControl1);
            this.Name = "visualizarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.visualizarClientes_Load);
            this.Clientes.ResumeLayout(false);
            this.Clientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Clientes;
        private System.Windows.Forms.DataGridView dataGridViewCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TabControl tabControl1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonVisualizarCliente;
    }
}