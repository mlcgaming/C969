using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C969.DBItems;

namespace C969 {
    public class SaveableForm : Form {
        protected UserAccount formOwner;
        public event EventHandler FormSaved;

        protected virtual void OnFormSaved() {
            FormSaved?.Invoke(null, EventArgs.Empty);
        }
    }
}
