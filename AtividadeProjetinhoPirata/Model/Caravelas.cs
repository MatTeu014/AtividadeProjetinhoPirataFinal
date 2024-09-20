using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeProjetinhoPirata.Model
{
    internal class Caravelas
    {
        private static int codigo;
        private static string nome;
        private static string rum;
        private static int moedasouro;
        private static int moedasprata;
        private static int mapas;
        private static int balascanhao;
        private static string comida;
        private static int piratas;
        private static int joias;

        public static int Codigo { get => codigo; set => codigo = value; }
        public static string Nome { get => nome; set => nome = value; }
        public static string Rum { get => rum; set => rum = value; }
        public static int Moedasouro { get => moedasouro; set => moedasouro = value; }
        public static int Moedasprata { get => moedasprata; set => moedasprata = value; }
        public static int Mapas { get => mapas; set => mapas = value; }
        public static int Balascanhao { get => balascanhao; set => balascanhao = value; }
        public static string Comida { get => comida; set => comida = value; }
        public static int Piratas { get => piratas; set => piratas = value; }
        public static int Joias { get => joias; set => joias = value; }
    }
}
