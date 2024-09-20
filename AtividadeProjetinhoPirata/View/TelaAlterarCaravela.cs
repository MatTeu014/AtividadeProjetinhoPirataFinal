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
    public partial class TelaAlterarCaravela : Form
    {
        public TelaAlterarCaravela()
        {
            InitializeComponent();
        }

        private void botao_pesquisar_Click(object sender, EventArgs e)
        {
            Caravelas.Codigo = Convert.ToInt16(texto_codigo.Text);

            ControllerCaravela controllerpirata = new ControllerCaravela();
            controllerpirata.VisualizarCodigoCaravela();

            texto_nome.Text = Caravelas.Nome;
            texto_rum.Text = Caravelas.Rum;
            texto_ouro.Text = Caravelas.Moedasouro.ToString();
            texto_prata.Text = Caravelas.Moedasprata.ToString();
            texto_mapas.Text = Caravelas.Mapas.ToString();
            texto_balas.Text = Caravelas.Balascanhao.ToString();
            texto_comida.Text = Caravelas.Comida;
            texto_piratas.Text = Caravelas.Piratas.ToString();
            texto_joias.Text = Caravelas.Joias.ToString();
        }

        private void botao_alterar_Click(object sender, EventArgs e)
        {
            if (texto_codigo.Text == "")
            {
                MessageBox.Show("Digite o Código da Caravela");
            }
            else
            {
                var resposta = MessageBox.Show("Deseja Alterar os Dados da Caravela: " + texto_nome.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Caravelas.Nome = texto_nome.Text;
                    Caravelas.Rum = texto_rum.Text;
                    Caravelas.Moedasouro = Convert.ToInt16(texto_ouro.Text);
                    Caravelas.Moedasprata = Convert.ToInt16(texto_prata.Text);
                    Caravelas.Mapas = Convert.ToInt16(texto_mapas.Text);
                    Caravelas.Balascanhao = Convert.ToInt16(texto_balas.Text);
                    Caravelas.Comida = texto_comida.Text;
                    Caravelas.Piratas = Convert.ToInt16(texto_piratas.Text);
                    Caravelas.Joias = Convert.ToInt16(texto_joias.Text);

                    ControllerCaravela controllercaravela = new ControllerCaravela();
                    controllercaravela.AlterarCaravela();

                }
                else
                {
                    texto_nome.Text = "";
                    texto_rum.Text = "";
                    texto_ouro.Text = 0.ToString();
                    texto_prata.Text = 0.ToString();
                    texto_mapas.Text = 0.ToString();
                    texto_balas.Text = 0.ToString();
                    texto_comida.Text = "";
                    texto_piratas.Text = 0.ToString();
                    texto_joias.Text = 0.ToString();
                }
            }
        }

        private void botao_excluir_Click(object sender, EventArgs e)
        {
            if (texto_codigo.Text == "")
            {
                MessageBox.Show("Digite o Código da Caravela");
            }
            else
            {
                var resposta = MessageBox.Show("Deseja Excluir os Dados da Caravela: " + texto_nome.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Caravelas.Nome = texto_nome.Text;
                    Caravelas.Rum = texto_rum.Text;
                    Caravelas.Moedasouro = Convert.ToInt16(texto_ouro.Text);
                    Caravelas.Moedasprata = Convert.ToInt16(texto_prata.Text);
                    Caravelas.Mapas = Convert.ToInt16(texto_mapas.Text);
                    Caravelas.Balascanhao = Convert.ToInt16(texto_balas.Text);
                    Caravelas.Comida = texto_comida.Text;
                    Caravelas.Piratas = Convert.ToInt16(texto_piratas.Text);
                    Caravelas.Joias = Convert.ToInt16(texto_joias.Text);
                    
                    ControllerCaravela controllercaravela = new ControllerCaravela();
                    controllercaravela.ExcluirCaravela();
                    

                }
                else
                {
                    texto_nome.Text = "";
                    texto_rum.Text = "";
                    texto_ouro.Text = 0.ToString();
                    texto_prata.Text = 0.ToString();
                    texto_mapas.Text = 0.ToString();
                    texto_balas.Text = 0.ToString();
                    texto_comida.Text = "";
                    texto_piratas.Text = 0.ToString();
                    texto_joias.Text = 0.ToString();
                }
            }
        }
    }
}
