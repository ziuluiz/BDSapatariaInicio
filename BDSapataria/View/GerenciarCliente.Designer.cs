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
            this.buttonPesquisarCliente = new System.Windows.Forms.Button();
            this.buttonDeletarCliente = new System.Windows.Forms.Button();
            this.buttonAlterarCliente = new System.Windows.Forms.Button();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxCpf = new System.Windows.Forms.TextBox();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(58, 167);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(27, 13);
            this.labelCPF.TabIndex = 0;
            this.labelCPF.Text = "CPF";
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(32, 237);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(53, 13);
            this.labelEndereco.TabIndex = 1;
            this.labelEndereco.Text = "Endereço";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(50, 211);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome";
            // 
            // labelFone
            // 
            this.labelFone.AutoSize = true;
            this.labelFone.Location = new System.Drawing.Point(36, 263);
            this.labelFone.Name = "labelFone";
            this.labelFone.Size = new System.Drawing.Size(49, 13);
            this.labelFone.TabIndex = 3;
            this.labelFone.Text = "Telefone";
            // 
            // buttonPesquisarCliente
            // 
            this.buttonPesquisarCliente.Location = new System.Drawing.Point(279, 165);
            this.buttonPesquisarCliente.Name = "buttonPesquisarCliente";
            this.buttonPesquisarCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisarCliente.TabIndex = 4;
            this.buttonPesquisarCliente.Text = "Pesquisar";
            this.buttonPesquisarCliente.UseVisualStyleBackColor = true;
            this.buttonPesquisarCliente.Click += new System.EventHandler(this.buttonPesquisarCliente_Click);
            // 
            // buttonDeletarCliente
            // 
            this.buttonDeletarCliente.Location = new System.Drawing.Point(187, 370);
            this.buttonDeletarCliente.Name = "buttonDeletarCliente";
            this.buttonDeletarCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonDeletarCliente.TabIndex = 5;
            this.buttonDeletarCliente.Text = "Deletar";
            this.buttonDeletarCliente.UseVisualStyleBackColor = true;
            this.buttonDeletarCliente.Click += new System.EventHandler(this.buttonDeletarCliente_Click);
            // 
            // buttonAlterarCliente
            // 
            this.buttonAlterarCliente.Location = new System.Drawing.Point(91, 370);
            this.buttonAlterarCliente.Name = "buttonAlterarCliente";
            this.buttonAlterarCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarCliente.TabIndex = 6;
            this.buttonAlterarCliente.Text = "Alterar";
            this.buttonAlterarCliente.UseVisualStyleBackColor = true;
            this.buttonAlterarCliente.Click += new System.EventHandler(this.buttonAlterarCliente_Click);
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(91, 234);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(171, 20);
            this.textBoxEndereco.TabIndex = 7;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(91, 208);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(171, 20);
            this.textBoxNome.TabIndex = 8;
            // 
            // textBoxCpf
            // 
            this.textBoxCpf.Location = new System.Drawing.Point(91, 167);
            this.textBoxCpf.Name = "textBoxCpf";
            this.textBoxCpf.Size = new System.Drawing.Size(171, 20);
            this.textBoxCpf.TabIndex = 9;
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(91, 260);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(171, 20);
            this.textBoxTelefone.TabIndex = 10;
            // 
            // GerenciarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 495);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.textBoxCpf);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.buttonAlterarCliente);
            this.Controls.Add(this.buttonDeletarCliente);
            this.Controls.Add(this.buttonPesquisarCliente);
            this.Controls.Add(this.labelFone);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.labelCPF);
            this.Name = "GerenciarCliente";
            this.Text = "GerenciarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelFone;
        private System.Windows.Forms.Button buttonPesquisarCliente;
        private System.Windows.Forms.Button buttonDeletarCliente;
        private System.Windows.Forms.Button buttonAlterarCliente;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxCpf;
        private System.Windows.Forms.TextBox textBoxTelefone;
    }
}