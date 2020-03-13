using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using BDSapataria.Model;

namespace BDSapataria.Control
{
    class ManipulaCliente
    {
        public void cadastrarCliente()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("@pCadastrarCliente");
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@cpfCliente", Cliente.CpfCliente);
                cmd.Parameters.AddWithValue("@foneCliente", Cliente.Fone);
                cmd.Parameters.AddWithValue("@endereco", Cliente.Endereco);
                cmd.Parameters.AddWithValue("@nomeCli", Cliente.NomeCli);
                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com suscesso!");
            }
            catch (Exception)
            {

                throw;
            }

        }
        public void alterarCliente()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("@pAlterarCliente",cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@cpfCliente", Cliente.CpfCliente);
                cmd.Parameters.AddWithValue("@foneCliente", Cliente.Fone);
                cmd.Parameters.AddWithValue("@endereco", Cliente.Endereco);
                cmd.Parameters.AddWithValue("@nnomeClil", Cliente.NomeCli);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Alteração realizada com suscesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void deletarCliente()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("@DeletarCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@cpfCliente", Cliente.CpfCliente);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente excluido com suscesso!");

            }
            catch (Exception)
            {

                throw;
            }
        }
        public static BindingSource visualizarTodosCliente()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pVisualizarTodosCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            BindingSource dados = new BindingSource();
            dados.DataSource = dt;

            return dados;
        }
        public void  visualizarCpfCliente()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pVisualizarCPFCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@cpfCliente",Cliente.CpfCliente);
                cn.Open();
                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Cliente.CpfCliente = (string)dr["cpfCliente"];
                    Cliente.Endereco = (string)dr["endereco"];
                    Cliente.Fone = (string)dr["foneCliente"];
                    Cliente.NomeCli = (string)dr["NomeCli"];
                }
                else
                {
                    MessageBox.Show("Os dados nao poderam ser encontrados!");
                }
            }
            catch (Exception)
            {

                throw;
            }

           

           
        }
        public void visualizarDeletarCliente()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pDeletarCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@cpfCliente", Cliente.CpfCliente);
                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente excluido com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
