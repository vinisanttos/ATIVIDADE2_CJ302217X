namespace ATIVIDADE2_CJ302217X
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////////// EXERCICICO 1 ////////////////////

            float salario;

            Console.WriteLine("Entre com o seu Salário:");
            salario = float.Parse(Console.ReadLine());

            salario = salario + (25.0f / 100.0f) * salario;

            Console.WriteLine("O novo salário é R$ {0}", salario);


            //////////////////// EXERCICICO 2 ////////////////////

            Console.WriteLine("Entre com o número:");
            int n1 = int.Parse(Console.ReadLine());

            int soma = (n1 * 3 + 1) + (n1 * 2 - 1);

            Console.WriteLine("o número é: " + soma);


            //////////////////// EXERCICICO 3 ///////////////////

            float bolsa;

            bolsa = 1000;

            bolsa = bolsa - (bolsa / 1000) * 3.4f;
            bolsa = bolsa + (bolsa / 1000) + 2.8f;
            bolsa = bolsa + (bolsa / 1000) + 14;
            bolsa = bolsa - (bolsa / 1000) - 8.5f;

            Console.WriteLine("O valor do investimento é {0}", bolsa);


        }
    }
}
