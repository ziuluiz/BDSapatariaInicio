namespace BDSapataria.View
{
    partial class GerenciarCliente
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
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelFone = new System.Windows.Forms.Label();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxCpf = new System.Windows.Forms.TextBox();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.materialRaisedButtonAlterar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButtonPesquisaCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(26, 160);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(27, 13);
            this.labelCPF.TabIndex = 0;
            this.labelCPF.Text = "CPF";
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(0, 230);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(53, 13);
            this.labelEndereco.TabIndex = 1;
            this.labelEndereco.Text = "Endereço";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(18, 204);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome";
            // 
            // labelFone
            // 
            this.labelFone.AutoSize = true;
            this.labelFone.Location = new System.Drawing.Point(4, 256);
            this.labelFone.Name = "labelFone";
            this.labelFone.Size = new System.Drawing.Size(49, 13);
            this.labelFone.TabIndex = 3;
            this.labelFone.Text = "Telefone";
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(59, 227);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(171, 20);
            this.textBoxEndereco.TabIndex = 7;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(59, 201);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(171, 20);
            this.textBoxNome.TabIndex = 8;
            // 
            // textBoxCpf
            // 
            this.textBoxCpf.Location = new System.Drawing.Point(59, 160);
            this.textBoxCpf.Name = "textBoxCpf";
            this.textBoxCpf.Size = new System.Drawing.Size(171, 20);
            this.textBoxCpf.TabIndex = 9;
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(59, 253);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(171, 20);
            this.textBoxTelefone.TabIndex = 10;
            // 
            // materialRaisedButtonAlterar
            // 
            this.materialRaisedButtonAlterar.AutoSize = true;
            this.materialRaisedButtonAlterar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButtonAlterar.Depth = 0;
            this.materialRaisedButtonAlterar.Icon = null;
            this.materialRaisedButtonAlterar.Location = new System.Drawing.Point(59, 303);
            this.materialRaisedButtonAlterar.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonAlterar.Name = "materialRaisedButtonAlterar";
            this.materialRaisedButtonAlterar.Primary = true;
            this.materialRaisedButtonAlterar.Size = new System.Drawing.Size(80, 36);
            this.materialRaisedButtonAlterar.TabIndex = 11;
            this.materialRaisedButtonAlterar.Text = "Alterar";
            this.materialRaisedButtonAlterar.UseVisualStyleBackColor = true;
            this.materialRaisedButtonAlterar.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(151, 303);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(79, 36);
            this.materialRaisedButton2.TabIndex = 12;
            this.materialRaisedButton2.Text = "Deletar";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // materialRaisedButtonPesquisaCliente
            // 
            this.materialRaisedButtonPesquisaCliente.AutoSize = true;
            this.materialRaisedButtonPesquisaCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButtonPesquisaCliente.Depth = 0;
            this.materialRaisedButtonPesquisaCliente.Icon = null;
            this.materialRaisedButtonPesquisaCliente.Location = new System.Drawing.Point(94, 99);
            this.materialRaisedButtonPesquisaCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonPesquisaCliente.Name = "materialRaisedButtonPesquisaCliente";
            this.materialRaisedButtonPesquisaCliente.Primary = true;
            this.materialRaisedButtonPesquisaCliente.Size = new System.Drawing.Size(94, 36);
            this.materialRaisedButtonPesquisaCliente.TabIndex = 13;
            this.materialRaisedButtonPesquisaCliente.Text = "Pesquisar";
            this.materialRaisedButtonPesquisaCliente.UseVisualStyleBackColor = true;
            this.materialRaisedButtonPesquisaCliente.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // GerenciarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 381);
            this.Controls.Add(this.materialRaisedButtonPesquisaCliente);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButtonAlterar);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.textBoxCpf);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.labelFone);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.labelCPF);
            this.Name = "GerenciarCliente";
            this.Text = "GerenciarCliente";
            this.Load += new System.EventHandler(this.GerenciarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelFone;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxCpf;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonAlterar;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonPesquisaCliente;
    }
}