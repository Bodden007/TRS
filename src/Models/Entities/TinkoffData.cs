using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRS.src.Models.Entities
{
    public class TinkoffData
    {
        string Ticker { get; set; }
        decimal CurrentPrice { get; set; }
        int RSI_1 { get; set; }
        int RSI_5 { get; set; }
        int RSI_15 { get; set; }
        int RSI_30 { get; set; }
        int RSI_1H { get; set; }
        int RSI_4H { get; set; }
        int RSI_1D { get; set; }
    }
}
