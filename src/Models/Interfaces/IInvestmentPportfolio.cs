using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRS.src.Models.Interfaces
{
    internal interface IInvestmentPportfolio
    {
        /// <summary>
        /// Счет аккуанта
        /// </summary>
        string UserAccount { get; set; }

        /// <summary>
        /// Баланс аккуанта
        /// </summary>
        decimal Balance { get; set; }

    }
}
