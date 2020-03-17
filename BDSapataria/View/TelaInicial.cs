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

namespace BDSapataria.View
{
    public partial class TelaInicial : MaterialForm
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void materialButtonGereClie_Click(object sender, EventArgs e)
        {
            this.Hide();
            GerenciarCliente gerenciarCliente = new GerenciarCliente();
            gerenciarCliente.Closed += (s, args) => this.Close();
            gerenciarCliente.ShowDialog();
        }

        private void materialButtonVisuClie_Click(object sender, EventArgs e)
        {
            this.Hide();
            visualizarClientes visualizarClientes = new visualizarClientes();
            visualizarClientes.Closed += (s, args) => this.Close();
            visualizarClientes.ShowDialog();
        }

        private void materialButtonCadClie_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClienteCadastro clienteCadastro = new ClienteCadastro();
            clienteCadastro.Closed += (s, args) => this.Close();
            clienteCadastro.ShowDialog();
        }

        private void materialButtonAltProd_Click(object sender, EventArgs e)
        {
            this.Hide();
            alterarSapatos alterarSapatos = new alterarSapatos();
            alterarSapatos.Closed += (s, args) => this.Close();
            alterarSapatos.ShowDialog();
        }

        private void materialButtonVisuProd_Click(object sender, EventArgs e)
        {
            this.Hide();
            visualizarSapatos visualizarSapatos = new visualizarSapatos();
            visualizarSapatos.Closed += (s, args) => this.Close();
            visualizarSapatos.ShowDialog();
        }

        private void materialButtonCadProd_Click(object sender, EventArgs e)
        {
            this.Hide();
            cadastrarSapatos cadastrarSapatos = new cadastrarSapatos();
            cadastrarSapatos.Closed += (s, args) => this.Close();
            cadastrarSapatos.ShowDialog();
        }

        private void materialButtonAltVend_Click(object sender, EventArgs e)
        {
            this.Hide();
            AlterarVenda alterarVenda = new AlterarVenda();
            alterarVenda.Closed += (s, args) => this.Close();
            alterarVenda.ShowDialog();
        }

        private void materialButtonVisuVend_Click(object sender, EventArgs e)
        {
            this.Hide();
            VisualizarVenda visualizarVenda = new VisualizarVenda();
            visualizarVenda.Closed += (s, args) => this.Close();
            visualizarVenda.ShowDialog();
        }

        private void materialButtonCadVend_Click(object sender, EventArgs e)
        {
            
        }
    }//fim da classe
}//fim do projeto
