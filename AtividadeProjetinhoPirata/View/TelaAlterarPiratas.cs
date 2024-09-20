using AtividadeProjetinhoPirata.Controller;
using AtividadeProjetinhoPirata.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeProjetinhoPirata.View
{
    public partial class TelaAlterarPiratas : Form
    {
        public TelaAlterarPiratas()
        {
            InitializeComponent();
        }

        private void botao_pesquisar_Click(object sender, EventArgs e)
        {
            Piratas.Codigo = Convert.ToInt16(texto_codigo.Text);

            ControllerPirata controllerpirata = new ControllerPirata();
            controllerpirata.VisualizarCodigoPirata();

            texto_nome.Text = Piratas.Nome;
            texto_pilhagens.Text = Piratas.Pilhagens.ToString();
            texto_maldicao.Text = Piratas.Maldicao.ToString();
            texto_ouro.Text = Piratas.Moedasouro.ToString();
            texto_pistolas.Text = Piratas.Pistolas.ToString();
            texto_sabres.Text = Piratas.Sabres.ToString();

        }

        private void botao_alterar_Click(object sender, EventArgs e)
        {
            if (texto_codigo.Text == "")
            {
                MessageBox.Show("Digite o Código do Pirata.");
            }
            else
            {

                var resposta = MessageBox.Show("Deseja Alterar os dados do pirata: " + texto_nome.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Piratas.Nome = texto_nome.Text;
                    Piratas.Pilhagens = Convert.ToInt16(texto_pilhagens.Text);
                    Piratas.Maldicao = texto_maldicao.Text;
                    Piratas.Moedasouro = Convert.ToInt16(texto_ouro.Text);
                    Piratas.Pistolas = Convert.ToInt16(texto_pistolas.Text);
                    Piratas.Sabres = Convert.ToInt16(texto_sabres.Text);

                    ControllerPirata controllerpirata = new ControllerPirata();
                    controllerpirata.AlterarPiratas();
                }
                else
                {
                    texto_nome.Text = "";
                    texto_pilhagens.Text = 0.ToString();
                    texto_maldicao.Text = "";
                    texto_ouro.Text = 0.ToString();
                    texto_pistolas.Text = 0.ToString();
                    texto_sabres.Text = 0.ToString();
                }
            }
        }

        private void botao_excluir_Click(object sender, EventArgs e)
        {
            if (texto_codigo.Text == "")
            {
                MessageBox.Show("Digite o Código do Pirata.");
            }
            else
            {

                var resposta = MessageBox.Show("Deseja Excluir os dados do pirata: " + texto_nome.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Piratas.Nome = texto_nome.Text;
                    Piratas.Pilhagens = Convert.ToInt16(texto_pilhagens.Text);
                    Piratas.Maldicao = texto_maldicao.Text;
                    Piratas.Moedasouro = Convert.ToInt16(texto_ouro.Text);
                    Piratas.Pistolas = Convert.ToInt16(texto_pistolas.Text);
                    Piratas.Sabres = Convert.ToInt16(texto_sabres.Text);

                    ControllerPirata controllerpirata = new ControllerPirata();
                    controllerpirata.ExcluirPirata();
                }
                else
                {
                    texto_nome.Text = "";
                    texto_pilhagens.Text = 0.ToString();
                    texto_maldicao.Text = "";
                    texto_ouro.Text = 0.ToString();
                    texto_pistolas.Text = 0.ToString();
                    texto_sabres.Text = 0.ToString();
                }
            }
        }
    }
}
