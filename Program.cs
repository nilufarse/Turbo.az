using System;

namespace Turbo.azHomeWork
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("===========");
            Console.Write("Turbo.Az : " + "\n");
            Console.WriteLine("===========");
            Console.Write("Hesaba giris : " + "\n");
            AccountMeneger accountMeneger = new AccountMeneger();
            Console.WriteLine("1.Shexsi hesab / 2.Biznes hesab ");
            string response = Console.ReadLine();
            if (response == "1")
            {
                Console.WriteLine("Shexsi hesab");
                AccountMeneger accountMeneger1 = new AccountMeneger();
                accountMeneger1.Shexsi();
            }
            else if (response == "2")
            {
                Console.WriteLine("Biznes hesab");
                AccountMeneger accountMeneger1 = new AccountMeneger();
                accountMeneger1.Business();
            }
                Console.WriteLine("1.Elan yerlesdirmek / 2.Elana baxmaq");
                string response1 = Console.ReadLine();
                if (response1 == "1")
                {
                    Console.WriteLine("Elan yerlesdirmek");
                    StickerMeneger stickerMeneger = new StickerMeneger();
                    stickerMeneger.ManageSticker();
                }
                else if (response1 == "2")
                {
                    Console.WriteLine("Elana baxmaq");
                    SearchMeneger searchMeneger = new SearchMeneger();
                    searchMeneger.SearchInfo();
                }
        }
    }
}



        
   

