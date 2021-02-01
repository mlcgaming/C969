using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969 {
    public class AppointmentListing {
        private int id;
        private string userName;
        private string customerName;
        private string title;
        private string description;
        private string type;
        private DateTime startDate;
        private DateTime endDate;

        public int ID {
            get { return id; }
        }
        public string UserName {
            get { return userName; }
        }
        public string CustomerName {
            get { return customerName; }
        }
        public string Title {
            get { return title; }
        }
        public string Description {
            get { return description; }
        }
        public string Type {
            get { return type; }
        }
        public DateTime StartDate {
            get { return startDate; }
        }
        public DateTime EndDate {
            get { return endDate; }
        }

        public AppointmentListing(int id, string userName, string customerName, string title, string description, string type, DateTime startDate, DateTime endDate) {
            this.id = id;
            this.userName = userName;
            this.customerName = customerName;
            this.title = title;
            this.description = description;
            this.type = type;
            this.startDate = startDate;
            this.endDate = endDate;
        }
    }
}
