using System;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace SaidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            SaidaDados();
            EntradaDados();
            SomarDoisNumeros();
            QualERaio();
            DiferencaProduto();
            SalarioFun();
            ValorPeça();
            ENegativo();
            EMultiplo();
            JogoHora();
        }

        #region SaidaDados
        static void SaidaDados()
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            string result = $"Produtos: \n{produto1}, cujo preço é {preco1} \n{produto2}, cujo preço é $ {preco2} \n\nRegistro: {idade} anos de idades, código {codigo} e gênero: {genero} \n\nMedida com oito casas decimais: {medida:F8} \nArredondado(três casas decimais): {medida:F3} \nSeparador decimal invariant culture: " + medida.ToString("F2", CultureInfo.InvariantCulture);

            Console.WriteLine(result);
        }
        #endregion

        #region EntradaDados
        static void EntradaDados()
        {
            Console.WriteLine("\nEntre com seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("\nQuantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEntre com o proço de um produto:");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("\nEntre com seu último nome, idade e altura(mesma linha):");
            string[] vet = Console.ReadLine().Split(' ');

            Console.WriteLine("\nOs dados que você escreveu foi:");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(vet[0]);
            Console.WriteLine(vet[1]);
            Console.WriteLine(vet[2]);
        }
        #endregion

        #region SomarDoisNumeros
        static void SomarDoisNumeros()
        {

            Console.WriteLine("Escreva um numero:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva outro numero");
            int b = int.Parse(Console.ReadLine());
            var result = a + b;

            Console.WriteLine($"SOMA = {result}");
        }
        #endregion

        #region QualERaio
        static void QualERaio()
        {
            double pi = 3.14159;
            Console.WriteLine("Escreva o valor do raio: (double)");
            double raio = double.Parse(Console.ReadLine());
            double area = pi * (raio * raio);

            Console.WriteLine($"A = {area:F4}");
        }
        #endregion

        #region DiferencaProduto

        static void DiferencaProduto()
        {
            Console.WriteLine("Escreva um numero:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva outro numero:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva outro numero:");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva outro numero:");
            int d = int.Parse(Console.ReadLine());

            int produto = (a * b) - (c * d);
            Console.WriteLine($"DIFERENÇA = {produto}");
        }
        #endregion

        #region SalarioFun
        static void SalarioFun()
        {
            Console.WriteLine($"Qual é o numero do funcionário?");
            int funNumero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Qual é o numero de horas trabalhadas?");
            int horasTrabalhas = int.Parse(Console.ReadLine());

            Console.WriteLine($"Quanto ele recebe por hora?");
            double valorHora = double.Parse(Console.ReadLine());

            double result = valorHora * horasTrabalhas;

            Console.WriteLine($"Number = {funNumero} \nSalary = U$ {result:F2}");
        }
        #endregion

        #region ValorPeça
        static void ValorPeça()
        {
            int cod1, cod2, qte1, qte2;
            double preco1, preco2, total;

            string[] valores = Console.ReadLine().Split(' ');
            cod1 = int.Parse(valores[0]);
            qte1 = int.Parse(valores[1]);
            preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            cod2 = int.Parse(valores[0]);
            qte2 = int.Parse(valores[1]);
            preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total = preco1 * qte1 + preco2 * qte2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
        #endregion

        #region ENegativo
        static void ENegativo()
        {
            int N = int.Parse(Console.ReadLine());

            if (N < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NAO NEGATIVO");
            }
        }
        #endregion

        #region EMultiplo
        static void EMultiplo()
        {
            string[] valores = Console.ReadLine().Split(' ');
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }

        }
        #endregion

        #region JogoHora
        static void JogoHora()
        {
            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            int duracao;
            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
        #endregion


    }
}