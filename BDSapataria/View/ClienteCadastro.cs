using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using BDSapataria.Control;
using BDSapataria.Model;

namespace BDSapataria.View
{
    public partial class ClienteCadastro : MaterialForm
    {
        public ClienteCadastro()
        {
            InitializeComponent();
           
          
        }

        private void buttonCadastrarCliente_Click(object sender, EventArgs e)
        {
           
        }

        private void ClienteCadastro_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Cliente.CpfCliente = textBoxCpf.Text;
            Cliente.Fone = textBoxFone.Text;
            Cliente.Endereco = textBoxEndereco.Text;
            Cliente.NomeCli = textBoxNome.Text;
            ManipulaCliente manipulaCliente = new ManipulaCliente();
            manipulaCliente.cadastrarCliente();

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
