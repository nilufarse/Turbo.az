using System;
using System.Collections.Generic;
using System.Text;

namespace Turbo.azHomeWork
{
    public class StickerMeneger
    {
        public void ManageSticker()
        {
            Sticker sticker = new Sticker();
            Console.WriteLine("Adinizi elave edin :");
            sticker.Name = Console.ReadLine();
            Console.WriteLine("Soyadinizi elave edin :");
            sticker.Surname = Console.ReadLine();
            Console.WriteLine("Telefonuzu elave edin :");
            sticker.Phone = Console.ReadLine();
            Console.WriteLine("Adresinizi elave edin :");
            sticker.Address = Console.ReadLine();
            Console.WriteLine("Masinin markasini elave edin :");
            sticker.Marka = Console.ReadLine();
            Console.WriteLine("Masinin modelini elave edin :");
            sticker.Model = Console.ReadLine();
            Console.WriteLine("Satis novunu elave edin :");
            sticker.SalesType = Console.ReadLine();
            Console.WriteLine("Masinin ban novunu elave edin :");
            sticker.BanType = Console.ReadLine();
            Console.WriteLine("Masinin rengini elave edin :");
            sticker.Color = Console.ReadLine();
            Console.WriteLine("Masinin qiymetini elave edin :");
            sticker.Cost = int.Parse(Console.ReadLine());
            Console.WriteLine("Yanacaq tutumunu elave edin :");
            sticker.EngineCapacity = Console.ReadLine();
            Console.WriteLine("Masinin buraxilis ilini elave edin :");
            sticker.YearofIssure = int.Parse(Console.ReadLine());
            sticker.WriteInformation();
        }

        internal static void AddSticker()
        {
            throw new NotImplementedException();
        }
    }
}

    