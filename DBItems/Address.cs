using System;

namespace C969.DBItems{
    public class Address {
        private int addressId;
        private string address;
        private string address2;
        private int cityId;
        private string postalCode;
        private string phone;
        private DateTime createDate;
        private string createdBy;
        private DateTime lastUpdate;
        private string lastUpdateBy;

        public int ID {
            get { return addressId; }
        }
        public string Address1 {
            get { return address; }
            set { address = value; }
        }
        public string Address2 {
            get { return address2; }
            set { address2 = value; }
        }
        public int CityID {
            get { return cityId; }
            set { cityId = value; }
        }
        public string PostalCode {
            get { return postalCode; }
            set { postalCode = value; }
        }
        public string Phone {
            get { return phone; }
            set { phone = value; }
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

        public Address(int addressId, string address, string address2, int cityId, string postalCode, string phone, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy) {
            this.addressId = addressId;
            this.address = address;
            this.address2 = address2;
            this.cityId = cityId;
            this.postalCode = postalCode;
            this.phone = phone;
            this.createDate = createDate;
            this.createdBy = createdBy;
            this.lastUpdate = lastUpdate;
            this.lastUpdateBy = lastUpdateBy;
        }
    }
}
