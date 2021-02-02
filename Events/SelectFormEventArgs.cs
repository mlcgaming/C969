using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969.Events {
    public class SelectFormEventArgs : EventArgs {
        private SaveableForm childForm;

        public SaveableForm ChildForm {
            get { return childForm; }
        }

        public SelectFormEventArgs(SaveableForm childForm = null) {
            this.childForm = childForm;
        }
    }
}
