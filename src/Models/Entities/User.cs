using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRS.src.Models.Interfaces;

namespace TRS.src.Models.Entities
{
    /// <summary>
    /// Реализуем интерфейс IUserEntities
    /// </summary>
    public class User : IUserEntities
    {
        public int IdUser { get; set; }
        public string Login { get; set; }
        public string Passport { get; set; }
        public string Token { get; set; } = string.Empty;
    }
}
