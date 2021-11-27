using System;
using System.Collections.Generic;
using System.Text;

namespace ConversorDolar

{
    class Conversor
    {
        //Variáveis e uso do encapsulamento
        public double Dolar { get; private set; }
        public double Cotacao { get; private set;}
       
        //Construtor vazio
        public Conversor()
        {
        }

        //Construtor personalizado
        public Conversor(double dolar, double cotacao)
        {
            Dolar = dolar;
            Cotacao = cotacao;            
        }

        //Método de conversão sem IOF
        public double ConversaoSemIOF()
        {
            double Final = Dolar * Cotacao;
            return Final;
        }

        //Método de conversão sem IOF
        public double ConversaoComIOF()
        {
            return ((ConversaoSemIOF() / 100.00) * 4.08) + ConversaoSemIOF();            
        }

        
    }
}
