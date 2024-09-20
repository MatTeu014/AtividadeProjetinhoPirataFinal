using AtividadeProjetinhoPirata.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeProjetinhoPirata.Controller
{
    internal class ControllerPirata
    {
        public void CadastrarPiratas()
        {


            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_CadastrarPiratas", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@nome", Piratas.Nome);
                cmd.Parameters.AddWithValue("@pilhagens", Piratas.Pilhagens);
                cmd.Parameters.AddWithValue("@maldicao", Piratas.Maldicao);
                cmd.Parameters.AddWithValue("@moedasouro", Piratas.Moedasouro);
                cmd.Parameters.AddWithValue("@pistolas", Piratas.Pistolas);
                cmd.Parameters.AddWithValue("@sabres", Piratas.Sabres);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registros inseridos com sucesso.");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AlterarPiratas()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_AlterarPiratas", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigo", Piratas.Codigo);
                cmd.Parameters.AddWithValue("@nome", Piratas.Nome);
                cmd.Parameters.AddWithValue("@pilhagens", Piratas.Pilhagens);
                cmd.Parameters.AddWithValue("@maldicao", Piratas.Maldicao);
                cmd.Parameters.AddWithValue("@moedasouro", Piratas.Moedasouro);
                cmd.Parameters.AddWithValue("@pistolas", Piratas.Pistolas);
                cmd.Parameters.AddWithValue("@sabres", Piratas.Sabres);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registros alterados com sucesso.");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static BindingSource VisualizarNomePiratas()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_VisualizarNomePiratas", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nome", Piratas.Nome);
            cn.Open();
            cmd.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();
            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;
        }

        public void VisualizarCodigoPirata()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_VisualizarCodigoPirata", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("codigo", Piratas.Codigo);
                cn.Open();
                cmd.ExecuteNonQuery();

                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Piratas.Codigo = Convert.ToInt16(dr["codigo"]);
                    Piratas.Nome = dr["nome"].ToString();
                    Piratas.Pilhagens = (int)dr["pilhagens"];
                    Piratas.Maldicao = dr["maldicao"].ToString();
                    Piratas.Moedasouro = (int)dr["moedasouro"];
                    Piratas.Pistolas = (int)dr["pistolas"];
                    Piratas.Sabres = (int)dr["sabres"];
                }
                else
                {
                    Piratas.Nome = "";
                    Piratas.Pilhagens = 0;
                    Piratas.Maldicao = "";
                    Piratas.Moedasouro = 0;
                    Piratas.Pistolas = 0;
                    Piratas.Sabres = 0;
                    MessageBox.Show("Código não localizado.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ExcluirPirata()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_ExcluirPirata", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("codigo", Piratas.Codigo);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registros excluidos com sucesso.");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }   
}
