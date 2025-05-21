using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int encuestadores, encuestados = 0, contB = 0, contM = 0, contA = 0, contT = 0;
            Console.WriteLine("ingrese la cantidad de encuestadores que va haber");
            encuestadores = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < encuestadores; i++)
            {
                int contP = 0, bicicleta = 0, motocicleta = 0, automovil = 0, transporte = 0, acumB = 0, acumM = 0;
                Console.WriteLine("ingrese la primera opinion si hay una persona");
                Console.WriteLine("si su uso mas frecuente es bicicleta (0), motocicleta (1), automovil (2), transporte publico (3)"
                    + "o ponga -1 para salir");
                int persona = Convert.ToInt32(Console.ReadLine());

                #region iterar encuestados
                while (persona != -1)
                {
                    contP++;
                    switch (persona)
                    {
                        case 0: 
                            Console.WriteLine("ingrese distancia aproximada que utiliza la bicicleta");
                            bicicleta++;
                            int distanciaB = Convert.ToInt32(Console.ReadLine());
                            acumB = acumB + distanciaB;
                            break;
                        
                        case 1:
                            Console.WriteLine("ingrese distancia aproximada que utiliza la motocicleta");
                            motocicleta++;
                            int distanciaM = Convert.ToInt32(Console.ReadLine());
                            acumM += distanciaM;
                            break;

                        case 2:
                            Console.WriteLine("ingrese distancia aproximada que utiliza el automovil");
                            automovil++;
                            int distanciaA = Convert.ToInt32(Console.ReadLine());
                            break;

                        case 3:
                            Console.WriteLine("ingrese distancia aproximada que utiliza el transporte");
                            transporte++;
                            int distanciaT = Convert.ToInt32(Console.ReadLine());
                            break;

                        default:
                            Console.WriteLine("numero no valido");
                            contP--;
                        break;
                    }
                    Console.WriteLine("ingrese la siguiente opinion si hay una persona o ponga -1 si no hay persona");
                    Console.WriteLine("si su uso mas frecuente es bicicleta (0), motocicleta (1), automovil (2), transporte publico (4)");
                    persona = Convert.ToInt32(Console.ReadLine());
                }
                #endregion

                #region entrega de datos a la empresa
                Console.WriteLine("el encuestador {0} entrega los siguientes resultados" , i);
                Console.WriteLine("cantidad de encuestados: " + contP);
                Console.WriteLine("cantidad de personas que usan bicicleta: " + bicicleta);
                Console.WriteLine("cantidad de personas que usan motocicleta: " + motocicleta);
                Console.WriteLine("cantidad de personas que usan automovil: " + automovil);
                Console.WriteLine("cantidad de personas que usan transporte publico: " + transporte);
                if (bicicleta > 0)
                {
                    Console.WriteLine("distancia promedio recorrida poara el caso de los usuarios con bicicleta {0:f1}", (acumB / bicicleta));
                }
                else
                {
                    Console.WriteLine("no hay distancia promedio recorrida para el caso de bicicletas");
                }
                if (motocicleta > 0)
                {
                    Console.WriteLine("distancia promedio recorrida poara el caso de los usuarios con motocicleta {0:f1}", (acumM / motocicleta));
                }
                else
                {
                    Console.WriteLine("no hay distancia promedio recorrida para el caso de motocicletas");
                }
                #endregion

                #region actualizar contadores
                encuestados += contP;
                contB += bicicleta;
                contM += motocicleta;
                contA += automovil;
                contT += transporte;
                #endregion

            }
            Console.WriteLine("la cantidad de encuestados total es de: " + encuestados);
            Console.WriteLine("El porcentaje de personas total que utilizan bicicleta: {0:f1} " ,((contB * 100) / encuestados));
            Console.WriteLine("El porcentaje de personas total que utilizan motocicleta: {0:f1} ", ((contM * 100) / encuestados));
            Console.WriteLine("El porcentaje de personas total que utilizan automovil: {0:f1} ", ((contA * 100) / encuestados));
            Console.WriteLine("El porcentaje de personas total que utilizan transporte publico: {0:f1} ", ((contT * 100) / encuestados));
        }
    }
}
