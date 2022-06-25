using System;
using System.Collections.Generic;
using System.Text;

namespace Turbo.azHomeWork
{
    public class AccountMeneger
    {
        public void Shexsi()
        {
            Account account1 = new Account();
            Console.WriteLine("Telefon nomrenizi qeyd edin :");
            account1.Phone = Console.ReadLine();
        }
        public void Business()
        {
            Account account2 = new Account();
            Console.WriteLine("Mailinizi qeyd edin :");
            account2.Gmail = Console.ReadLine();
            Console.WriteLine("Parolunuzu qeyd edin :");
            account2.Password = Console.ReadLine();
        }
    }
}
