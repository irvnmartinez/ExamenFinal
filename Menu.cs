using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Examen_Final___Estadisticas_COVID
{
    [Serializable()]

    
    public class Menu
     {
         
        public static List<Class> TheStats = new List<Class>();
        
        public static void Lobby()
        {
            try
            {

                Console.Title = "CEC";
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black; 

                Console.WriteLine("                    ________________________________________________________________");
                Console.WriteLine("                   |                                                                |");
                Console.WriteLine("                   |           Centro de Estadistica del COVID-19 (CEC)             |");
                Console.WriteLine("                   |________________________________________________________________|\n");
                Console.WriteLine("\n\n                          > Para continuar, seleccione la opcion deseada:        \n\n");
                Console.WriteLine("                    ———                                    ———                              ——— ");
                Console.WriteLine("                   | 1 |  Ver estadisticas                | 2 |  Agregar dia               | 3 |  Salir");
                Console.WriteLine("                    ———                                    ———                              ——— ");
                int opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Stats.VerEstadisticas();
                        break;
                    case 2:
                        AddDay.AgregarDia();
                        break;
                    case 3:
                        using (Stream fs = new FileStream(@"C:\Users\irvin martinez\source\repos\Examen Final - Estadisticas COVID\Examen Final - Estadisticas COVID\Serialize.xml", FileMode.Create, FileAccess.Write, FileShare.None))
                        {
                            XmlSerializer serializer2 = new XmlSerializer(typeof(List<Class>));
                            serializer2.Serialize(fs, TheStats);
                        }

                        TheStats = null;

                        XmlSerializer serializer3 = new XmlSerializer(typeof(List<Class>));
                        using (FileStream fs2 = File.OpenRead(@"C:\Users\irvin martinez\source\repos\Examen Final - Estadisticas COVID\Examen Final - Estadisticas COVID\Serialize.xml"))
                        {
                            TheStats = (List<Class>)serializer3.Deserialize(fs2);
                        }                        
                        Environment.Exit(35);
                        break;
                }

                Console.ReadKey();
                
            }
            catch(Exception error)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\n\n\n\n\n");
                Console.WriteLine("                         Ha ocurrido un error en el proceso, " + error.Message +
                "                                              [ Pulse cualquier tecla para reiniciar ]");
                Console.ReadKey();
                Lobby();
                
            }
        }
        

        

       


        
    }
}
