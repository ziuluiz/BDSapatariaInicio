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
    class ManipulaSapato
    {
        public void cadastrarSapatos() 
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarSapato", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@modelo", Sapatos.Modelo);
                cmd.Parameters.AddWithValue("@tamanho", Sapatos.Tamanho);
                cmd.Parameters.AddWithValue("@genero", Sapatos.Genero);
                cmd.Parameters.AddWithValue("@marca", Sapatos.Marca);
                cmd.Parameters.AddWithValue("@preco", Sapatos.Preco);
                SqlParameter nv = cmd.Parameters.Add("@codProduto", SqlDbType.Int);
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

        public void alterarSapato() 
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pAlterarProduto", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@modelo", Sapatos.Modelo);
                cmd.Parameters.AddWithValue("@tamanho", Sapatos.Tamanho);
                cmd.Parameters.AddWithValue("@genero", Sapatos.Genero);
                cmd.Parameters.AddWithValue("@marca", Sapatos.Marca);
                cmd.Parameters.AddWithValue("@preco", Sapatos.Preco);

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deu certo");

            }
            catch (Exception)
            {

                throw;
            }

        }

        public void deletarSapato() 
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pDeletarProduto", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codProduto", Sapatos.CodProduto);
                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Produto excluido com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static BindingSource visualizarTudoSapato()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pVisualizarSapatoTudo", cn);
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

        public static BindingSource visualizarcodProtudoSapato()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pVisualizarSapatoCodigo", cn);
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

        public void visualizarProdutoCodien()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pVisualizarSapatosCodigo", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdReserva", Sapatos.CodProduto);
                cn.Open();
                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    Sapatos.CodProduto = (int)(dr["codProduto"]);
                    Sapatos.Modelo = (string)(dr["modelo"]);
                    Sapatos.Tamanho = (string)(dr["tamanho"]);
                    Sapatos.Genero = (string)(dr["genero"]);
                    Sapatos.Marca = (string)(dr["marca"]);
                    Sapatos.Preco = (float)(dr["preco"]);

                }
                else
                {
                    MessageBox.Show("Sapato não encontrado");
                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        
    }
}
