namespace Cadastro
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public decimal CustoPorParticipante { get; set; }

        // Método para calcular a duração em dias
        public int Duracao => (DataTermino - DataInicio).Days;

        // Método para calcular o custo total
        public decimal CustoTotal => NumeroParticipantes * CustoPorParticipante;
    }
}