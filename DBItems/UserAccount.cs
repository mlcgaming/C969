using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969.DBItems {
    public class UserAccount {
        private int userId;
        private string userName;
        private string password;
        private bool active;
        private DateTime createDate;
        private string createBy;
        private DateTime lastUpdate;
        private string lastUpdateBy;

        public int ID {
            get { return userId; }
        }
        public string Username {
            get { return userName; }
        }
        public string Password {
            get { return password; }
        }
        public bool IsActive {
            get { return active; }
        }
        public DateTime DateCreated {
            get { return createDate; }
        }
        public string CreatedBy {
            get { return createBy; }
        }
        public DateTime LastUpdated {
            get { return lastUpdate; }
        }
        public string LastUpdatedBy {
            get { return lastUpdateBy; }
        }

        public UserAccount(int userId, string userName, string password, bool active, DateTime createDate, string createBy) {
            this.userId = userId;
            this.userName = userName;
            this.password = password;
            this.active = active;
            this.createDate = createDate;
            this.createBy = createBy;

            lastUpdate = createDate;
            lastUpdateBy = createBy;
        }

        public UserAccount(int userId, string userName, string password, bool active, DateTime createDate, string createBy, DateTime lastUpdate, string lastUpdateBy) {
            this.userId = userId;
            this.userName = userName;
            this.password = password;
            this.active = active;
            this.createDate = createDate;
            this.createBy = createBy;

            this.lastUpdate = lastUpdate;
            this.lastUpdateBy = lastUpdateBy;
        }
    }
}
