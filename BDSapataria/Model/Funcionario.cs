using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDSapataria.Model
{
    class Funcionario
    {
        private static int numRegistro;
        private static string nomeFun;
        private static string cpf;
        private static string dtNasci;
        private static string foneFun;
        private static string senha;
        private static string confirmaSenha;
        private static string confirmaCPF;

        public static int NumRegistro { get => numRegistro; set => numRegistro = value; }
        public static string NomeFun { get => nomeFun; set => nomeFun = value; }
        public static string Cpf { get => cpf; set => cpf = value; }
        public static string DtNasci { get => dtNasci; set => dtNasci = value; }
        public static string FoneFun { get => foneFun; set => foneFun = value; }
        public static string Senha { get => senha; set => senha = value; }
        public static string ConfirmaSenha { get => confirmaSenha; set => confirmaSenha = value; }
        public static string ConfirmaCPF { get => confirmaCPF; set => confirmaCPF = value; } 

    }//fim da classe
}//fim do projeto
