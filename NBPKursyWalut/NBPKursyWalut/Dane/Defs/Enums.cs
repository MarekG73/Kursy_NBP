using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBPKursyWalut.Data.Defs
{
    public enum DownloadType { NONE = 0, CURRENCY_TABLE = 1, CURRENCY_SINGLE = 2 };
    
    public struct TableABColumns 
    {
        public static string Currency = "Nazwa waluty";
        public static string Code = "Kod waluty";
        public static string Mid = "Kurs średni";
    }
    public struct TableCColumns
    {
        public static string Currency = "Nazwa waluty";
        public static string Code = "Kod waluty";
        public static string Bid = "Kurs sprzedaży";
        public static string Ask = "Kurs Kupna";
    }


}