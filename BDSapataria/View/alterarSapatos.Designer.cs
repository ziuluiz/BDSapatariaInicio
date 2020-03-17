namespace BDSapataria.View
{
    partial class alterarSapatos
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
            this.textBoxMarcaAlterar = new System.Windows.Forms.TextBox();
            this.textBoxAlterarPreco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAlterarCodSapato = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDigiteCodSapato = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAlterarGenero = new System.Windows.Forms.TextBox();
            this.textBoxAlterarTamanho = new System.Windows.Forms.TextBox();
            this.textBoxAlterarModelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.materialRaisedButtonDeletarSapatos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButtonAlterarSapatos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButtonPesquisarSapatos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // textBoxMarcaAlterar
            // 
            this.textBoxMarcaAlterar.Location = new System.Drawing.Point(128, 333);
            this.textBoxMarcaAlterar.Name = "textBoxMarcaAlterar";
            this.textBoxMarcaAlterar.Size = new System.Drawing.Size(228, 20);
            this.textBoxMarcaAlterar.TabIndex = 16;
            // 
            // textBoxAlterarPreco
            // 
            this.textBoxAlterarPreco.Location = new System.Drawing.Point(126, 367);
            this.textBoxAlterarPreco.Name = "textBoxAlterarPreco";
            this.textBoxAlterarPreco.Size = new System.Drawing.Size(230, 20);
            this.textBoxAlterarPreco.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Preco :";
            // 
            // textBoxAlterarCodSapato
            // 
            this.textBoxAlterarCodSapato.Location = new System.Drawing.Point(128, 208);
            this.textBoxAlterarCodSapato.Name = "textBoxAlterarCodSapato";
            this.textBoxAlterarCodSapato.ReadOnly = true;
            this.textBoxAlterarCodSapato.Size = new System.Drawing.Size(228, 20);
            this.textBoxAlterarCodSapato.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Codigo Do Sapato :";
            // 
            // textBoxDigiteCodSapato
            // 
            this.textBoxDigiteCodSapato.Location = new System.Drawing.Point(125, 150);
            this.textBoxDigiteCodSapato.Name = "textBoxDigiteCodSapato";
            this.textBoxDigiteCodSapato.Size = new System.Drawing.Size(228, 20);
            this.textBoxDigiteCodSapato.TabIndex = 15;
            this.textBoxDigiteCodSapato.TextChanged += new System.EventHandler(this.textBoxDigiteCodSapato_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Codigo Do Sapato ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxAlterarGenero
            // 
            this.textBoxAlterarGenero.Location = new System.Drawing.Point(128, 301);
            this.textBoxAlterarGenero.Name = "textBoxAlterarGenero";
            this.textBoxAlterarGenero.Size = new System.Drawing.Size(228, 20);
            this.textBoxAlterarGenero.TabIndex = 7;
            // 
            // textBoxAlterarTamanho
            // 
            this.textBoxAlterarTamanho.Location = new System.Drawing.Point(128, 266);
            this.textBoxAlterarTamanho.Name = "textBoxAlterarTamanho";
            this.textBoxAlterarTamanho.Size = new System.Drawing.Size(228, 20);
            this.textBoxAlterarTamanho.TabIndex = 6;
            // 
            // textBoxAlterarModelo
            // 
            this.textBoxAlterarModelo.Location = new System.Drawing.Point(128, 238);
            this.textBoxAlterarModelo.Name = "textBoxAlterarModelo";
            this.textBoxAlterarModelo.Size = new System.Drawing.Size(228, 20);
            this.textBoxAlterarModelo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marca :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Genero :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tamanho :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo :";
            // 
            // materialRaisedButtonDeletarSapatos
            // 
            this.materialRaisedButtonDeletarSapatos.AutoSize = true;
            this.materialRaisedButtonDeletarSapatos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButtonDeletarSapatos.Depth = 0;
            this.materialRaisedButtonDeletarSapatos.Icon = null;
            this.materialRaisedButtonDeletarSapatos.Location = new System.Drawing.Point(274, 422);
            this.materialRaisedButtonDeletarSapatos.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonDeletarSapatos.Name = "materialRaisedButtonDeletarSapatos";
            this.materialRaisedButtonDeletarSapatos.Primary = true;
            this.materialRaisedButtonDeletarSapatos.Size = new System.Drawing.Size(79, 36);
            this.materialRaisedButtonDeletarSapatos.TabIndex = 18;
            this.materialRaisedButtonDeletarSapatos.Text = "Deletar";
            this.materialRaisedButtonDeletarSapatos.UseVisualStyleBackColor = true;
            this.materialRaisedButtonDeletarSapatos.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialRaisedButtonAlterarSapatos
            // 
            this.materialRaisedButtonAlterarSapatos.AutoSize = true;
            this.materialRaisedButtonAlterarSapatos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButtonAlterarSapatos.Depth = 0;
            this.materialRaisedButtonAlterarSapatos.Icon = null;
            this.materialRaisedButtonAlterarSapatos.Location = new System.Drawing.Point(137, 422);
            this.materialRaisedButtonAlterarSapatos.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonAlterarSapatos.Name = "materialRaisedButtonAlterarSapatos";
            this.materialRaisedButtonAlterarSapatos.Primary = true;
            this.materialRaisedButtonAlterarSapatos.Size = new System.Drawing.Size(80, 36);
            this.materialRaisedButtonAlterarSapatos.TabIndex = 19;
            this.materialRaisedButtonAlterarSapatos.Text = "Alterar";
            this.materialRaisedButtonAlterarSapatos.UseVisualStyleBackColor = true;
            this.materialRaisedButtonAlterarSapatos.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // materialRaisedButtonPesquisarSapatos
            // 
            this.materialRaisedButtonPesquisarSapatos.AutoSize = true;
            this.materialRaisedButtonPesquisarSapatos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButtonPesquisarSapatos.Depth = 0;
            this.materialRaisedButtonPesquisarSapatos.Icon = null;
            this.materialRaisedButtonPesquisarSapatos.Location = new System.Drawing.Point(359, 141);
            this.materialRaisedButtonPesquisarSapatos.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonPesquisarSapatos.Name = "materialRaisedButtonPesquisarSapatos";
            this.materialRaisedButtonPesquisarSapatos.Primary = true;
            this.materialRaisedButtonPesquisarSapatos.Size = new System.Drawing.Size(94, 36);
            this.materialRaisedButtonPesquisarSapatos.TabIndex = 20;
            this.materialRaisedButtonPesquisarSapatos.Text = "Pesquisar";
            this.materialRaisedButtonPesquisarSapatos.UseVisualStyleBackColor = true;
            this.materialRaisedButtonPesquisarSapatos.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // alterarSapatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 522);
            this.Controls.Add(this.materialRaisedButtonPesquisarSapatos);
            this.Controls.Add(this.materialRaisedButtonAlterarSapatos);
            this.Controls.Add(this.materialRaisedButtonDeletarSapatos);
            this.Controls.Add(this.textBoxDigiteCodSapato);
            this.Controls.Add(this.textBoxMarcaAlterar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxAlterarPreco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAlterarCodSapato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAlterarModelo);
            this.Controls.Add(this.textBoxAlterarTamanho);
            this.Controls.Add(this.textBoxAlterarGenero);
            this.Name = "alterarSapatos";
            this.Text = "Sapatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxAlterarMarca;
        private System.Windows.Forms.TextBox textBoxAlterarGenero;
        private System.Windows.Forms.TextBox textBoxAlterarTamanho;
        private System.Windows.Forms.TextBox textBoxAlterarModelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAlterarCodSapato;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDigiteCodSapato;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAlterarPreco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMarcaAlterar;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonDeletarSapatos;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonAlterarSapatos;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonPesquisarSapatos;
    }
}