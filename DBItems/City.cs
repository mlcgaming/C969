using System;

namespace C969.DBItems {
    public class City {
        private int cityId;
        private string city;
        private int countryId;
        private DateTime createDate;
        private string createdBy;
        private DateTime lastUpdate;
        private string lastUpdateBy;

        public int ID {
            get { return cityId; }
        }
        public string Name {
            get { return city; }
            set { city = value; }
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

        public City(int cityId, string city, int countryId, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy) {
            this.cityId = cityId;
            this.city = city;
            this.countryId = countryId;
            this.createDate = createDate;
            this.createdBy = createdBy;
            this.lastUpdate = lastUpdate;
            this.lastUpdateBy = lastUpdateBy;
        }
    }
}
