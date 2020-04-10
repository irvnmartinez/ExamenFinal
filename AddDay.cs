using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;


namespace Examen_Final___Estadisticas_COVID
{
    class AddDay
    {
        public static void AgregarDia()
        {
            try
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\n\n\n\n\n");
                Console.WriteLine("                     Ingrese el nombre de la provincia a la que desea agregar nuevos resultados");
                Console.Write("                                   (Tomar en consideracion las mayusculas y espacios): ");
                string prov = Console.ReadLine();

                if (Menu.TheStats.Exists(a => a.Provincia == prov))
                {

                    foreach (Class b in Menu.TheStats)
                    {
                        if (b.Provincia == prov)
                        {
                            Console.Clear();
                            Class newday = new Class();
                            
                            Console.WriteLine("\n\n\n\n\n");
                            Console.Write("                              > Ingrese la cantidad de infectados registrados hoy: ");
                            int nd = Convert.ToInt32(Console.ReadLine());
                            newday.TodayNew = nd;
                            newday.Provincia = b.Provincia;
                            newday.Fallecidos = b.Fallecidos;
                            newday.Yesterday = b.TotalCasos;
                            newday.TotalCasos = b.TotalCasos + nd;
                            newday.Recuperados = b.Recuperados;

                            double fc = newday.TotalCasos / newday.Yesterday;
                            newday.Estimacion = Convert.ToDouble(fc * newday.TotalCasos);

                            Menu.TheStats[Menu.TheStats.FindIndex(ind => ind.Equals(b))] = newday;
                          
                            Console.WriteLine("\n\n                        Se ha completado el registro de manera exitosa ");
                            Console.WriteLine("\n\n                     [ Pulse cualquier tecla para volver al menu principal ]");
                            Console.ReadKey();
                            Menu.Lobby();
                            
                        }


                    }

                }
                else
                {
                    Console.WriteLine("\n\n\n\n\n");
                    Console.WriteLine("               La provincia que ingreso no se encuentra en el sistema, ¿Quiere realizar otra busqueda?");
                    Console.WriteLine("\n                                      " +
                        "[1]    Si                          [2] No");
                    int opc = Convert.ToInt32(Console.ReadLine());

                    switch (opc)
                    {
                        case 1:
                            AgregarDia();
                            break;
                        case 2:
                            Console.WriteLine("\n\n                                  [ Presione cualquier letra para volver al lobby ]");
                            Console.ReadKey();
                            Menu.Lobby();
                            break;
                        

                            
                    }
                }


            }
            catch (Exception error)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\n\n\n\n");
                Console.WriteLine("                           Ha ocurrido un error en el proceso, " + error.Message +
                "\n                                                 [ Pulse cualquier tecla para reiniciar ]");
                Console.ReadKey();
                Menu.Lobby();
            }
        }
    }
}
