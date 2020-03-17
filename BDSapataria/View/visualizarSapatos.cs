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

namespace BDSapataria.View
{
    public partial class visualizarSapatos : Form
    {
        public visualizarSapatos()
        {
            InitializeComponent();
        }

        private void buttonBuscarSapatoTudo_Click(object sender, EventArgs e)
        {
            dataGridViewSaptosTudo.DataSource = ManipulaSapato.visualizarTudoSapato();
            dataGridViewSaptosTudo.Columns[0].Visible = false;
            dataGridViewSaptosTudo.Columns[1].Visible = false;
            dataGridViewSaptosTudo.Columns[2].Visible = false;
            dataGridViewSaptosTudo.Columns[3].Visible = false;
            dataGridViewSaptosTudo.Columns[4].Visible = false;


            dataGridViewSaptosTudo.Columns[5].HeaderText = "Codigo Sapato";
            dataGridViewSaptosTudo.Columns[6].HeaderText = "Tamanho";
            dataGridViewSaptosTudo.Columns[7].HeaderText = "Genero";
            dataGridViewSaptosTudo.Columns[8].HeaderText = "Marca";
            dataGridViewSaptosTudo.Columns[9].HeaderText = "Preço";
        }
    }
}
