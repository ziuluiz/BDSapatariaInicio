using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDSapataria.Control;
using BDSapataria.Model;
using MaterialSkin;
using MaterialSkin.Controls;

namespace BDSapataria.View
{
    public partial class VisualizarVenda : MaterialForm
    {
        public VisualizarVenda()
        {
            InitializeComponent();
        }

        private void buttonBuscarVendasTudo_Click(object sender, EventArgs e)
        {
          
            
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            dataGridViewVendasTudo.DataSource = ManipularVenda.visualizarTudoVenda();
            dataGridViewVendasTudo.Columns[0].Visible = false;
            dataGridViewVendasTudo.Columns[1].Visible = false;
            dataGridViewVendasTudo.Columns[2].Visible = false;
            dataGridViewVendasTudo.Columns[3].Visible = false;


            dataGridViewVendasTudo.Columns[4].HeaderText = "ID Vendas";
            dataGridViewVendasTudo.Columns[5].HeaderText = "Quantidades";
            dataGridViewVendasTudo.Columns[6].HeaderText = "Total Vendas";
            dataGridViewVendasTudo.Columns[7].HeaderText = "Data da Venda";
        }
    }
}
