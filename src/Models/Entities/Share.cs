using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRS.src.Models.Entities
{
    public class Share
    {
        public int Id { get; set; }
        /// <summary>
        /// Title
        /// </summary>
        public string Ticker { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        /// <summary>
        /// Кол-во на руках
        /// </summary>
        public uint QuantityShare { get; set; }
    }
}
