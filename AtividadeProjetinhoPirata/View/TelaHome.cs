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
    public partial class TelaHome : Form
    {
        public TelaHome()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void caravelasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastroCaravela telacadastrocaravela = new TelaCadastroCaravela();
            telacadastrocaravela.Show();
        }

        private void piratasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastroPiratas telacadastropiratas = new TelaCadastroPiratas();
            telacadastropiratas.Show();
        }

        private void caravelasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaVisualizarCaravelas telavisualizarcaravelas = new TelaVisualizarCaravelas();
            telavisualizarcaravelas.Show();
        }

        private void piratasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaVisualizarPiratas telavisualizarpiratas = new TelaVisualizarPiratas();
            telavisualizarpiratas.Show();
        }

        private void caravelasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TelaAlterarCaravela telaalterarcaravela = new TelaAlterarCaravela();
            telaalterarcaravela.Show();
        }

        private void piratasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TelaAlterarPiratas telaalterarpiratas = new TelaAlterarPiratas();
            telaalterarpiratas.Show();
        }
    }
}
