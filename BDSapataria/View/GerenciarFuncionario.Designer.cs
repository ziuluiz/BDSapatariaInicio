namespace BDSapataria.View
{
    partial class GerenciarFuncionario
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewTodosFun = new System.Windows.Forms.DataGridView();
            this.materialButtonVisuTodosFun = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialButtonVisuCPFFun = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxVisuCPF = new System.Windows.Forms.TextBox();
            this.textBoxVisuNome = new System.Windows.Forms.TextBox();
            this.textBoxVisuDtNasci = new System.Windows.Forms.TextBox();
            this.textBoxVisuFone = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButtonDeletaFun = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxDeletaFun = new System.Windows.Forms.TextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodosFun)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(12, 80);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(674, 454);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialButtonVisuTodosFun);
            this.tabPage1.Controls.Add(this.dataGridViewTodosFun);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(666, 428);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Visualizar todos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialLabel4);
            this.tabPage2.Controls.Add(this.materialLabel3);
            this.tabPage2.Controls.Add(this.materialLabel2);
            this.tabPage2.Controls.Add(this.materialLabel1);
            this.tabPage2.Controls.Add(this.textBoxVisuFone);
            this.tabPage2.Controls.Add(this.textBoxVisuDtNasci);
            this.tabPage2.Controls.Add(this.textBoxVisuNome);
            this.tabPage2.Controls.Add(this.textBoxVisuCPF);
            this.tabPage2.Controls.Add(this.materialButtonVisuCPFFun);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(666, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Visualizar por CPF";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.materialLabel5);
            this.tabPage3.Controls.Add(this.textBoxDeletaFun);
            this.tabPage3.Controls.Add(this.materialButtonDeletaFun);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(666, 428);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Deletar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTodosFun
            // 
            this.dataGridViewTodosFun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTodosFun.Location = new System.Drawing.Point(21, 104);
            this.dataGridViewTodosFun.Name = "dataGridViewTodosFun";
            this.dataGridViewTodosFun.Size = new System.Drawing.Size(626, 306);
            this.dataGridViewTodosFun.TabIndex = 0;
            // 
            // materialButtonVisuTodosFun
            // 
            this.materialButtonVisuTodosFun.AutoSize = true;
            this.materialButtonVisuTodosFun.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonVisuTodosFun.Depth = 0;
            this.materialButtonVisuTodosFun.Icon = null;
            this.materialButtonVisuTodosFun.Location = new System.Drawing.Point(195, 35);
            this.materialButtonVisuTodosFun.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonVisuTodosFun.Name = "materialButtonVisuTodosFun";
            this.materialButtonVisuTodosFun.Primary = true;
            this.materialButtonVisuTodosFun.Size = new System.Drawing.Size(268, 36);
            this.materialButtonVisuTodosFun.TabIndex = 1;
            this.materialButtonVisuTodosFun.Text = "Visualizar todos os funcionarios";
            this.materialButtonVisuTodosFun.UseVisualStyleBackColor = true;
            this.materialButtonVisuTodosFun.Click += new System.EventHandler(this.materialButtonVisuTodosFun_Click);
            // 
            // materialButtonVisuCPFFun
            // 
            this.materialButtonVisuCPFFun.AutoSize = true;
            this.materialButtonVisuCPFFun.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonVisuCPFFun.Depth = 0;
            this.materialButtonVisuCPFFun.Icon = null;
            this.materialButtonVisuCPFFun.Location = new System.Drawing.Point(285, 332);
            this.materialButtonVisuCPFFun.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonVisuCPFFun.Name = "materialButtonVisuCPFFun";
            this.materialButtonVisuCPFFun.Primary = true;
            this.materialButtonVisuCPFFun.Size = new System.Drawing.Size(97, 36);
            this.materialButtonVisuCPFFun.TabIndex = 0;
            this.materialButtonVisuCPFFun.Text = "Visualizar";
            this.materialButtonVisuCPFFun.UseVisualStyleBackColor = true;
            this.materialButtonVisuCPFFun.Click += new System.EventHandler(this.materialButtonVisuCPFFun_Click);
            // 
            // textBoxVisuCPF
            // 
            this.textBoxVisuCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVisuCPF.Location = new System.Drawing.Point(213, 75);
            this.textBoxVisuCPF.Name = "textBoxVisuCPF";
            this.textBoxVisuCPF.Size = new System.Drawing.Size(306, 23);
            this.textBoxVisuCPF.TabIndex = 1;
            // 
            // textBoxVisuNome
            // 
            this.textBoxVisuNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVisuNome.Location = new System.Drawing.Point(213, 156);
            this.textBoxVisuNome.Name = "textBoxVisuNome";
            this.textBoxVisuNome.Size = new System.Drawing.Size(306, 23);
            this.textBoxVisuNome.TabIndex = 2;
            // 
            // textBoxVisuDtNasci
            // 
            this.textBoxVisuDtNasci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVisuDtNasci.Location = new System.Drawing.Point(213, 203);
            this.textBoxVisuDtNasci.Name = "textBoxVisuDtNasci";
            this.textBoxVisuDtNasci.Size = new System.Drawing.Size(306, 23);
            this.textBoxVisuDtNasci.TabIndex = 3;
            // 
            // textBoxVisuFone
            // 
            this.textBoxVisuFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVisuFone.Location = new System.Drawing.Point(213, 254);
            this.textBoxVisuFone.Name = "textBoxVisuFone";
            this.textBoxVisuFone.Size = new System.Drawing.Size(306, 23);
            this.textBoxVisuFone.TabIndex = 4;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(58, 75);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(36, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "CPF";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(58, 157);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(50, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Nome";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(58, 204);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(143, 19);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "Data de nascimento";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(58, 255);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(42, 19);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "Fone";
            // 
            // materialButtonDeletaFun
            // 
            this.materialButtonDeletaFun.AutoSize = true;
            this.materialButtonDeletaFun.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonDeletaFun.Depth = 0;
            this.materialButtonDeletaFun.Icon = null;
            this.materialButtonDeletaFun.Location = new System.Drawing.Point(293, 311);
            this.materialButtonDeletaFun.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonDeletaFun.Name = "materialButtonDeletaFun";
            this.materialButtonDeletaFun.Primary = true;
            this.materialButtonDeletaFun.Size = new System.Drawing.Size(79, 36);
            this.materialButtonDeletaFun.TabIndex = 0;
            this.materialButtonDeletaFun.Text = "Deletar";
            this.materialButtonDeletaFun.UseVisualStyleBackColor = true;
            this.materialButtonDeletaFun.Click += new System.EventHandler(this.materialButtonDeletaFun_Click);
            // 
            // textBoxDeletaFun
            // 
            this.textBoxDeletaFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDeletaFun.Location = new System.Drawing.Point(202, 234);
            this.textBoxDeletaFun.Name = "textBoxDeletaFun";
            this.textBoxDeletaFun.Size = new System.Drawing.Size(262, 23);
            this.textBoxDeletaFun.TabIndex = 1;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(170, 140);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(320, 19);
            this.materialLabel5.TabIndex = 2;
            this.materialLabel5.Text = "Digite o CPF do funcionário que deseja deletar";
            // 
            // GerenciarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 546);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "GerenciarFuncionario";
            this.Text = "GerenciarFuncionario";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodosFun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialRaisedButton materialButtonVisuTodosFun;
        private System.Windows.Forms.DataGridView dataGridViewTodosFun;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox textBoxVisuFone;
        private System.Windows.Forms.TextBox textBoxVisuDtNasci;
        private System.Windows.Forms.TextBox textBoxVisuNome;
        private System.Windows.Forms.TextBox textBoxVisuCPF;
        private MaterialSkin.Controls.MaterialRaisedButton materialButtonVisuCPFFun;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.TextBox textBoxDeletaFun;
        private MaterialSkin.Controls.MaterialRaisedButton materialButtonDeletaFun;
    }
}