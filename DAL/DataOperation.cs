using System;
using System.Collections.Generic;
using System.Text;

namespace Turbo.azHomeWork.DAL
{
    class DataOperation
    {
        public static List<Sticker> Stickers { get; }

        static DataOperation()
        {

            Stickers = new List<Sticker>();
            
        }
    }
}
