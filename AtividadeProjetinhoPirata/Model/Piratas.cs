using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeProjetinhoPirata.Model
{
    internal class Piratas
    {
        private static int codigo;
        private static string nome;
        private static int pilhagens;
        private static string maldicao;
        private static int moedasouro;
        private static int pistolas;
        private static int sabres;

        public static int Codigo { get => codigo; set => codigo = value; }
        public static string Nome { get => nome; set => nome = value; }
        public static int Pilhagens { get => pilhagens; set => pilhagens = value; }
        public static string Maldicao { get => maldicao; set => maldicao = value; }
        public static int Moedasouro { get => moedasouro; set => moedasouro = value; }
        public static int Pistolas { get => pistolas; set => pistolas = value; }
        public static int Sabres { get => sabres; set => sabres = value; }
    }
}
