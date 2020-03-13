using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDSapataria.Model
{
    class Sapatos
    {
        private static int codProduto;
        private static string modelo;
        private static string tamanho;
        private static string genero;
        private static string marca;
        private static float preco;

        public static int CodProduto { get => codProduto; set => codProduto = value; }
        public static string Modelo { get => modelo; set => modelo = value; }
        public static string Tamanho { get => tamanho; set => tamanho = value; }
        public static string Genero { get => genero; set => genero = value; }
        public static string Marca { get => marca; set => marca = value; }
        public static float Preco { get => preco; set => preco = value; }
    }
}
