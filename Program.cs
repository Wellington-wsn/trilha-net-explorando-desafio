using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();
Reserva reserva = new Reserva();
reserva.percentual = 10;

while(true){

    Console.WriteLine("-- SISTEMA DE HOSPEDAGEM --");
    Console.WriteLine("- Cadastrar Hospede: Digite 1");
    Console.WriteLine("- Cadastrar Suites: Digite 2");
    Console.WriteLine("- Lista de Hospedes: Digite 3");
    Console.WriteLine("- Rezervar Suite: Digite 4");
    Console.WriteLine("  -------------  ");
    Console.WriteLine("-- FINANCEIRO --");
    Console.WriteLine("- Alterar porcentagem de descoto: Digite 5");
    Console.WriteLine("- Exibe a quantidade de hóspedes e o valor da diária: Dogite 6");
    Console.WriteLine("- Encerrar Sistema: Digite 9");

    switch (Convert.ToInt32(Console.ReadLine()))
    {
        case 1:
            reserva.CadastrarHospedes();
            Console.ReadKey();
            break;            

        case 2:
            reserva.CadastrarSuite();
            Console.ReadKey();
            break;

        case 3:
            reserva.ListaHospedes();
            Console.ReadKey();
            break;

        case 4:
            reserva.ReservarSuite();
            Console.ReadKey();
            break;

        case 5:
            Console.WriteLine("Defina o valor para porcentagem de deaconto");
            reserva.percentual = decimal.Parse(Console.ReadLine());
            Console.ReadKey();
            break;

        case 6:
            Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
            Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
            Console.ReadKey();
            break;

        case 9:
            return;

        default: 
            Console.WriteLine("Opção invalida!");
            Console.ReadKey();
            break;

    }
    System.Console.Clear();
}