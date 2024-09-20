using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeProjetinhoPirata.Model
{
    internal class Conexao
    {
        public static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\matpa\source\repos\AtividadeProjetinhoPirata3-master\AtividadeProjetinhoPirata\Dados\bdPirataria.mdf;Integrated Security=True";
        }
    }
}
