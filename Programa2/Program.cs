using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Número de entrada
            int n = 23336014;

            if (n > 0)
            {
                //Saber si el número tiene un número par de dígitos
                int contador = 0;

                int aux = n;
                while (aux > 0)
                {
                    aux = aux / 10;
                    contador++;
                }
                //Console.WriteLine("Digitos: " + contador);

                if (contador % 2 == 0)
                {
                    EsCapicua(n);
                }
                else
                {
                    Console.WriteLine("La entrada siempre debe tener un número par de digitos, según las especificaciones");
                }


            }
            else
            {
                Console.WriteLine("inválido");
            }

            
        }

        private static void EsCapicua(int n)
        {
            int aux, inverso = 0, digito;
            aux = n;
            while (aux != 0)
            {
                digito = aux % 10;
                inverso = inverso * 10 + digito;
                aux = aux / 10;
            }

            if (n == inverso)
            {
                Console.WriteLine("Es Capicua");
            }
            else
            {
                int contador = 0;

                int aux2 = n;
                while (aux2 > 0)
                {
                    aux2 = aux2 / 10;
                    contador++;
                }

                if (contador == 2)
                {
                    Console.WriteLine("No es Capicua");
                }
                else
                {
                    //suma de los digitos adyacentes
                    int[] v = n.ToString().Select(d => int.Parse(d.ToString())).ToArray(); //pasar el número a un vector
                    List<int> list = new List<int>();

                    for (int i = 0; i < v.Length; i=i+2)
                    {
                        int suma=0;
                        suma = v[i] + v[i + 1];
                        list.Add(suma);
                        
                    }

                    //Pasar la lista a un número
                    int numero = 0;

                    for (int i = 0; i < list.Count; i++)
                    {
                        numero = (numero * 10) + list[i];
                    }

                    Console.WriteLine("El número formado por los elementos de la lista es: " + numero);

                    EsCapicua(numero);
                    
                }

            }

        }

    }
}
