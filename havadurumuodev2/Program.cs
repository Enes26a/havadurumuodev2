using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace havadurumuodev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Hava Durumu - Ödev 2

            Console.WriteLine("Hava durumunu öğrenmek istediğiniz ilin numarasını yazınız.");
            Console.WriteLine("1) Ankara");
            Console.WriteLine("2) İstanbul");
            Console.WriteLine("3) Eskişehir");

            string secim = Console.ReadLine();

            if (secim == "1")
            {
                string apikey = "e4b7070abab1899610fd58316c8d4c53";
                string link = "https://api.openweathermap.org/data/2.5/weather?q=Ankara&lang=tr&units=metric&mode=xml&appid=" + apikey;

                XDocument ankhavadurumu = XDocument.Load(link);

                string ankhavasicaklik = ankhavadurumu.Descendants("temperature").ElementAt(0).Attribute("value").Value;
                string ankdurum = ankhavadurumu.Descendants("weather").ElementAt(0).Attribute("value").Value;
                Console.WriteLine("İl = Ankara");
                Console.WriteLine("Sıcaklık = " + ankhavasicaklik + " Hava Durumu = " + ankdurum);
            }
            if (secim == "2")
            {
                string apikey = "e4b7070abab1899610fd58316c8d4c53";
                string link = "https://api.openweathermap.org/data/2.5/weather?qIstanbul&lang=tr&units=metric&mode=xml&appid=" + apikey;

                XDocument isthavadurumu = XDocument.Load(link);

                string isthavasicaklik = isthavadurumu.Descendants("temperature").ElementAt(0).Attribute("value").Value;
                string istdurum = isthavadurumu.Descendants("weather").ElementAt(0).Attribute("value").Value;
                Console.WriteLine("İl = İstanbul");
                Console.WriteLine("Sıcaklık = " + isthavasicaklik + " Hava Durumu = " + istdurum);
            }
            if (secim == "3")
            {
                string apikey = "e4b7070abab1899610fd58316c8d4c53";
                string link = "https://api.openweathermap.org/data/2.5/weather?q=Eskişehir&lang=tr&units=metric&mode=xml&appid=" + apikey;

                XDocument havadurumu = XDocument.Load(link);

                string havasicaklik = havadurumu.Descendants("temperature").ElementAt(0).Attribute("value").Value;
                string durum = havadurumu.Descendants("weather").ElementAt(0).Attribute("value").Value;
                Console.WriteLine("İl = Eskişehir");
                Console.WriteLine("Sıcaklık = " + havasicaklik + " Hava Durumu = " + durum);
            }

            #endregion
        }
    }
}
