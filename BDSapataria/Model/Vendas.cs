using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDSapataria.Model
{
    class Vendas
    {
        private static int idvenda;
        private static int quantidade;
        private static float valorTotal;
        private static DateTime dataDaTime;

        public static int Idvenda { get => idvenda; set => idvenda = value; }
        public static int Quantidade { get => quantidade; set => quantidade = value; }
        public static float ValorTotal { get => valorTotal; set => valorTotal = value; }
        public static DateTime DataDaTime { get => dataDaTime; set => dataDaTime = value; }
    }
}
