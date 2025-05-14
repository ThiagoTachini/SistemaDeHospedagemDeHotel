using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _003_End_to_End_Projeto.Models
{
    public class Suite
    {
        public Suite(string tipoSuite, int capacidade, int valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public int ValorDiaria { get; set; }

    }

}