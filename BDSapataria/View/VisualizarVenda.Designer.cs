namespace BDSapataria.View
{
    partial class VisualizarVenda
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewVendasTudo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.materialRaisedButtonPesquisaVendas = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendasTudo)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewVendasTudo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 189);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vendas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewVendasTudo
            // 
            this.dataGridViewVendasTudo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVendasTudo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVendasTudo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewVendasTudo.Location = new System.Drawing.Point(16, 22);
            this.dataGridViewVendasTudo.Name = "dataGridViewVendasTudo";
            this.dataGridViewVendasTudo.Size = new System.Drawing.Size(737, 150);
            this.dataGridViewVendasTudo.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Vendas";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Quantidade";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Total Vendas";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Data da Venda";
            this.Column4.Name = "Column4";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 161);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 215);
            this.tabControl1.TabIndex = 2;
            // 
            // materialRaisedButtonPesquisaVendas
            // 
            this.materialRaisedButtonPesquisaVendas.AutoSize = true;
            this.materialRaisedButtonPesquisaVendas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButtonPesquisaVendas.Depth = 0;
            this.materialRaisedButtonPesquisaVendas.Icon = null;
            this.materialRaisedButtonPesquisaVendas.Location = new System.Drawing.Point(344, 86);
            this.materialRaisedButtonPesquisaVendas.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonPesquisaVendas.Name = "materialRaisedButtonPesquisaVendas";
            this.materialRaisedButtonPesquisaVendas.Primary = true;
            this.materialRaisedButtonPesquisaVendas.Size = new System.Drawing.Size(94, 36);
            this.materialRaisedButtonPesquisaVendas.TabIndex = 3;
            this.materialRaisedButtonPesquisaVendas.Text = "Pesquisar";
            this.materialRaisedButtonPesquisaVendas.UseVisualStyleBackColor = true;
            this.materialRaisedButtonPesquisaVendas.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // VisualizarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialRaisedButtonPesquisaVendas);
            this.Controls.Add(this.tabControl1);
            this.Name = "VisualizarVenda";
            this.Text = "Vendas";
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendasTudo)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewVendasTudo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TabControl tabControl1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonPesquisaVendas;
    }
}