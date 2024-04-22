using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRS.src.Models.Entities
{
    public class Portfolio
    {
        /// <summary>
        /// Номер счёта
        /// </summary>
        public int UserAccount { get; set; }
        public decimal Balance { get; set; }
        public User User { get; set; }
        public ICollection<Share> Share { get; set; }
    }
}
