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
    class Program
    {
        static void Main(string[] args)
        {
            Class LaAltragracia = new Class("La Altagracia", 44, 0, 1, 0, 0, 0);
            Menu.TheStats.Add(LaAltragracia);

            Class ElSeibo = new Class("El Seibo", 4, 1, 0, 0, 0, 0);
            Menu.TheStats.Add(ElSeibo);

            Class LaRomana = new Class("La Romana", 35, 1, 1, 0, 0, 0);
            Menu.TheStats.Add(LaRomana);

            Class SanPM = new Class("San Pedro de Macoris", 26, 4, 2, 0, 0, 0);
            Menu.TheStats.Add(SanPM);

            Class HatoMayor = new Class("Hato Mayor", 5, 0, 0, 0, 0, 0);
            Menu.TheStats.Add(HatoMayor);

            Class Samana = new Class("Samana", 15, 1, 1, 0, 0, 0);
            Menu.TheStats.Add(Samana);

            Class MontePlata = new Class("Monte Plata", 4, 1, 0, 0, 0, 0);
            Menu.TheStats.Add(MontePlata);

            Class SantoDomingo = new Class("Santo Domingo", 348, 16, 3, 0, 0, 0);
            Menu.TheStats.Add(SantoDomingo);

            Class DistritoNacional = new Class("Distrito Nacional", 762, 17, 30, 0, 0, 0);
            Menu.TheStats.Add(DistritoNacional);

            Class MariaTrinidad = new Class("Maria Trinidad Sanchez", 20, 1, 0, 0, 0, 0);
            Menu.TheStats.Add(MariaTrinidad);

            Class Duarte = new Class("Duarte", 154, 38, 4, 0, 0, 0);
            Menu.TheStats.Add(Duarte);

            Class SanchezRamirez = new Class("Sanchez Ramirez", 34, 3, 0, 0, 0, 0);
            Menu.TheStats.Add(SanchezRamirez);

            Class SanCristobal = new Class("San Cristobal", 40, 1, 1, 0, 0, 0);
            Menu.TheStats.Add(SanCristobal);

            Class Espaillat = new Class("Espaillat", 55, 1, 0, 0, 0, 0);
            Menu.TheStats.Add(Espaillat);

            Class HermanasMirabal = new Class("Hermanas Mirabal", 28, 2, 2, 0, 0, 0);
            Menu.TheStats.Add(HermanasMirabal);

            Class MonsenorNouel = new Class("Monseñor Nouel", 45, 3, 0, 0, 0, 0);
            Menu.TheStats.Add(MonsenorNouel);

            Class Ocoa = new Class("San Jose de Ocoa", 0, 0, 0, 0, 0, 0);
            Menu.TheStats.Add(Ocoa);

            Class Peravia = new Class("Peravia", 12, 1, 0, 0, 0, 0);
            Menu.TheStats.Add(Peravia);

            Class LaVega = new Class("La Vega", 109, 6, 1, 0, 0, 0);
            Menu.TheStats.Add(LaVega);

            Class Azua = new Class("Azua", 9, 0, 0, 0, 0, 0);
            Menu.TheStats.Add(Azua);

            Class PuertoPlata = new Class("Puerto Plata", 42, 0, 1, 0, 0, 0);
            Menu.TheStats.Add(PuertoPlata);

            Class Santiago = new Class("Santiago", 274, 8, 3, 0, 0, 0);
            Menu.TheStats.Add(Santiago);

            Class Valverde = new Class("Valverde", 11, 0, 0, 0, 0, 0);
            Menu.TheStats.Add(Valverde);

            Class MonteCristi = new Class("Monte Cristi", 3, 0, 0, 0, 0, 0);
            Menu.TheStats.Add(MonteCristi);

            Class SantiagoRodriguez = new Class("Santiago Rodriguez", 5, 0, 0, 0, 0, 0);
            Menu.TheStats.Add(SantiagoRodriguez);

            Class SanJuan = new Class("San Juan", 13, 3,0, 0, 0, 0);
            Menu.TheStats.Add(SanJuan);

            Class Dajabon = new Class("Dajabon", 1, 0, 0, 0, 0, 0);
            Menu.TheStats.Add(Dajabon);

            Class EliasPina = new Class("Eliaz Piña", 0, 0, 0, 0, 0, 0);
            Menu.TheStats.Add(EliasPina);

            Class Bahoruco = new Class("Bahoruco", 1, 0, 0, 0, 0, 0);
            Menu.TheStats.Add(Bahoruco);

            Class Independencia = new Class("Independencia", 1, 0, 0, 0, 0, 0);
            Menu.TheStats.Add(Independencia);

            Class Barahona = new Class("Barahona", 12, 0, 0, 0, 0, 0);
            Menu.TheStats.Add(Barahona);

            Class Pedernales = new Class("Pedernales", 44, 0, 1, 0, 0, 0);
            Menu.TheStats.Add(Pedernales);


            Menu.Lobby();
        }
    }
}
