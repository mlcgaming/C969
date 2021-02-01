using System;

namespace C969.DBItems {
    public class Country {
        private int countryId;
        private string country;
        private DateTime createDate;
        private string createdBy;
        private DateTime lastUpdate;
        private string lastUpdateBy;

        public int ID {
            get { return countryId; }
        }
        public string Name {
            get { return country; }
            set { country = value; }
        }
        public int CountryID {
            get { return countryId; }
            set { countryId = value; }
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

        public Country(int countryId, string country, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy) {
            this.countryId = countryId;
            this.country = country;
            this.createDate = createDate;
            this.createdBy = createdBy;
            this.lastUpdate = lastUpdate;
            this.lastUpdateBy = lastUpdateBy;
        }
    }
}
