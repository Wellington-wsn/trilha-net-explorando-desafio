namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        
        public Suite SuiteReservada { get; set; }
        public int DiasReservados { get; set; }
        public decimal percentual { get; set; }

        public Pessoa pessoa = new Pessoa();

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes()
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI* 
            if (SuiteReservada == null)
            {
                Console.WriteLine("Nenhuma suite reservada.");
            }
            else if(pessoa == null || pessoa.Hospedes.Count == 0)
            {
                pessoa.NovoHospede();
            }
            else if(pessoa.Hospedes.Count < SuiteReservada.Capacidade)
            {
               pessoa.NovoHospede();

            }else
            {
                Console.WriteLine("Suites sem vaga, lotadas!");
            }
        }

        public void ReservarSuite()
        {
            if (SuiteReservada == null)
            {
                Console.WriteLine("Nenhuma suite reservada.");
            }            
            else if(pessoa.Hospedes.Count <= SuiteReservada.Capacidade)
            {
                Console.WriteLine("Informe os dias Reservados");
                DiasReservados = int.Parse(Console.ReadLine());

            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*
                    
                throw new System.Exception($"Capacidade de suites inferior a quantidade de hospedes:" +
                                           $"\r\n Hospedes - {pessoa.Hospedes.Count}" +
                                           $" \r\n Suite - {SuiteReservada.Capacidade}");
            }      
        }

        public void CadastrarSuite()
        {
            Console.WriteLine("Informe o tipo da suite:");
            string tipoSuite = Console.ReadLine();

            Console.WriteLine("Informe a capacidade da suite:");
            int capacidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor da diária:");
            decimal valorDiaria = decimal.Parse(Console.ReadLine());

            SuiteReservada = new Suite(tipoSuite: tipoSuite, capacidade: capacidade, valorDiaria: valorDiaria);
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            if (pessoa.Hospedes == null || pessoa.Hospedes.Count == 0)
            {
                Console.WriteLine("A lista de hóspedes está vazia.");
                return 0;
            }
            else
            {
                return pessoa.Hospedes.Count;;
              
            }
        }

        public decimal CalcularValorDiaria()
        {
            // * Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = 0;

            valor = DiasReservados * SuiteReservada.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados > 10)
            {
                valor -= valor * (percentual/100);
            }

            return valor;
        }

        public void ListaHospedes()
        {
            Console.WriteLine($"Quantidade de Hospedes: {ObterQuantidadeHospedes()}");
            Console.WriteLine("Lista de hóspedes:");
            foreach (var hospede in pessoa.Hospedes)
            {
                Console.WriteLine($"{hospede.NomeCompleto}");
            }
        }
    }
}