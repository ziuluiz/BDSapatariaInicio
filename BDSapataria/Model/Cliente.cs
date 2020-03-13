using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDSapataria.Model
{
    class Cliente
    {
        private static string cpfCliente;
        private static string fone;
        private static string endereco;
        private static string nomeCli;

        public static string CpfCliente { get => cpfCliente; set => cpfCliente = value; }
        public static string Fone { get => fone; set => fone = value; }
        public static string Endereco { get => endereco; set => endereco = value; }
        public static string NomeCli { get => nomeCli; set => nomeCli = value; }
    }
}
