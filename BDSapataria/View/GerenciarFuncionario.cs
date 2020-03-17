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
using BDSapataria.Control;
using BDSapataria.Model;

namespace BDSapataria.View
{
    public partial class GerenciarFuncionario : MaterialForm
    {
        public GerenciarFuncionario()
        {
            InitializeComponent();
        }

        private void materialButtonVisuTodosFun_Click(object sender, EventArgs e)
        {
            dataGridViewTodosFun.DataSource = ManipulaFuncionario.VisualizarTodosFuncionario();

            for (int i = 0; i <= 4; i++)
            {
                dataGridViewTodosFun.Columns[i].HeaderCell.Value = "N° Registro";
                dataGridViewTodosFun.Columns[i].HeaderCell.Value = "Nome";
                dataGridViewTodosFun.Columns[i].HeaderCell.Value = "CPF";
                dataGridViewTodosFun.Columns[i].HeaderCell.Value = "Data de Nascimento";
                dataGridViewTodosFun.Columns[i].HeaderCell.Value = "Fone";
            }
        }

        private void materialButtonVisuCPFFun_Click(object sender, EventArgs e)
        {
            Funcionario.Cpf = textBoxVisuCPF.Text;

            ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
            manipulaFuncionario.VisualizarCPFFuncionarios();

            textBoxVisuNome.Text = Funcionario.NomeFun;
            textBoxVisuDtNasci.Text = Funcionario.DtNasci;
            textBoxVisuFone.Text = Funcionario.FoneFun;
        }

        private void materialButtonDeletaFun_Click(object sender, EventArgs e)
        {
            Funcionario.Cpf = textBoxDeletaFun.Text;

            ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
            manipulaFuncionario.DeletarFuncionario();
        }
    }//fim da classe
}//fim do projeto
