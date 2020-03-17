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
using MaterialSkin.Controls;
using MaterialSkin;

namespace BDSapataria.View
{
    public partial class AlterarVenda : MaterialForm
    {
        public AlterarVenda()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
           
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Vendas.Idvenda = Convert.ToInt32(textBoxIDVendaDigitar);

            ManipularVenda manipularVenda = new ManipularVenda();
            manipularVenda.visualizarIDVendien();

            textBoxIDvendaAlterar.Text = Convert.ToString(Vendas.Idvenda);
            textBoxQuantidaAlterar.Text = Convert.ToString(Vendas.Quantidade);
            textBoxValorTotalAlterar.Text = Convert.ToString(Vendas.ValorTotal);
            dateTimePickerDataVendaAlterar.Text = Convert.ToString(Vendas.DataDaTime);
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            ManipularVenda manipularVenda = new ManipularVenda();
            manipularVenda.deletarVenda();

            textBoxIDvendaAlterar.Text = "";
            textBoxQuantidaAlterar.Text = "";
            textBoxValorTotalAlterar.Text = "";
            dateTimePickerDataVendaAlterar.Text = "";
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            ManipularVenda manipularVenda = new ManipularVenda();
            manipularVenda.alteraVenda();

            textBoxQuantidaAlterar.Text = Convert.ToString(Vendas.Quantidade);
            textBoxValorTotalAlterar.Text = Convert.ToString(Vendas.ValorTotal);
            dateTimePickerDataVendaAlterar.Text = Convert.ToString(Vendas.DataDaTime);
        }
    }
}
