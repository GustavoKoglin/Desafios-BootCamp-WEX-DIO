using System;
using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// 1. Cadastro de hóspedes
Console.WriteLine("Cadastro de Hóspedes");
Console.Write("Quantidade de hóspedes: ");
int numHospedes = int.Parse(Console.ReadLine());

List<Pessoa> hospedes = new List<Pessoa>();
for (int i = 0; i < numHospedes; i++)
{
    Console.Write($"Nome do hóspede {i+1}: ");
    hospedes.Add(new Pessoa(Console.ReadLine()));
}

// 2. Cadastro da suíte
Console.WriteLine("\nCadastro da Suíte");
Console.Write("Tipo da suíte: ");
string tipoSuite = Console.ReadLine();

Console.Write("Quantidade de Quartos: ");
int quantidadeQuartos = int.Parse(Console.ReadLine());

Console.Write("Tipo de cama: ");
string tipoCama = Console.ReadLine();

Console.Write("Capacidade: ");
int capacidade = int.Parse(Console.ReadLine());

Console.Write("3 Refeições Inclusas? (S/N): ");
string refeicoesInclusas = Console.ReadLine().ToUpper();

Console.Write("Incluir Traslado Aeroporto? (S/N): ");
string trasladoAeroporto = Console.ReadLine().ToUpper();

Console.Write("Incluir Traslado Hotel? (S/N): ");
string trasladoHotel = Console.ReadLine().ToUpper();

Console.WriteLine("Incluir Roteiros Turísticos? (S/N): ");
string roteirosTuristicos = Console.ReadLine().ToUpper();

Console.Write("Valor da diária: ");
decimal valorDiaria = decimal.Parse(Console.ReadLine());

Suite suite = new Suite(tipoSuite, capacidade, valorDiaria);

// 3. Cadastro da reserva
Console.WriteLine("\nCadastro da Reserva");
Console.Write("Dias reservados: ");
int diasReservados = int.Parse(Console.ReadLine());

Reserva reserva = new Reserva(diasReservados);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// 4. Exibir resultados
Console.WriteLine("\nResumo da Reserva");
Console.WriteLine($"Tipo de suíte: {suite.TipoSuite}");
Console.WriteLine($"Quantidade de hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Dias reservados: {reserva.DiasReservados}");
Console.WriteLine($"Valor total: {reserva.CalcularValorDiaria():C}");