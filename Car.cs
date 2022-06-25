using System;
using System.Linq;
using System.Text;

namespace Turbo.azHomeWork
{
    public class Car : Vehicle
    {
        public string CarId { get; set; }

        public void WriteInformation()
        {
            StringBuilder info = new StringBuilder();
            info.Append("Masinin kodu: " + this.Id + "\n");
            info.Append("Masinin adini: " + this.Name + "\n");
            info.Append("Masinin novu: " + this.Type + "\n");
            info.Append("Masinin marka kodu: " + this.MarkaName + "\n");
            info.Append("Masinin model kodu: " + this.ModelName + "\n");
            info.Append("Masinin qiymetini: " + this.Price + "\n");
            info.Append("Masinin rengini: " + this.Color + "\n");
            Console.WriteLine(info);
        }
    }
}