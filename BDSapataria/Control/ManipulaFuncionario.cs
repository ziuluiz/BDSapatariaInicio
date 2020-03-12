using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BDSapataria.Model;
using System.Windows.Forms;

namespace BDSapataria.Control
{
    class ManipulaFuncionario
    {
        public void CadastrarFuncionario()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarFuncionario", cn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@numRegistro", Funcionario.NumRegistro);
            cmd.Parameters.AddWithValue("@nomeFun", Funcionario.NomeFun);
            cmd.Parameters.AddWithValue("CPF", Funcionario.Cpf);
            cmd.Parameters.AddWithValue("@dtNasci", Funcionario.DtNasci);
            cmd.Parameters.AddWithValue("@foneFun", Funcionario.FoneFun);
            cmd.Parameters.AddWithValue("@senha", Funcionario.Senha);

            cn.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Cadastro concluido!");
            
        }//fim do cadastrar funcionario

        public void AlterarFuncionario()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pAlterarFuncionario", cn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nomeFun", Funcionario.NomeFun);
            cmd.Parameters.AddWithValue("CPF", Funcionario.Cpf);
            cmd.Parameters.AddWithValue("@dtNasci", Funcionario.DtNasci);
            cmd.Parameters.AddWithValue("@foneFun", Funcionario.FoneFun);
            cmd.Parameters.AddWithValue("@senha", Funcionario.Senha);

            cn.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Dados alterados!");
        }//fim do alterar funcionario

        public static BindingSource VisualizarTodosFuncionario()
        {


            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pVisualizarTodosFuncionario", cn);


            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            BindingSource dados = new BindingSource();
            dados.DataSource = dt;

            return dados;
        }//fim do visualizar todos funcionario

        public void VisualizarCPFFuncionario()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pVisualizarCPFFuncionario", cn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CPF", Funcionario.Cpf);

            cn.Open();
            var dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Funcionario.Cpf = (string)dr["CPF"];
                Funcionario.NomeFun = (string)dr["nome"];
                Funcionario.FoneFun = (string)dr["fone"];
                Funcionario.NumRegistro = (int)dr["numRegistro"];
                Funcionario.DtNasci = (string)dr["dtNasci"];
            }
            else
            {
                MessageBox.Show("Dados não encontrados!");
            }
        }//fim do visualizar cpf funcionario

        public void DeletarFuncionario()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pDeletarFuncionario", cn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CPF", Funcionario.Cpf);

            cn.Open();
            cmd.ExecuteNonQuery();


            MessageBox.Show("Cliente deletado com sucesso!");
        }

    }//fim da classe
}//fim do projeto
