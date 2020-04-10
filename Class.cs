using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Final___Estadisticas_COVID
{
    [Serializable]

    public class Class
    {
        public string Provincia { get; set; }
        public int TotalCasos { get; set; }
        public int Fallecidos { get; set; }
        public int Recuperados { get; set; }
        public int Yesterday { get; set; }
        public int TodayNew { get; set; }
        public double Estimacion { get; set; }


        public Class() {}
        public Class(string provincia = "", int totalCasos = 0, int fallecidos = 0, int recuperados = 0, int yesterday = 0, int todayNew = 0, double estimacion = 0)
        {
            Provincia = provincia;
            TotalCasos = totalCasos;
            Fallecidos = fallecidos;
            Recuperados = recuperados;
            Yesterday = yesterday;
            TodayNew = todayNew;
            Estimacion = estimacion;

        }


        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Provincia", Provincia);
            info.AddValue("TotalCasos", TotalCasos);
            info.AddValue("Fallecidos", Fallecidos);
            info.AddValue("Recuperados", Recuperados);
            info.AddValue("Yesterday", Yesterday);
            info.AddValue("TodayNew", TodayNew);
            info.AddValue("Estimacion", Estimacion);
        }
        public Class(SerializationInfo info, StreamingContext ctxt)
        {
            Provincia = (String)info.GetValue("Provincia", typeof(string));
            TotalCasos = (int)info.GetValue("TotalCasos", typeof(int));
            Fallecidos = (int)info.GetValue("Fallecidos", typeof(int));
            Recuperados = (int)info.GetValue("Recuperados", typeof(int));
            Yesterday = (int)info.GetValue("Yesterday", typeof(int));
            TodayNew = (int)info.GetValue("ToodayNew", typeof(int));
        }
        
        

    }

    
}

     

