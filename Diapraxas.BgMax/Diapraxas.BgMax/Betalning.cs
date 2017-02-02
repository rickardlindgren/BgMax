using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diapraxas.BgMax.Betalposter;

namespace Diapraxas.BgMax
{
    public class Betalning
    {
        public TK20Betalpost Tk20Betalpost { get; private set; }
        public TK26Namnpost Tk26Namnpost { get; private set; }
        public TK27Adresspost1 Tk27Adresspost1 { get; private set; }
        public TK28Adresspost2 Tk28Adresspost2 { get; private set; }
        public TK29Organisationsnummerpost Tk29Organisationsnummerpost { get; private set; }
        public List<IBetalpost> Poster { get; private set; }

        public Betalning(List<string> avdelning)
        {
            foreach (String textrad in avdelning)
            {
                string posttyp = textrad.Substring(0, 2);

                switch (posttyp)
                {
                    case "20":
                        Tk20Betalpost = new TK20Betalpost(textrad);
                        break;
                    case "26":
                        Tk26Namnpost = new TK26Namnpost(textrad);
                        break;
                    case "27":
                        Tk27Adresspost1 = new TK27Adresspost1(textrad);
                        break;
                    case "28":
                        Tk28Adresspost2 = new TK28Adresspost2(textrad);
                        break;
                    case "29":
                        Tk29Organisationsnummerpost = new TK29Organisationsnummerpost(textrad);
                        break;
                    default:
                        // "En applikation som läser filer i BgMaxlayouten bör konstrueras
                        //  så att den ignorerar posttyper den inte känner igen."
                        break;
                }
            }
        }
    }
}
