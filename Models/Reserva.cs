namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // [x]: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // [x]: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                throw new Exception("A quantidade de hóspedes não pode exceder a capacidade da suíte");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // [x]: Retorna a quantidade de hóspedes (propriedade Hospedes)
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // [x]: Retorna o valor da diária
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valor *= (decimal)0.9;
            }

            return valor;
        }
    
        public void ListarHospedes()
        {
            foreach(Pessoa hospede in Hospedes)
            {
                Console.WriteLine(hospede.NomeCompleto);
            }
        }

        public void ImprimirReserva()
        {
            Console.WriteLine("\n");
            Console.WriteLine($"Hóspedes: {ObterQuantidadeHospedes()}");
            ListarHospedes();
            Console.WriteLine($"Tipo de suíte: {Suite.TipoSuite}");
            Console.WriteLine($"Valor diária: {CalcularValorDiaria():C2}");
        }
    }
}