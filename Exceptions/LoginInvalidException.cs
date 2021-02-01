using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969.Exceptions {
    public class LoginInvalidException : Exception {
        /// <summary>
        /// Provide the error message in current language
        /// </summary>
        /// <param name="message">Message to be displayed / logged</param>
        public LoginInvalidException(string message) : base(message) {

        }
    }
}
