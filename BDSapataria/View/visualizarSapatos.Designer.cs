﻿namespace BDSapataria.View
{
    partial class visualizarSapatos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewSaptosTudo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialRaisedButtonPesquisaSapatos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaptosTudo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(2, 174);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 274);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewSaptosTudo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 248);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sapatos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSaptosTudo
            // 
            this.dataGridViewSaptosTudo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSaptosTudo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSaptosTudo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewSaptosTudo.Location = new System.Drawing.Point(16, 22);
            this.dataGridViewSaptosTudo.Name = "dataGridViewSaptosTudo";
            this.dataGridViewSaptosTudo.Size = new System.Drawing.Size(737, 150);
            this.dataGridViewSaptosTudo.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo Sapato";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tamanho";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Genero";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Marca";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Preço";
            this.Column5.Name = "Column5";
            // 
            // materialRaisedButtonPesquisaSapatos
            // 
            this.materialRaisedButtonPesquisaSapatos.AutoSize = true;
            this.materialRaisedButtonPesquisaSapatos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButtonPesquisaSapatos.Depth = 0;
            this.materialRaisedButtonPesquisaSapatos.Icon = null;
            this.materialRaisedButtonPesquisaSapatos.Location = new System.Drawing.Point(352, 110);
            this.materialRaisedButtonPesquisaSapatos.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonPesquisaSapatos.Name = "materialRaisedButtonPesquisaSapatos";
            this.materialRaisedButtonPesquisaSapatos.Primary = true;
            this.materialRaisedButtonPesquisaSapatos.Size = new System.Drawing.Size(94, 36);
            this.materialRaisedButtonPesquisaSapatos.TabIndex = 5;
            this.materialRaisedButtonPesquisaSapatos.Text = "Pesquisar";
            this.materialRaisedButtonPesquisaSapatos.UseVisualStyleBackColor = true;
            this.materialRaisedButtonPesquisaSapatos.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // visualizarSapatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialRaisedButtonPesquisaSapatos);
            this.Controls.Add(this.tabControl1);
            this.Name = "visualizarSapatos";
            this.Text = "Sapatos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaptosTudo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewSaptosTudo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonPesquisaSapatos;
    }
}