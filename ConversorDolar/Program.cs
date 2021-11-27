using System;
using System.Globalization;

namespace ConversorDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Usuário digita a cotação e os dolares que ele quer converter
            Console.WriteLine("Qual é a cotação do dólar?");
            Console.Write("R$ ");
            double cot = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dólares você irá comprar?");
            Console.Write("$");
            double dol = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Conversor conversor = new Conversor(dol, cot);

            //Impressão da conversão sem e com IOF
            Console.WriteLine("Valor a ser pago em reais = R$ " + conversor.ConversaoSemIOF());
            Console.WriteLine("Valor a ser pago de IOF = 4,08%");
            Console.WriteLine("Valor total da compra com IOF = R$ " + conversor.ConversaoComIOF());
            
        }
    }
}
