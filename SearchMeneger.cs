using System;
using System.Collections.Generic;
using System.Text;

namespace Turbo.azHomeWork
{
   public  class SearchMeneger
    {
        public void SearchInfo()
        {
            Search search = new Search();
            Console.WriteLine("Masinin markasini daxil edin :");
            search.Marka = Console.ReadLine();
            Console.WriteLine("Masinin modelini elave edin :");
            search.Model = Console.ReadLine();
            Console.WriteLine("Satis novunu elave edin :");
            search.SalesType = Console.ReadLine();
            Console.WriteLine("Masinin ban novunu elave edin :");
            search.BanType = Console.ReadLine();
            Console.WriteLine("Masinin rengini elave edin :");
            search.Color = Console.ReadLine();
            Console.WriteLine("Masinin qiymetini elave edin :");
            search.Cost = int.Parse(Console.ReadLine());
            Console.WriteLine("Yanacaq tutumunu elave edin :");
            search.EngineCapacity = Console.ReadLine();
            Console.WriteLine("Masinin buraxilis ilini elave edin :");
            search.YearofIssure = int.Parse(Console.ReadLine());
            search.WriteSearchInformation();
        }

        internal static void ShowSearch()
        {
            throw new NotImplementedException();
        }
    }
}
