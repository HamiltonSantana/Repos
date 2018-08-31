using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorBinario
{
    class Program {
        static void Main(string[] args)
        {
            converteParaBinario(12.44);
            Console.ReadKey();
        }
        static void converteParaBinario(double numero) {
            long aux1 = (long)numero;
            double aux2 = numero - aux1;

            Console.WriteLine(aux2);

            transBinarioInteiro((int) aux1);
            transBinarioFracio(aux2);
        }
        static void transBinarioFracio(double v)
        {
            double frac = v;
            
            int inteiro = 0;
            List<int> lista = new List<int>();
            for(int i =0; i<=3; i++) {
                frac = frac * 2;
                inteiro = Convert.ToInt16(Math.Truncate(d: frac));
                lista.Add(inteiro);
                frac = frac - inteiro;
            }
            lista.Reverse();

            lista.ForEach(Console.Write);
        }

        static void transBinarioInteiro(int x)
        {
            int resto = 0;
            List<int> aux = new List<int>();
            
            for(int i = x; i>=1; i--){ 
                if(x == 1)
                {
                    aux.Add(x);
                    break;
                }
                resto = x % 2;

                aux.Add(resto);
                x = x / 2;
            }
            aux.Reverse();
            aux.ForEach(Console.Write);
        }
    }
}
