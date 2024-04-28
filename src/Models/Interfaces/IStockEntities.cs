using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRS.src.Models.Interfaces
{
    internal interface IStockEntities
    {
        /// <summary>
        /// Figi
        /// </summary>
        string Figi { get; set; }

        /// <summary>
        /// Ticker
        /// </summary>
        string Ticker { get; set; }

        /// <summary>
        /// UID
        /// </summary>
        string Uid {  get; set; }

        /// <summary>
        /// Name
        /// </summary>
        string Name {  get; set; }

        /// <summary>
        /// Валюта
        /// </summary>
        string Currency {  get; set; }

        /// <summary>
        /// количество в лоте
        /// </summary>
        int Lot {  get; set; }


    }
}
