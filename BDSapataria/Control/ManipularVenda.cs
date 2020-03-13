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
    class ManipularVenda
    {
        public void cadastrarVenda() 
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar);
            SqlCommand cmd = new SqlCommand("pCadastrarVenda", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@quantidade", Vendas.Quantidade);
                cmd.Parameters.AddWithValue("@valorTotal", Vendas.ValorTotal);
                cmd.Parameters.AddWithValue("@dataDaVenda", Vendas.DataDaTime);

                SqlParameter nv = cmd.Parameters.Add("@Idvenda", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Deu Certo");
            }
            catch (Exception)
            {

                throw;
            }
        
        }

        public void alteraVenda() 
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pAlterarVenda", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@quantidade", Vendas.Quantidade);
                cmd.Parameters.AddWithValue("@valorTotal", Vendas.ValorTotal);
                cmd.Parameters.AddWithValue("@dataDaVenda", Vendas.DataDaTime);

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deu certo");

            }
            catch (Exception)
            {

                throw;
            }


        }

        public void deletarVenda() 
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pDeletarVenda", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdVenda", Sapatos.CodProduto);
                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Venda excluida com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static BindingSource visualizarTudoVenda()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pVisualizarVendasTudo", cn);
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

        public static BindingSource visualizarTudoIDVenda()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pVisualizarIDVendas", cn);
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

        public void visualizarIDVendien() 
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pVisualizarSapatosCodigo", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdReserva", Sapatos.CodProduto);
                cn.Open();
                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    Vendas.Idvenda = (int)(dr["codProduto"]);
                    Vendas.Quantidade = (int)(dr["modelo"]);
                    Vendas.ValorTotal = (float)(dr["valorTotal"]);
                    Vendas.DataDaTime = (DateTime)(dr["dataDeVenda"]);
                    

                }
                else
                {
                    MessageBox.Show("Venda não encontrado");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
