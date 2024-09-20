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
    public partial class TelaVisualizarPiratas : Form
    {
        public TelaVisualizarPiratas()
        {
            InitializeComponent();
        }

        private void botao_pesquisar_Click(object sender, EventArgs e)
        {
            Piratas.Nome = texto_nome.Text;
            dataGridView1.DataSource = ControllerPirata.VisualizarNomePiratas();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;

            dataGridView1.Columns[7].HeaderCell.Value = "Código";
            dataGridView1.Columns[8].HeaderCell.Value = "Nome";
            dataGridView1.Columns[9].HeaderCell.Value = "Pilhagens";
            dataGridView1.Columns[10].HeaderCell.Value = "Maldição";
            dataGridView1.Columns[11].HeaderCell.Value = "Moedas de Ouro";
            dataGridView1.Columns[12].HeaderCell.Value = "Pistolas";
            dataGridView1.Columns[13].HeaderCell.Value = "Sabres";


        }
    }
}
