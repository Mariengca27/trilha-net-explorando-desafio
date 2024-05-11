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
        
           int capacidade = Suite.Capacidade;  

            if (capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                Console.WriteLine("A capacidade da suite é menor que o número de hóspedes.");
    }

}

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
        
        return Hospedes.Count;

        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
           decimal ValorDiaria = DiasReservados * Suite.ValorDiaria;
            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados >= 10)
            {

                ValorDiaria = ValorDiaria - (ValorDiaria * 0.1m);
            }

            return ValorDiaria;
        }
    }
}