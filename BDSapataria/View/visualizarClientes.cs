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
    public partial class visualizarClientes : MaterialForm
    {
        public visualizarClientes()
        {
            InitializeComponent();
        }

        private void visualizarClientes_Load(object sender, EventArgs e)
        {

        }

        private void buttonVisualizar_Click(object sender, EventArgs e)
        {
            dataGridViewCliente.DataSource = ManipulaCliente.visualizarTodosCliente();


            dataGridViewCliente.Columns[0].Visible = false;
            dataGridViewCliente.Columns[1].Visible = false;
            dataGridViewCliente.Columns[2].Visible = false;
            dataGridViewCliente.Columns[3].Visible = false;
            dataGridViewCliente.Columns[4].Visible = false;

            dataGridViewCliente.Columns[5].HeaderText = "Cpf";
            dataGridViewCliente.Columns[6].HeaderText = "Nome";
            dataGridViewCliente.Columns[7].HeaderText = "Endereco";
            dataGridViewCliente.Columns[8].HeaderText = "Telefone";
            

        }
    }
}
