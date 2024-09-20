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
    public partial class TelaVisualizarCaravelas : Form
    {
        public TelaVisualizarCaravelas()
        {
            InitializeComponent();
        }

        private void botao_pesquisar_Click(object sender, EventArgs e)
        {
            Caravelas.Nome = texto_nome.Text;
            dataGridView1.DataSource = ControllerCaravela.VisualizarNomeCaravela();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;

            dataGridView1.Columns[10].HeaderCell.Value = "Código";
            dataGridView1.Columns[11].HeaderCell.Value = "Nome";
            dataGridView1.Columns[12].HeaderCell.Value = "Rum";
            dataGridView1.Columns[13].HeaderCell.Value = "Moedas de Ouro";
            dataGridView1.Columns[14].HeaderCell.Value = "Moedas de Prata";
            dataGridView1.Columns[15].HeaderCell.Value = "Mapas";
            dataGridView1.Columns[16].HeaderCell.Value = "Balas de Canhão";
            dataGridView1.Columns[17].HeaderCell.Value = "Comida";
            dataGridView1.Columns[18].HeaderCell.Value = "Piratas";
            dataGridView1.Columns[19].HeaderCell.Value = "Joias";
            

        }
    }
}
