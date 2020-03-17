namespace BDSapataria.View
{
    partial class CadastrarVenda
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
            this.dateTimePickerDataVendaCadastrar = new System.Windows.Forms.DateTimePicker();
            this.textBoxValorTotalCadastrar = new System.Windows.Forms.TextBox();
            this.textBoxQuantidaCadastrar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.materialRaisedButtonCadastrarVenda = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // dateTimePickerDataVendaCadastrar
            // 
            this.dateTimePickerDataVendaCadastrar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataVendaCadastrar.Location = new System.Drawing.Point(91, 151);
            this.dateTimePickerDataVendaCadastrar.Name = "dateTimePickerDataVendaCadastrar";
            this.dateTimePickerDataVendaCadastrar.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerDataVendaCadastrar.TabIndex = 7;
            // 
            // textBoxValorTotalCadastrar
            // 
            this.textBoxValorTotalCadastrar.Location = new System.Drawing.Point(91, 118);
            this.textBoxValorTotalCadastrar.Name = "textBoxValorTotalCadastrar";
            this.textBoxValorTotalCadastrar.Size = new System.Drawing.Size(100, 20);
            this.textBoxValorTotalCadastrar.TabIndex = 5;
            // 
            // textBoxQuantidaCadastrar
            // 
            this.textBoxQuantidaCadastrar.Location = new System.Drawing.Point(91, 78);
            this.textBoxQuantidaCadastrar.Name = "textBoxQuantidaCadastrar";
            this.textBoxQuantidaCadastrar.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantidaCadastrar.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor Total :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade :";
            // 
            // materialRaisedButtonCadastrarVenda
            // 
            this.materialRaisedButtonCadastrarVenda.AutoSize = true;
            this.materialRaisedButtonCadastrarVenda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButtonCadastrarVenda.Depth = 0;
            this.materialRaisedButtonCadastrarVenda.Icon = null;
            this.materialRaisedButtonCadastrarVenda.Location = new System.Drawing.Point(55, 196);
            this.materialRaisedButtonCadastrarVenda.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonCadastrarVenda.Name = "materialRaisedButtonCadastrarVenda";
            this.materialRaisedButtonCadastrarVenda.Primary = true;
            this.materialRaisedButtonCadastrarVenda.Size = new System.Drawing.Size(100, 36);
            this.materialRaisedButtonCadastrarVenda.TabIndex = 10;
            this.materialRaisedButtonCadastrarVenda.Text = "Cadastrar";
            this.materialRaisedButtonCadastrarVenda.UseVisualStyleBackColor = true;
            this.materialRaisedButtonCadastrarVenda.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // CadastrarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 264);
            this.Controls.Add(this.materialRaisedButtonCadastrarVenda);
            this.Controls.Add(this.dateTimePickerDataVendaCadastrar);
            this.Controls.Add(this.textBoxQuantidaCadastrar);
            this.Controls.Add(this.textBoxValorTotalCadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "CadastrarVenda";
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.CadastrarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePickerDataVendaCadastrar;
        private System.Windows.Forms.TextBox textBoxValorTotalCadastrar;
        private System.Windows.Forms.TextBox textBoxQuantidaCadastrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonCadastrarVenda;
    }
}