using AtividadeProjetinhoPirata.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeProjetinhoPirata.Controller
{
    internal class ControllerCaravela
    {
        public void CadastrarCaravela()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_CadastrarCaravela", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nome", Caravelas.Nome);
                cmd.Parameters.AddWithValue("@rum", Caravelas.Rum);
                cmd.Parameters.AddWithValue("@moedasouro", Caravelas.Moedasouro);
                cmd.Parameters.AddWithValue("@moedasprata", Caravelas.Moedasprata);
                cmd.Parameters.AddWithValue("@mapas", Caravelas.Mapas);
                cmd.Parameters.AddWithValue("@balascanhao", Caravelas.Balascanhao);
                cmd.Parameters.AddWithValue("@comida", Caravelas.Comida);
                cmd.Parameters.AddWithValue("@piratas", Caravelas.Piratas);
                cmd.Parameters.AddWithValue("@joias", Caravelas.Joias);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registros inseridos com sucesso.");

            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public void AlterarCaravela()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_AlterarCaravela", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("codigo", Caravelas.Codigo);
                cmd.Parameters.AddWithValue("@nome", Caravelas.Nome);
                cmd.Parameters.AddWithValue("@rum", Caravelas.Rum);
                cmd.Parameters.AddWithValue("@moedasouro", Caravelas.Moedasouro);
                cmd.Parameters.AddWithValue("@moedasprata", Caravelas.Moedasprata);
                cmd.Parameters.AddWithValue("@mapas", Caravelas.Mapas);
                cmd.Parameters.AddWithValue("@balascanhao", Caravelas.Balascanhao);
                cmd.Parameters.AddWithValue("@comida", Caravelas.Comida);
                cmd.Parameters.AddWithValue("@piratas", Caravelas.Piratas);
                cmd.Parameters.AddWithValue("@joias", Caravelas.Joias);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registros alterados com sucesso.");
            }
            catch (Exception) 
            {
                throw;
            }   
        }
        
        public static BindingSource VisualizarNomeCaravela()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_VisualizarNomeCaravela", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nome",Caravelas.Nome);
            cn.Open();
            cmd.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();
            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;

        }

        
        
        public void VisualizarCodigoCaravela()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_VisualizarCodigoCaravela", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigo", Caravelas.Codigo);
                cn.Open();
                cmd.ExecuteNonQuery();

                var dr = cmd.ExecuteReader();
                if(dr.Read()){
                    Caravelas.Codigo = Convert.ToInt16(dr["codigo"]);
                    Caravelas.Nome = dr["nome"].ToString();
                    Caravelas.Rum = dr["rum"].ToString();
                    Caravelas.Moedasouro = (int)dr["moedasouro"];
                    Caravelas.Moedasprata = (int)dr["moedasprata"];
                    Caravelas.Mapas = (int)dr["mapas"];
                    Caravelas.Balascanhao = (int)dr["balascanhao"];
                    Caravelas.Comida = dr["comida"].ToString();
                    Caravelas.Piratas = (int)dr["piratas"];
                    Caravelas.Joias = (int)dr["joias"];

                }
                else
                {
                    Caravelas.Nome = "";
                    Caravelas.Rum = "";
                    Caravelas.Moedasouro = 0;
                    Caravelas.Moedasprata = 0;
                    Caravelas.Mapas = 0;
                    Caravelas.Balascanhao = 0;
                    Caravelas.Comida = "";
                    Caravelas.Piratas = 0;
                    Caravelas.Joias = 0;
                    MessageBox.Show("Código não localizado.");
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ExcluirCaravela()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_ExcluirCaravela", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigo", Caravelas.Codigo);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados Excluidos com sucesso.");

            }
            catch (Exception)
            {
                throw;                
            }
        }
    }
}
