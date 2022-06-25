using System;
using System.Collections.Generic;
using System.Text;

namespace Turbo.azHomeWork
{
   public class Account
    {
        public string Phone { get; set; }
        public string Gmail { get; set; }
        public string Password { get; set; }
        public void WriteAccountInformation()
        {
            StringBuilder info = new StringBuilder();
            info.Append("Sayta giris edenin telefon nomresi: " + this.Phone + "\n");
            info.Append("Sayta giris edenin maili: " + this.Gmail + "\n");
            info.Append("Sayta giris edenin parolu: " + this.Password + "\n");
            Console.WriteLine(info);
        }
   }
}

