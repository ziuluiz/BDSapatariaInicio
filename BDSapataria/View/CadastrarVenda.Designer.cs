namespace BDSapataria.View
{
    partial class CadastrarCliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.dateTimePickerDataVendaCadastrar = new System.Windows.Forms.DateTimePicker();
            this.textBoxValorTotalCadastrar = new System.Windows.Forms.TextBox();
            this.textBoxQuantidaCadastrar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCadastrar);
            this.groupBox1.Controls.Add(this.dateTimePickerDataVendaCadastrar);
            this.groupBox1.Controls.Add(this.textBoxValorTotalCadastrar);
            this.groupBox1.Controls.Add(this.textBoxQuantidaCadastrar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Venda";
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(164, 259);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 9;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // dateTimePickerDataVendaCadastrar
            // 
            this.dateTimePickerDataVendaCadastrar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataVendaCadastrar.Location = new System.Drawing.Point(152, 204);
            this.dateTimePickerDataVendaCadastrar.Name = "dateTimePickerDataVendaCadastrar";
            this.dateTimePickerDataVendaCadastrar.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerDataVendaCadastrar.TabIndex = 7;
            // 
            // textBoxValorTotalCadastrar
            // 
            this.textBoxValorTotalCadastrar.Location = new System.Drawing.Point(152, 171);
            this.textBoxValorTotalCadastrar.Name = "textBoxValorTotalCadastrar";
            this.textBoxValorTotalCadastrar.Size = new System.Drawing.Size(100, 20);
            this.textBoxValorTotalCadastrar.TabIndex = 5;
            // 
            // textBoxQuantidaCadastrar
            // 
            this.textBoxQuantidaCadastrar.Location = new System.Drawing.Point(152, 131);
            this.textBoxQuantidaCadastrar.Name = "textBoxQuantidaCadastrar";
            this.textBoxQuantidaCadastrar.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantidaCadastrar.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor Total :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade :";
            // 
            // CadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "CadastrarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarCliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataVendaCadastrar;
        private System.Windows.Forms.TextBox textBoxValorTotalCadastrar;
        private System.Windows.Forms.TextBox textBoxQuantidaCadastrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}