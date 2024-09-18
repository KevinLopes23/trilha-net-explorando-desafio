using System.Security.Cryptography.X509Certificates;

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
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
           
            
            if(Suite.Capacidade < hospedes.Count)
            {
             throw new Exception("Número de hóspedes excede a capacidade da suíte.");    
            }
            else
            {
                Hospedes = hospedes;
            }
           
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
           int qtdHospedes = Hospedes.Count;

          // Console.WriteLine($"A quantidade de hospedes é : {qtdHospedes}");

            return qtdHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria

            decimal ValorDiaria = DiasReservados * Suite.ValorDiaria;
  // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
         if(DiasReservados>= 10){
            ValorDiaria = ValorDiaria * 0.9m;
            }

          //  Console.WriteLine($"O valor da diária é : {ValorDiaria}");

        
            return ValorDiaria;
        }
    }
}