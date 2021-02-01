using System;

namespace C969.DBItems {
    public class Customer {
        private int customerId;
        private string customerName;
        private int addressId;
        private bool active;
        private DateTime createDate;
        private string createdBy;
        private DateTime lastUpdate;
        private string lastUpdateBy;

        public int CustomerID {
            get { return customerId; }
        }
        public string Name {
            get { return customerName; }
            set { customerName = value; }
        }
        public int AddressID {
            get { return addressId; }
            set { addressId = value; }
        }
        public bool IsActive {
            get { return active; }
            set { active = value; }
        }
        public DateTime DateCreated {
            get { return createDate; }
        }
        public string CreatedBy {
            get { return createdBy; }
        }
        public DateTime DateLastUpdated {
            get { return lastUpdate; }
            set { lastUpdate = value; }
        }
        public string LastUpdatedBy {
            get { return lastUpdateBy; }
            set { lastUpdateBy = value; }
        }

        public Customer(int customerId, string customerName, int addressId, bool active, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy) {
            this.customerId = customerId;
            this.customerName = customerName;
            this.addressId = addressId;
            this.active = active;
            this.createDate = createDate;
            this.createdBy = createdBy;
            this.lastUpdate = lastUpdate;
            this.lastUpdateBy = lastUpdateBy;
        }
    }
}
