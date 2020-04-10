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
    class Stats
    {
        
        public static void VerEstadisticas()
        {
            try
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("\n\n                                      >    ESTADISTICAS ACTUALES    <");
                Console.WriteLine("                                            " + DateTime.Now + "\n\n");

                foreach (Class LT in Menu.TheStats)
                {
                    if (LT.Provincia != "")
                    {
                        if (LT.TodayNew != 0)
                        { 
                            Console.WriteLine("                                 __________________________________________\n" + "                                |                                          |" + "\n                                |         Provincia: {0}          " + "\n                                |         Total de casos: {1} [+ " + LT.TodayNew + "]                " + "\n                                |         Fallecidos: {2}                     " + "\n                                |         Recuperados: {3}                    " + "\n                                |         Casos ayer: {4}                " + "\n                                |         Casos hoy: {5}                " + "\n                                |         Estimacion de casos mañana: {6}                " + "\n                                |__________________________________________|\n\n\n", LT.Provincia, LT.TotalCasos, LT.Fallecidos, LT.Recuperados, LT.Yesterday, LT.TodayNew, LT.Estimacion);
                            
                            
                        }

                        if (LT.TodayNew == 0)
                        {
                            Console.WriteLine("                                 __________________________________________\n" + "                                |                                          |" + "\n                                |         Provincia:{0}          " + "\n                                |         Total de casos:{1}                  " + "\n                                |         Fallecidos:{2}                     " + "\n                                |         Recuperados:{3}                    " + "\n                                |         Total de casos ayer:{4}                " + "\n                                |         Total de casos hoy:{5}                " + "\n                                |__________________________________________|\n\n\n", LT.Provincia, LT.TotalCasos, LT.Fallecidos, LT.Recuperados, LT.Yesterday, LT.TodayNew);

                            
                        }
                    }
                    
                }
                Console.ReadKey();
                Menu.Lobby();
            }
            catch (Exception error)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\n\n\n\n");
                Console.WriteLine("                           Ha ocurrido un error en el proceso, " + error.Message +
                "\n\n                                                                                                     [ Pulse cualquier tecla para reiniciar ]");
                Console.ReadKey();
                Menu.Lobby();
            }

        }
    }
}
