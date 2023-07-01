using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa1
{
    class Program
    {

        static List<int> datosHexLat = new List<int>();
        static List<int> impares = new List<int>();
        static List<int> secuenciaNumeros = new List<int>();
        static void Main(string[] args)
        {
            int r = 0;

            for (int i = 0; i < 1000; i++)
            {
                r = 0;
                r = 3 * i * (i + 1) + 1;
                datosHexLat.Add(r);
            }

            int r2 = 0;
            for (int i = 0; i < 1000; i++)
            {
                r2 = 0;
                r2 = 2 * i + 1;
                impares.Add(r2);
            }

            for (int i = 1; i < 1000; i++)
            {
                secuenciaNumeros.Add(i);
            }

            HexLattice(61);


        }

        private static void HexLattice(int n)
        {
            if (n > 0)
            {
                if (datosHexLat.Contains(n))
                {
                    //Console.WriteLine("el número es HexLattice");

                    int centro = impares[datosHexLat.IndexOf(n)];
                    int primera = secuenciaNumeros[datosHexLat.IndexOf(n)];
                    int ultima = secuenciaNumeros[datosHexLat.IndexOf(n)];
                    int segunda = 0;
                    int segundaAbj = 0;
                    int a = 0;

                    for (int i = 0; i < primera; i++)
                    {
                        Console.Write(" * ");
                    }

                    segunda = primera + 1;
                    while (segunda < centro)
                    {

                        Console.Write("\n");
                        for (int i = 0; i < segunda; i++)
                        {
                            Console.Write(" * ");

                        }

                        if (segunda < centro)
                        {
                            segunda++;
                        }
                        else
                        {
                            break;
                        }


                    }
                    //centro
                    Console.WriteLine();
                    for (int i = 0; i < centro; i++)
                    {
                        Console.Write(" * ");
                    }

                    //

                    segundaAbj = centro - 1;
                    while (segundaAbj > ultima)
                    {

                        Console.Write("\n");
                        for (int i = 0; i < segundaAbj; i++)
                        {
                            Console.Write(" * ");

                        }

                        if (segundaAbj > ultima)
                        {
                            segundaAbj--;
                        }
                        else
                        {
                            break;
                        }


                    }


                    //
                    Console.WriteLine();
                    for (int i = 0; i < ultima; i++)
                    {
                        Console.Write(" * ");
                    }


                }
                else
                {
                    Console.WriteLine("el número no es HexLattice");
                }
            }
            else
            {
                Console.WriteLine("inválido");
            }
        }
    }
}