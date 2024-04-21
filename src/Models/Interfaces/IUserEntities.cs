using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRS.src.Models.Interfaces
{
    
    internal interface IUserEntities
    {
        decimal Money { get; set; }
        string StocksTicker { get; set; }
        int QuantityStocks { get; set; }
    }
}
