using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMosquitoVelho
{
    public class Operacoes
    {
        //metodo construtor
        public Operacoes() 
        {

        }
        public double somar(double valor1, double valor2)
        {
            return (valor1 + valor2);
        }
        public double subtrair(double valor1, double valor2)
        {
            return (valor1 - valor2);
        }
        public double multiplicar(double valor1, double valor2)
        {
            return (valor1 * valor2);
        }
        public double dividir(double valor1, double valor2)
        {
            if (valor2 != 0)
            {
                return (valor1 / valor2);
            }
            else
            {
                return 0;
            }
        }
    }
}
