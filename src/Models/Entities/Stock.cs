using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRS.src.Models.Interfaces;

namespace TRS.src.Models.Entities
{
    /// <summary>
    /// Реализуем интерфейс IStockEntities
    /// </summary>
    public class Stock : IStockEntities
    {
        public int Id { get; set; }
        public string Ticker { get; set; }
        public string Figi { get; set; }
        public string Uid { get; set; }
        public string Name { get; set; }
        public string Currency { get; set; }
        public int Lot { get; set; }
    }
}
