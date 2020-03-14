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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDeletar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.textBoxIDvendaAlterar = new System.Windows.Forms.TextBox();
            this.dateTimePickerDataVendaAlterar = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxValorTotalAlterar = new System.Windows.Forms.TextBox();
            this.textBoxQuantidaAlterar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxIDVendaDigitar = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDeletar);
            this.groupBox1.Controls.Add(this.buttonAlterar);
            this.groupBox1.Controls.Add(this.textBoxIDvendaAlterar);
            this.groupBox1.Controls.Add(this.dateTimePickerDataVendaAlterar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxValorTotalAlterar);
            this.groupBox1.Controls.Add(this.textBoxQuantidaAlterar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alterar Venda";
            // 
            // buttonDeletar
            // 
            this.buttonDeletar.Location = new System.Drawing.Point(299, 349);
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(75, 23);
            this.buttonDeletar.TabIndex = 10;
            this.buttonDeletar.Text = "Deletar";
            this.buttonDeletar.UseVisualStyleBackColor = true;
            this.buttonDeletar.Click += new System.EventHandler(this.buttonDeletar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(63, 349);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 9;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // textBoxIDvendaAlterar
            // 
            this.textBoxIDvendaAlterar.Location = new System.Drawing.Point(199, 190);
            this.textBoxIDvendaAlterar.Name = "textBoxIDvendaAlterar";
            this.textBoxIDvendaAlterar.ReadOnly = true;
            this.textBoxIDvendaAlterar.Size = new System.Drawing.Size(100, 20);
            this.textBoxIDvendaAlterar.TabIndex = 8;
            // 
            // dateTimePickerDataVendaAlterar
            // 
            this.dateTimePickerDataVendaAlterar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataVendaAlterar.Location = new System.Drawing.Point(199, 290);
            this.dateTimePickerDataVendaAlterar.Name = "dateTimePickerDataVendaAlterar";
            this.dateTimePickerDataVendaAlterar.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerDataVendaAlterar.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "ID Venda : ";
            // 
            // textBoxValorTotalAlterar
            // 
            this.textBoxValorTotalAlterar.Location = new System.Drawing.Point(199, 257);
            this.textBoxValorTotalAlterar.Name = "textBoxValorTotalAlterar";
            this.textBoxValorTotalAlterar.Size = new System.Drawing.Size(100, 20);
            this.textBoxValorTotalAlterar.TabIndex = 5;
            // 
            // textBoxQuantidaAlterar
            // 
            this.textBoxQuantidaAlterar.Location = new System.Drawing.Point(199, 217);
            this.textBoxQuantidaAlterar.Name = "textBoxQuantidaAlterar";
            this.textBoxQuantidaAlterar.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantidaAlterar.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor Total :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonBuscar);
            this.groupBox2.Controls.Add(this.textBoxIDVendaDigitar);
            this.groupBox2.Controls.Add(this.label);
            this.groupBox2.Location = new System.Drawing.Point(63, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 68);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Digite o ID";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(219, 29);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 11;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxIDVendaDigitar
            // 
            this.textBoxIDVendaDigitar.Location = new System.Drawing.Point(85, 32);
            this.textBoxIDVendaDigitar.Name = "textBoxIDVendaDigitar";
            this.textBoxIDVendaDigitar.Size = new System.Drawing.Size(110, 20);
            this.textBoxIDVendaDigitar.TabIndex = 9;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(21, 35);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(58, 13);
            this.label.TabIndex = 0;
            this.label.Text = "ID Venda :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade :";
            // 
            // AlterarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "AlterarVenda";
            this.Text = "AlterarVenda";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxValorTotalAlterar;
        private System.Windows.Forms.TextBox textBoxQuantidaAlterar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataVendaAlterar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxIDvendaAlterar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.TextBox textBoxIDVendaDigitar;
        private System.Windows.Forms.Button buttonDeletar;
        private System.Windows.Forms.Button buttonBuscar;
    }
}