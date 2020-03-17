namespace BDSapataria.View
{
    partial class AlterarVenda
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
            this.textBoxIDvendaAlterar = new System.Windows.Forms.TextBox();
            this.dateTimePickerDataVendaAlterar = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxValorTotalAlterar = new System.Windows.Forms.TextBox();
            this.textBoxQuantidaAlterar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIDVendaDigitar = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.materialRaisedButtonPesquisar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButtonAlterar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButtonDeletar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // textBoxIDvendaAlterar
            // 
            this.textBoxIDvendaAlterar.Location = new System.Drawing.Point(148, 178);
            this.textBoxIDvendaAlterar.Name = "textBoxIDvendaAlterar";
            this.textBoxIDvendaAlterar.ReadOnly = true;
            this.textBoxIDvendaAlterar.Size = new System.Drawing.Size(100, 20);
            this.textBoxIDvendaAlterar.TabIndex = 8;
            // 
            // dateTimePickerDataVendaAlterar
            // 
            this.dateTimePickerDataVendaAlterar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataVendaAlterar.Location = new System.Drawing.Point(148, 278);
            this.dateTimePickerDataVendaAlterar.Name = "dateTimePickerDataVendaAlterar";
            this.dateTimePickerDataVendaAlterar.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerDataVendaAlterar.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "ID Venda : ";
            // 
            // textBoxValorTotalAlterar
            // 
            this.textBoxValorTotalAlterar.Location = new System.Drawing.Point(148, 245);
            this.textBoxValorTotalAlterar.Name = "textBoxValorTotalAlterar";
            this.textBoxValorTotalAlterar.Size = new System.Drawing.Size(100, 20);
            this.textBoxValorTotalAlterar.TabIndex = 5;
            // 
            // textBoxQuantidaAlterar
            // 
            this.textBoxQuantidaAlterar.Location = new System.Drawing.Point(148, 205);
            this.textBoxQuantidaAlterar.Name = "textBoxQuantidaAlterar";
            this.textBoxQuantidaAlterar.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantidaAlterar.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor Total :";
            // 
            // textBoxIDVendaDigitar
            // 
            this.textBoxIDVendaDigitar.Location = new System.Drawing.Point(138, 111);
            this.textBoxIDVendaDigitar.Name = "textBoxIDVendaDigitar";
            this.textBoxIDVendaDigitar.Size = new System.Drawing.Size(110, 20);
            this.textBoxIDVendaDigitar.TabIndex = 9;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(74, 114);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(58, 13);
            this.label.TabIndex = 0;
            this.label.Text = "ID Venda :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade :";
            // 
            // materialRaisedButtonPesquisar
            // 
            this.materialRaisedButtonPesquisar.AutoSize = true;
            this.materialRaisedButtonPesquisar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButtonPesquisar.Depth = 0;
            this.materialRaisedButtonPesquisar.Icon = null;
            this.materialRaisedButtonPesquisar.Location = new System.Drawing.Point(254, 102);
            this.materialRaisedButtonPesquisar.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonPesquisar.Name = "materialRaisedButtonPesquisar";
            this.materialRaisedButtonPesquisar.Primary = true;
            this.materialRaisedButtonPesquisar.Size = new System.Drawing.Size(94, 36);
            this.materialRaisedButtonPesquisar.TabIndex = 12;
            this.materialRaisedButtonPesquisar.Text = "Pesquisar";
            this.materialRaisedButtonPesquisar.UseVisualStyleBackColor = true;
            this.materialRaisedButtonPesquisar.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialRaisedButtonAlterar
            // 
            this.materialRaisedButtonAlterar.AutoSize = true;
            this.materialRaisedButtonAlterar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButtonAlterar.Depth = 0;
            this.materialRaisedButtonAlterar.Icon = null;
            this.materialRaisedButtonAlterar.Location = new System.Drawing.Point(100, 304);
            this.materialRaisedButtonAlterar.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonAlterar.Name = "materialRaisedButtonAlterar";
            this.materialRaisedButtonAlterar.Primary = true;
            this.materialRaisedButtonAlterar.Size = new System.Drawing.Size(80, 36);
            this.materialRaisedButtonAlterar.TabIndex = 13;
            this.materialRaisedButtonAlterar.Text = "Alterar";
            this.materialRaisedButtonAlterar.UseVisualStyleBackColor = true;
            this.materialRaisedButtonAlterar.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // materialRaisedButtonDeletar
            // 
            this.materialRaisedButtonDeletar.AutoSize = true;
            this.materialRaisedButtonDeletar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButtonDeletar.Depth = 0;
            this.materialRaisedButtonDeletar.Icon = null;
            this.materialRaisedButtonDeletar.Location = new System.Drawing.Point(198, 304);
            this.materialRaisedButtonDeletar.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonDeletar.Name = "materialRaisedButtonDeletar";
            this.materialRaisedButtonDeletar.Primary = true;
            this.materialRaisedButtonDeletar.Size = new System.Drawing.Size(79, 36);
            this.materialRaisedButtonDeletar.TabIndex = 14;
            this.materialRaisedButtonDeletar.Text = "Deletar";
            this.materialRaisedButtonDeletar.UseVisualStyleBackColor = true;
            this.materialRaisedButtonDeletar.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // AlterarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 392);
            this.Controls.Add(this.materialRaisedButtonDeletar);
            this.Controls.Add(this.materialRaisedButtonAlterar);
            this.Controls.Add(this.materialRaisedButtonPesquisar);
            this.Controls.Add(this.textBoxIDVendaDigitar);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBoxIDvendaAlterar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerDataVendaAlterar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxValorTotalAlterar);
            this.Controls.Add(this.textBoxQuantidaAlterar);
            this.Name = "AlterarVenda";
            this.Text = "AlterarVenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxValorTotalAlterar;
        private System.Windows.Forms.TextBox textBoxQuantidaAlterar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataVendaAlterar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxIDvendaAlterar;
        private System.Windows.Forms.TextBox textBoxIDVendaDigitar;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonPesquisar;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonAlterar;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonDeletar;
    }
}