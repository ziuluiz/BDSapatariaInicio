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
using MaterialSkin.Controls;
using MaterialSkin;

namespace BDSapataria.View
{
    public partial class cadastrarSapatos : MaterialForm
    {
        public cadastrarSapatos()
        {
            InitializeComponent();
        }

        private void buttonCadastrarSapato_Click(object sender, EventArgs e) 
        {
           ;

        }

        private void buttonCadastrarSapato_Click_1(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Sapatos.Modelo = textBoxCadastraMarca.Text;
            Sapatos.Tamanho = textBoxCadastrarTamanho.Text;
            Sapatos.Genero = textBoxCadastraGenero.Text;
            Sapatos.Marca = textBoxCadastraMarca.Text;
            Sapatos.Preco = Convert.ToDouble((textBoxCadastraPreco.Text));

            ManipulaSapato manipulaSapato = new ManipulaSapato();
            manipulaSapato.cadastrarSapatos();
        }
    }
}
