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
    public partial class TelaCadastroPiratas : Form
    {
        public TelaCadastroPiratas()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void botao_cadastrar_Click(object sender, EventArgs e)
        {
            Piratas.Nome = texto_nome.Text;
            Piratas.Pilhagens = Convert.ToInt16(texto_pilhagens.Text);
            Piratas.Maldicao = texto_maldicao.Text;
            Piratas.Moedasouro = Convert.ToInt16(texto_ouro.Text);
            Piratas.Pistolas = Convert.ToInt16(texto_pistolas.Text);
            Piratas.Sabres = Convert.ToInt16(texto_sabres.Text);

            ControllerPirata controllerpirata = new ControllerPirata();
            controllerpirata.CadastrarPiratas();

            texto_nome.Text = "";
            texto_pilhagens.Text = "";
            texto_maldicao.Text = "";
            texto_ouro.Text = "";
            texto_pistolas.Text = "";
            texto_sabres.Text = "";

        }
    }
}
