using System;
using System.Collections.Generic;
using System.Text;

namespace Turbo.azHomeWork
{
    public class SignIn
    {
        public void Girish()
        { 
            Console.WriteLine("1.Telefon nomresi ile giris / 2.Biznes hesaba giris");
            string response = Console.ReadLine();
            if (response == "1")
            {
                AccountMeneger accountMeneger = new AccountMeneger();
                accountMeneger.Shexsi();
            }
            else if (response == "2")
            {
                AccountMeneger accountMeneger = new AccountMeneger();
                accountMeneger.Business();
            }
        }
    }
}
