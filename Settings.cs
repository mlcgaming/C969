using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Linq;

namespace C969 {
    public static class Settings {
        private static string settingsFilename = "settings.xml";

        public const int ID_LABEL_LOGIN_FORM_TITLE = 0;
        public const int ID_LABEL_LOGIN_FORM_USERNAME = 1;
        public const int ID_LABEL_LOGIN_FORM_PASSWORD = 2;
        public const int ID_LABEL_LOGIN_FORM_LOGIN_BUTTON = 3;
        public const int ID_LABEL_LOGIN_FORM_CANCEL_BUTTON = 4;
        public const int ID_LABEL_LOGIN_FORM_EXCEPTION_MYSQL = 5;
        public const int ID_LABEL_LOGIN_FORM_EXCEPTION_INVALID_LOGIN = 6;

        private static string databaseServerUrl;
        private static int databasePort;
        private static string databaseSchema;
        private static string databaseUsername;
        private static string databasePassword;
        private static string databaseConnectionUrl;

        private static Dictionary<int, string> japaneseLabels;
        private static Dictionary<int, string> englishLabels;
        private static Dictionary<int, string> currentLabels;

        private static readonly List<string> appointmentTypes = new List<string>() { "Scrum", "Presentation", "Evalutation", "Meeting" };

        public static string DBServer {
            get { return databaseServerUrl; }
        }
        public static int DBPort {
            get { return databasePort; }
        }
        public static string DBSchema {
            get { return databaseSchema; }
        }
        public static string DBUser {
            get { return databaseUsername; }
        }
        public static string DBConnectionString {
            get { return databaseConnectionUrl; }
        }

        public static Dictionary<int, string> CurrentLabels {
            get { return currentLabels; }
        }

        public static List<string> AppointmentTypes {
            get { return appointmentTypes; }
        }

        public static void Initialize() {
            if(File.Exists(settingsFilename)) {
                LoadFromFile();
            }
            else {
                LoadFromNull();
            }

            databaseConnectionUrl = $"SERVER={DBServer}; PORT={DBPort}; DATABASE={DBSchema}; UID={DBUser}; PASSWORD={databasePassword};";

            LoadLanguageDictionaries();
        }

        private static void LoadFromFile() {
            XDocument settings = XDocument.Load(settingsFilename);
            XElement connectionElement = settings.Element("Settings").Element("Connection");

            databaseServerUrl = connectionElement.Element("Server").Value;
            databasePort = int.Parse(connectionElement.Element("Port").Value);
            databaseSchema = connectionElement.Element("Schema").Value;
            databaseUsername = connectionElement.Element("User").Value;
            databasePassword = connectionElement.Element("Password").Value;
        }
        private static void LoadFromNull() {
            databaseServerUrl = "wgudb.ucertify.com";
            databasePort = 3306;
            databaseSchema = "U07v8q";
            databaseUsername = "U07v8q";
            databasePassword = "53689143851";

            XElement settingsElement = new XElement("Settings");
            XElement connectionElement = new XElement("Connection");

            XElement dbServerElement = new XElement("Server", databaseServerUrl);
            XElement dbPortElement = new XElement("Port", databasePort);
            XElement dbSchemaElement = new XElement("Schema", databaseSchema);
            XElement dbUserElement = new XElement("User", databaseUsername);
            XElement dbPasswordElement = new XElement("Password", databasePassword);

            connectionElement.Add(dbServerElement);
            connectionElement.Add(dbPortElement);
            connectionElement.Add(dbSchemaElement);
            connectionElement.Add(dbUserElement);
            connectionElement.Add(dbPasswordElement);

            settingsElement.Add(connectionElement);

            XDocument settingsFile = new XDocument();

            settingsFile.Add(settingsElement);
            settingsFile.Save(settingsFilename);
        }

        private static void LoadLanguageDictionaries() {
            CultureInfo currentCulture = CultureInfo.CurrentCulture;

            englishLabels = new Dictionary<int, string>()
            {
                {ID_LABEL_LOGIN_FORM_TITLE, "Login" },
                {ID_LABEL_LOGIN_FORM_USERNAME, "Username:" },
                {ID_LABEL_LOGIN_FORM_PASSWORD, "Password:" },
                {ID_LABEL_LOGIN_FORM_LOGIN_BUTTON, "Login" },
                {ID_LABEL_LOGIN_FORM_CANCEL_BUTTON, "Cancel" },
                {ID_LABEL_LOGIN_FORM_EXCEPTION_MYSQL, "Could not connect to Database" },
                {ID_LABEL_LOGIN_FORM_EXCEPTION_INVALID_LOGIN, "Username and/or Password not accepted" }
            };
            japaneseLabels = new Dictionary<int, string>()
            {
                {ID_LABEL_LOGIN_FORM_TITLE, "ログインする" },
                {ID_LABEL_LOGIN_FORM_USERNAME, "ユーザー名:" },
                {ID_LABEL_LOGIN_FORM_PASSWORD, "パスワード:" },
                {ID_LABEL_LOGIN_FORM_LOGIN_BUTTON, "ログインする" },
                {ID_LABEL_LOGIN_FORM_CANCEL_BUTTON, "閉じる" },
                {ID_LABEL_LOGIN_FORM_EXCEPTION_MYSQL, "データベースに接続できません" },
                {ID_LABEL_LOGIN_FORM_EXCEPTION_INVALID_LOGIN, "ユーザーネームまたはパスワードが違います" }
            };

            if(currentCulture.TwoLetterISOLanguageName == "ja") {
                currentLabels = new Dictionary<int, string>(japaneseLabels);
            }
            else {
                currentLabels = new Dictionary<int, string>(englishLabels);
            }
        }
    }
}
