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
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void buttonCadastrarCliente_Click(object sender, EventArgs e)
        {
            Cliente.cpfCliente = textBoxCpf.Text;
            Cliente.fone = textBoxFone.Text;
            Cliente.endereco = textBoxEndereco.Text;
            Cliente.nomeCli = textBoxNome.Text;
            ManipulaCliente manipulaCliente = new ManipulaCliente();
            manipulaCliente.cadastrarCliente();
        }

        private void ClienteCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
