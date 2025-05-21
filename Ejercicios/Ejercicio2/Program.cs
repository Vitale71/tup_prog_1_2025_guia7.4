using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float recaudacion = 0;
            int motoT = 0, autoT = 0, utilitarioT = 0, camionT = 0;
            Console.WriteLine("ingrese un numero cualquiera si hay una zona de estacionamiento o -1 para salir");
            int zonas = Convert.ToInt32(Console.ReadLine());
            while (zonas != -1)
            {
                #region ingreso de datos
                float acumCoste = 0, porcentajeMoto = 0, porcentajeAuto = 0, porcentajeUtilitario = 0, porcentajeCamion = 0, motoCosto = 0, autoCosto =0, utilitarioCosto = 0, camionCosto = 0;
                Console.WriteLine("ingrese el valor por estacionamiento de motos");
                int motosP = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingrese el valor por estacionamiento de autos");
                int autosP = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingrese el valor por estacionamiento de utilitarios");
                int utilitariosP = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingrese el valor por estacionamiento de camiones");
                int camionesP = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingrese el costo por hora");
                int coste = Convert.ToInt32(Console.ReadLine());
                #endregion

                #region iterar zona
                Console.WriteLine("ingrese el vehiculo que haya entrado al estacionamiento o -1 si se finalizo el dia");
                Console.WriteLine("si es moto (0), si es auto (1), si es utilitario (2), si es camion (3)");
                int zona = Convert.ToInt32(Console.ReadLine());
                while (zona != -1)
                {
                    float calculoCoste = 0;
                    switch (zona)
                    {
                        case 0:
                            motoT++;
                            Console.WriteLine("ingrese las horas que estuvo adquirido");
                            int horas = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ingrese los minutos");
                            int minutos = Convert.ToInt32(Console.ReadLine());
                            calculoCoste = horas*coste;
                            if (minutos > 0)
                            {
                                calculoCoste += (coste / 60) * minutos;
                            }
                            calculoCoste += motosP;
                            Console.WriteLine("el coste por hora es de: ${0}, el vehiculo estuvo este tiempo {1}:{2}" ,coste ,horas, minutos);
                            Console.WriteLine("el valor total por las horas ocupadas es de: $" +calculoCoste);
                            acumCoste += calculoCoste;
                            motoCosto += calculoCoste;
                            recaudacion += calculoCoste;
                            break;

                        case 1:
                            autoT++;
                            Console.WriteLine("ingrese las horas que estuvo adquirido");
                            horas = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ingrese los minutos");
                            minutos = Convert.ToInt32(Console.ReadLine());
                            calculoCoste = horas * coste;
                            if (minutos > 0)
                            {
                                calculoCoste += (coste / 60) * minutos;
                            }
                            calculoCoste += autosP;
                            Console.WriteLine("el coste por hora es de: ${0}, el vehiculo estuvo este tiempo {1}:{2}", coste, horas, minutos);
                            Console.WriteLine("el valor total por las horas ocupadas es de: $" + calculoCoste);
                            acumCoste += calculoCoste;
                            autoCosto += calculoCoste;
                            recaudacion += calculoCoste;
                            break;

                        case 2:
                            utilitarioT++;
                            Console.WriteLine("ingrese las horas que estuvo adquirido");
                            horas = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ingrese los minutos");
                            minutos = Convert.ToInt32(Console.ReadLine());
                            calculoCoste = horas * coste;
                            if (minutos > 0)
                            {
                                calculoCoste += (coste / 60) * minutos;
                            }
                            calculoCoste += utilitariosP;
                            Console.WriteLine("el coste por hora es de: ${0}, el vehiculo estuvo este tiempo {1}:{2}", coste, horas, minutos);
                            Console.WriteLine("el valor total por las horas ocupadas es de: $" + calculoCoste);
                            acumCoste += calculoCoste;
                            utilitarioCosto += calculoCoste;
                            recaudacion += calculoCoste;
                            break;

                        case 3:
                            camionT++;
                            Console.WriteLine("ingrese las horas que estuvo adquirido");
                            horas = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ingrese los minutos");
                            minutos = Convert.ToInt32(Console.ReadLine());
                            calculoCoste = horas * coste;
                            if (minutos > 0)
                            {
                                calculoCoste += (coste / 60) * minutos;
                            }
                            calculoCoste += camionesP;
                            Console.WriteLine("el coste por hora es de: ${0}, el vehiculo estuvo este tiempo {1}:{2}", coste, horas, minutos);
                            Console.WriteLine("el valor total por las horas ocupadas es de: $" + calculoCoste);
                            acumCoste += calculoCoste;
                            camionCosto += calculoCoste;
                            recaudacion += calculoCoste;
                            break;

                        default:
                            Console.WriteLine("numero no valido vuelva a intentarlo");
                            break;
                    }
                    Console.WriteLine("ingrese el vehiculo que haya entrado al estacionamiento o -1 si se finalizo el dia");
                    Console.WriteLine("si es moto (0), si es auto (1), si es utilitario (2), si es camion (3)");
                    zona = Convert.ToInt32(Console.ReadLine());
                }
                #endregion

                #region mostrar jornada del dia
                Console.WriteLine("la recaudacion total de esta zona fue de: $" +acumCoste);
                if (motoCosto > 0)
                {
                    porcentajeMoto = (motoCosto * 100) / acumCoste;
                    Console.WriteLine("El porcentaje de recaudacion de motos es de: {0:f1}%", porcentajeMoto);
                }
                else
                {
                    Console.WriteLine("El porcentaje de recaudacion de motos es de : 0.0%");
                }
                if (autoCosto > 0)
                {
                    porcentajeAuto = (autoCosto * 100) / acumCoste;
                    Console.WriteLine("El porcentaje de recaudacion de autos es de: {0:f1}%", porcentajeAuto);
                }
                else
                {
                    Console.WriteLine("El porcentaje de recaudacion de autos es de : 0.0%");
                }
                if (utilitarioCosto > 0)
                {
                    porcentajeUtilitario = (utilitarioCosto * 100) / acumCoste;
                    Console.WriteLine("El porcentaje de recaudacion de utilitario es de: {0:f1}%", porcentajeUtilitario);
                }
                else
                {
                    Console.WriteLine("El porcentaje de recaudacion de utilitario es de : 0.0%");
                }
                if (camionCosto > 0)
                {
                    porcentajeCamion = (camionCosto * 100) / acumCoste;
                    Console.WriteLine("El porcentaje de recaudacion de camiones es de: {0:f1}%", porcentajeCamion);
                }
                else
                {
                    Console.WriteLine("El porcentaje de recaudacion de camiones es de : 0.0%");
                }
                #endregion

                Console.WriteLine("ingrese un numero cualquiera si hay una zona de estacionamiento o -1 para salir");
                zonas = Convert.ToInt32(Console.ReadLine());
            }

            #region informe de la empresa
            Console.WriteLine("la recaudacion total de todas las zonas fue de: $" + recaudacion);
            int totalVehiculos = motoT + autoT + utilitarioT + camionT;
            if (motoT > 0)
            {
                float porcentajeMotoT = (motoT * 100f) / totalVehiculos;
                Console.WriteLine("El porcentaje de motos total es de: {0:f1}", porcentajeMotoT);
            }
            else
            {
                Console.WriteLine("El porcentaje de motos total es de: 0");
            }
            if (autoT > 0)
            {
                float porcentajeAutoT = (autoT * 100f) / totalVehiculos;
                Console.WriteLine("El porcentaje de autos total es de: {0:f1}", porcentajeAutoT);
            }
            else
            {
                Console.WriteLine("El porcentaje de autos total es de: 0");
            }
            if (utilitarioT > 0)
            {
                float porcentajeUtilitarioT = (utilitarioT * 100f) / totalVehiculos;
                Console.WriteLine("El porcentaje de utilitarios total es de: {0:f1}", porcentajeUtilitarioT);
            }
            else
            {
                Console.WriteLine("El porcentaje de utilitario total es de: 0");
            }
            if (camionT > 0)
            {
                float porcentajeCamionT = (camionT * 100f) / totalVehiculos;
                Console.WriteLine("El porcentaje de camiones total es de: {0:f1}", porcentajeCamionT);
            }
            else
            {
                Console.WriteLine("El porcentaje de camiones total es de : 0");
            }
            #endregion
        }
    }
}
