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
    public partial class TelaCadastroCaravela : Form
    {
        public TelaCadastroCaravela()
        {
            InitializeComponent();
        }

        private void botao_cadastrar_Click(object sender, EventArgs e)
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
            controllercaravela.CadastrarCaravela();

            texto_nome.Text = "";
            texto_rum.Text = "";
            texto_ouro.Text = "";
            texto_prata.Text = "";
            texto_mapas.Text = "";
            texto_balas.Text = "";
            texto_comida.Text = "";
            texto_piratas.Text = "";
            texto_joias.Text = "";

        }
    }
}
