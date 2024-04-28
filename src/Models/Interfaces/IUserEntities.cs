using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRS.src.Models.Interfaces
{
    
    internal interface IUserEntities
    {
        /// <summary>
        /// пользователя
        /// </summary>
        int IdUser { get; set; }

        /// <summary>
        /// Login пользователя
        /// </summary>
        string Login { get; set; }

        /// <summary>
        /// Пароль пользователя
        /// </summary>
        string Passport {  get; set; }

        /// <summary>
        /// Токен пользователя
        /// </summary>
        string Token {  get; set; }

    }
}
