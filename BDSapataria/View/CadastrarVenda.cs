using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDSapataria.Model;
using BDSapataria.Control;

namespace BDSapataria.View
{
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Vendas.Quantidade = Convert.ToInt32(textBoxQuantidaCadastrar.Text);
            Vendas.ValorTotal = Convert.ToInt32(textBoxValorTotalCadastrar.Text);
            Vendas.DataDaTime = Convert.ToDateTime(dateTimePickerDataVendaCadastrar.Value.Date.ToString("dd/MM/yy")); ;

            ManipularVenda manipularVenda = new ManipularVenda();
            manipularVenda.cadastrarVenda();
        }
    }
}
