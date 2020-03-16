using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using BDSapataria.Model;
using BDSapataria.Control;

namespace BDSapataria.View
{
    public partial class TelaDeLogin : MaterialForm
    {
        public TelaDeLogin()
        {
            InitializeComponent();
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            Funcionario.Cpf = textBoxCPFLogin.Text;
            Funcionario.Senha = textBoxSenhaLogin.Text;

            ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
            manipulaFuncionario.LogarFuncionario();

            if (Funcionario.Cpf == Funcionario.ConfirmaCPF ||
                Funcionario.Senha == Funcionario.ConfirmaSenha)
            {
                /*this.Hide();
                TelaDeReserva telaDeReserva = new TelaDeReserva();
                telaDeReserva.Closed += (s, args) => this.Close();
                telaDeReserva.ShowDialog();*/
            }
        }

        private void linkLabelCadastroFun_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            TelaDeCadastroFuncionario telaDeCadastroFuncionario = new TelaDeCadastroFuncionario();
            telaDeCadastroFuncionario.Closed += (s, args) => this.Close();
            telaDeCadastroFuncionario.ShowDialog();            

        }

        private void textBoxSenhaLogin_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxSenhaLogin.Text = "";
            textBoxSenhaLogin.PasswordChar = Convert.ToChar("*");
        }

        private void textBoxCPFLogin_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxCPFLogin.Text = "";
        }
    }//fim da classe
}//fim do projeto 
