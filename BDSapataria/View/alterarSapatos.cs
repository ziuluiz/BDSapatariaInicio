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
    public partial class alterarSapatos : Form
    {
        public alterarSapatos()
        {
            InitializeComponent();
        }

        private void buttonBuscarCodigo_Click(object sender, EventArgs e)
        {
            Sapatos.CodProduto = Convert.ToInt32(textBoxDigiteCodSapato);

            ManipulaSapato manipulaSapato = new ManipulaSapato();
            manipulaSapato.visualizarProdutoCodien();

            textBoxAlterarCodSapato.Text = Convert.ToString(Sapatos.CodProduto);
            textBoxAlterarModelo.Text = Convert.ToString(Sapatos.Modelo);
            textBoxAlterarTamanho.Text = Convert.ToString(Sapatos.Tamanho);
            textBoxAlterarGenero.Text = Convert.ToString(Sapatos.Genero);
            textBoxMarcaAlterar.Text = Convert.ToString(Sapatos.Marca);
            textBoxAlterarPreco.Text = Convert.ToString(Sapatos.Preco);
        }

        private void buttonAlterarSapato_Click(object sender, EventArgs e)
        {
            ManipulaSapato manipulaSapato = new ManipulaSapato();
            manipulaSapato.alterarSapato();

            textBoxAlterarModelo.Text = Convert.ToString(Sapatos.Modelo);
            textBoxAlterarTamanho.Text = Convert.ToString(Sapatos.Tamanho);
            textBoxAlterarGenero.Text = Convert.ToString(Sapatos.Genero);
            textBoxMarcaAlterar.Text = Convert.ToString(Sapatos.Marca);
            textBoxAlterarPreco.Text = Convert.ToString(Sapatos.Preco);
        }

        private void buttonDeletarCodigo_Click(object sender, EventArgs e)
        {
            ManipulaSapato manipulaSapato = new ManipulaSapato();
            manipulaSapato.deletarSapato();

            textBoxAlterarCodSapato.Text = "";
            textBoxAlterarModelo.Text = ""; 
            textBoxAlterarTamanho.Text = "";
            textBoxAlterarGenero.Text = "";
            textBoxMarcaAlterar.Text = "";
            textBoxAlterarPreco.Text = "";
        }
    }
}
