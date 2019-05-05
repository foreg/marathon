using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marathon
{
    public class Config
    {
        public static string EventName => "Marathon Skills 2019";
        public static string EventPlace => "Москва, Россия";
        public static DateTime EventDateTime => new DateTime(2019, 10, 21, 6, 0, 0); // todo переписать нормально, чтобы не создавать класс каждый раз при обращении
    }
}
