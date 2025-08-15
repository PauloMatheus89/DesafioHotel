using System.Text;
using ProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

//Cria os Modelos de Hóspedes e cadastra na lista de Hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa("Soraia", "Moura");
Pessoa p2 = new Pessoa("Pedro", "Monteiro");

hospedes.Add(p1);
hospedes.Add(p2);

//Cria Suíte
Suite suite = new Suite(capacidade: 2, tipoSuite: "Luxo");

//Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);


System.Console.WriteLine($"Hospedes: {reserva.ObterQuantidadeHospedes()}");
System.Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
System.Console.WriteLine($"Valor Total: {reserva.CalcularValorTotal()}");




