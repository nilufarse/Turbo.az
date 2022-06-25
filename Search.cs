using System;
using System.Collections.Generic;
using System.Text;

namespace Turbo.azHomeWork
{
    public class Search
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string SalesType { get; set; }
        public string BanType { get; set; }
        public string Color { get; set; }
        public int Cost { get; set; }
        public string EngineCapacity { get; set; }
        public int YearofIssure { get; set; }
        public void WriteSearchInformation()
        {
            StringBuilder info = new StringBuilder();
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
