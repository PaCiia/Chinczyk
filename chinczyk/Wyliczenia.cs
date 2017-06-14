using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace chinczyk
{
    public class Wyliczenia
    {
        public enum Kierunek { LEWO, PRAWO, GORA, DOL };
        public enum Gracz { NIEBIESKI, ZIELONY, ZOLTY, CZERWONY };

        public class Kolory
        {
            public static Color kolorNiebieski = Color.FromArgb(0x00, 0x00, 0xFF);
            public static Color kolorZielony = Color.FromArgb(0x00, 0x80, 0x00);
            public static Color kolorZolty = Color.FromArgb(0xFF, 0xFF, 0x00);
            public static Color kolorCzerwony = Color.FromArgb(0xFF, 0x00, 0x00);
        }
    }
}