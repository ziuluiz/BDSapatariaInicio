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
    public partial class GerenciarCliente : MaterialForm
    {
        public GerenciarCliente()
        {
            InitializeComponent();
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);
            
        }

        private void buttonAlterarCliente_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonDeletarCliente_Click(object sender, EventArgs e)
        {
          
           
        }

        private void buttonPesquisarCliente_Click(object sender, EventArgs e)
        {
           
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Cliente.CpfCliente = textBoxCpf.Text;
            Cliente.NomeCli = textBoxNome.Text;
            Cliente.Fone = textBoxTelefone.Text;
            Cliente.Endereco = textBoxEndereco.Text;

            ManipulaCliente manipulaCliente = new ManipulaCliente();
            manipulaCliente.alterarCliente();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Cliente.CpfCliente = textBoxCpf.Text;
            ManipulaCliente manipulaCliente = new ManipulaCliente();
            manipulaCliente.deletarCliente();
            textBoxCpf.Text = "";
            textBoxNome.Text = "";
            textBoxTelefone.Text = "";
            textBoxEndereco.Text = "";
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            Cliente.CpfCliente = textBoxCpf.Text;

            ManipulaCliente manipulaCliente = new ManipulaCliente();
            manipulaCliente.visualizarCpfCliente();

            textBoxCpf.Text = Cliente.CpfCliente;
            textBoxNome.Text = Cliente.NomeCli;
            textBoxTelefone.Text = Cliente.Fone;
            textBoxEndereco.Text = Cliente.Endereco;
        }

        private void GerenciarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
