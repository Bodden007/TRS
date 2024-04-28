using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRS.src.Models.Interfaces;

namespace TRS.src.Models.Entities
{
    public class InvestmentPortfolio : IInvestmentPportfolio
    {
        public string UserAccount { get; set; } = string.Empty;
        public decimal Balance { get; set; }
        public ICollection<Stock> Share { get; set; }
    }
}
