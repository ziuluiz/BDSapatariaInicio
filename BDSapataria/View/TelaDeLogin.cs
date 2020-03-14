using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using BDSapataria.Model;
using BDSapataria.Control;

namespace BDSapataria.View
{
    public partial class TelaDeLogin : MaterialForm
    {
        public TelaDeLogin()
        {
            InitializeComponent();
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
                       
        }

        private void linkLabelCadastroFun_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            TelaDeCadastroFuncionario telaDeCadastroFuncionario = new TelaDeCadastroFuncionario();
            telaDeCadastroFuncionario.Closed += (s, args) => this.Close();
            telaDeCadastroFuncionario.ShowDialog();

        }

    }//fim da classe
}//fim do projeto 
