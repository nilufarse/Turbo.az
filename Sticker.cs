using System;
using System.Collections.Generic;
using System.Text;

namespace Turbo.azHomeWork
{
    public class Sticker
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string SalesType { get; set; }
        public string BanType { get; set; }
        public string Color { get; set; }
        public int Cost { get; set; }
        public string EngineCapacity { get; set; }
        public int YearofIssure { get; set; }
        public void WriteInformation()
        {
            List<string> Sticker = new List<string>();

            StringBuilder info = new StringBuilder();
            info.Append("Elani yerlesdirenin adi: " + this.Name + "\n");
            info.Append("Elani yerlesdirenin Soyadi: " + this.Surname + "\n");
            info.Append("Elani yerlesdirenin nomresi: " + this.Phone + "\n");
            info.Append("Elani yerlesdirenin adresi: " + this.Address + "\n");
            info.Append("Masinin markasi: " + this.Marka + "\n");
            info.Append("Masinin modeli: " + this.Model + "\n");
            info.Append("Masinin satis novu: " + this.SalesType + "\n");
            info.Append("Masinin ban novu: " + this.BanType + "\n");
            info.Append("Masinin rengini: " + this.Color + "\n");
            info.Append("Masinin qiymeti: " + this.Cost + "\n");
            info.Append("Masinin yanacaq tutumu: " + this.EngineCapacity + "\n");
            info.Append("Masinin buraxilis ili: " + this.YearofIssure + "\n");
            Console.WriteLine(info);

           
        }
    }
}

