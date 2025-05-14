using _003_End_to_End_Projeto.Models;
using System.Text;
 
List<Pessoa> hospedes = new List<Pessoa>();

Suite suite = new Suite("Premium", 2, 30);
Pessoa pessoa = new Pessoa("João", "Silva");
Pessoa pessoa2 = new Pessoa("Maria", "Santos");

hospedes.Add(pessoa);
hospedes.Add(pessoa2);


Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");