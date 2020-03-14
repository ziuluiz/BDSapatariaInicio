using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using BDSapataria.Model;
using BDSapataria.Control;

namespace BDSapataria.View
{
    public partial class TelaDeCadastroFuncionario : MaterialForm
    {
        public TelaDeCadastroFuncionario()
        {
            InitializeComponent();

        }

        private void materialRaisedButtonCadFun_Click(object sender, EventArgs e)
        {
            Funcionario.NumRegistro = Convert.ToInt32(textBoxCadNRegistro.Text);
            Funcionario.NomeFun = textBoxCadNome.Text;
            Funcionario.Cpf = textBoxCadCPF.Text;
            Funcionario.DtNasci = textBoxCadDtNasci.Text;
            Funcionario.FoneFun = textBoxCadTel.Text;
            Funcionario.Senha = textBoxCadSenha.Text;

            ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
            manipulaFuncionario.CadastrarFuncionario();

            textBoxCadNRegistro.Text = "";
            textBoxCadNome.Text = "";
            textBoxCadCPF.Text = "";
            textBoxCadDtNasci.Text = "";
            textBoxCadTel.Text = "";
            textBoxCadSenha.Text = "";
        }

        private void materialRaisedButtonCadVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaDeLogin telaDeLogin = new TelaDeLogin();
            telaDeLogin.Closed += (s, args) => this.Close();
            telaDeLogin.ShowDialog();
        }

    }//fim da classse
}//fim do projeto
