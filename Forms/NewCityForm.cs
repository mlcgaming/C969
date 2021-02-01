using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C969.DBItems;

namespace C969 {
    public partial class NewCityForm : Form {
        private UserAccount formOwner;

        public event EventHandler FormSaved;

        public NewCityForm(UserAccount user) {
            InitializeComponent();

            formOwner = user;
        }

        private void NewCityForm_Load(object sender, EventArgs e) {

        }

        #region Form Functions
        private void ValidateForm() {

        }
        #endregion

        #region Event Functions
        private void OnFormSaved() {
            FormSaved?.Invoke(null, EventArgs.Empty);
            Close();
        }

        private void OnNewCountryButtonClicked(object sender, EventArgs e) {

        }
        private void OnSaveButtonClicked(object sender, EventArgs e) {

        }
        private void OnCancelButtonClicked(object sender, EventArgs e) {
            Close();
        }
        #endregion
    }
}
