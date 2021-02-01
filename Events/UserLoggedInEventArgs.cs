using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C969.DBItems;

namespace C969.Events {
    public class UserLoggedInEventArgs : EventArgs {
        private UserAccount user;

        public UserAccount User {
            get { return user; }
        }

        public UserLoggedInEventArgs(UserAccount user) {
            this.user = user;
        }
    }
}
