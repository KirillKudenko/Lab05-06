using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public string ourTVName;
        public string ourTVModel;
        public string ourReleaseData;
        public int ourTVDiagonal;
        public int ourTVPrice;
        public string ourCountry;
        public bool WiFi;
        public static void TV() {
            Console.WriteLine("Введіть назву телевізора: ");
            string TVName = Console.ReadLine();
            Console.WriteLine("Введiть модель телевізора: ");
            string TVModel = Console.ReadLine();
            Console.WriteLine("Введiть дату випуску: ");
            string ReleaseData = Console.ReadLine();
            Console.WriteLine("Введiть діагональ: ");
            string TVDiagonal = Console.ReadLine();
            Console.WriteLine("Введiть ціну телевізора: ");
            string TVPrice = Console.ReadLine();
            Console.WriteLine("Введiть країну виготовлення: ");
            string Country = Console.ReadLine();
            Console.Write("Мае підтримку WiFi?(t - так , n - ні) ");
            ConsoleKeyInfo keyWiFi = Console.ReadKey();

            Class1 OurTV = new Class1
            {
                ourTVName = TVName,
                ourTVModel = TVModel,
                ourReleaseData = ReleaseData,
                ourTVDiagonal = int.Parse(TVDiagonal),
                ourTVPrice = int.Parse(TVPrice),
                ourCountry = Country,
                WiFi = keyWiFi.Key == ConsoleKey.T,
            };

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Данi про об`ект: ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Назва телевізора: " + OurTV.ourTVName);
            Console.WriteLine("Модель телевізора: " + OurTV.ourTVModel);
            Console.WriteLine("Дата випуску: " + OurTV.ourReleaseData);
            Console.WriteLine("Діагональ: " + OurTV.ourTVDiagonal);
            Console.WriteLine("Ціна телевізора: " + OurTV.ourTVPrice + "грн.");
            Console.WriteLine("Країна виготовлення: " + OurTV.ourCountry);
            Console.WriteLine(OurTV.WiFi ? "Цей телевізор має підтримку WiFi" : "Цей телевізор не має падтримки WiFi");
            Console.ReadKey();

        }
    }
}
