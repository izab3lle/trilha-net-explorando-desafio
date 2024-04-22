using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();
List<Reserva> reservas = new List<Reserva>();

for(int i = 1; i < 5; i++)
{
    hospedes.Add(new Pessoa(nome: $"Hóspede {i}", sobrenome: $"H{i}"));
}

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 4, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
//Cadastrando hóspedes 1 e 2 na primeira reserva
Reserva reserva1 = new Reserva(diasReservados: 10);
reserva1.CadastrarSuite(suite);
reserva1.CadastrarHospedes(new List<Pessoa>() {hospedes[0], hospedes[1]});

//Cadastrando hóspedes 2, 3 e 4 na segunda reserva
Reserva reserva2 = new Reserva(diasReservados: 4);
reserva2.CadastrarSuite(suite);
reserva2.CadastrarHospedes(new List<Pessoa>() {hospedes[1], hospedes[2], hospedes[3]});

//Adicionando as reservas na lista
reservas.Add(reserva1);
reservas.Add(reserva2);

// Exibe um resumo da reserva com a quantidade de hóspedes e o valor da diária
foreach(Reserva reserva in reservas)
{
    reserva.ImprimirReserva();
}