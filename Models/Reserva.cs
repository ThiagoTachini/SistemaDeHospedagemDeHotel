using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _003_End_to_End_Projeto.Models
{
    public class Reserva
    {
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
        public List<Pessoa> Hospedes = new List<Pessoa>();
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if(true){
                if(hospedes.Count() <= Suite.Capacidade){
                    Hospedes = hospedes;
                }
                else{
                    throw new Exception("Quantidade de hospedes maior que a capacidade da suíte");
                }
            
            }
        }
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }
        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count();
        }
        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;
            if(DiasReservados >= 10){
                valor = valor * 0.9M;
            }
            return valor;
        }
    }
}