//Problema "pagamento"
//Fazer um programa para ler o nome de um(a) funcionário(a), o valor que ele(a) recebe por hora, e a
//quantidade de horas trabalhadas por ele(a). Ao final, mostrar o valor do pagamento do funcionário com
////uma mensagem explicativa.

using System.Globalization;

namespace CalculoPagamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double valorHora, valorPagamento;
            int horasTrabalhadas;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Valor por hora: ");
            valorHora = double.Parse(Console.ReadLine(), CI);

            Console.Write("Horas trabalhadas: ");
            horasTrabalhadas = int.Parse(Console.ReadLine());

            valorPagamento = horasTrabalhadas * valorHora;

            Console.Write($"O pagamento para {nome} deve ser {valorPagamento.ToString("F2", CI)}");
        }
    }
}
