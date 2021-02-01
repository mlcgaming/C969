using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969.Exceptions {
    public class AppointmentTimesInvalidException : Exception {
        public AppointmentTimesInvalidException() : base("Appointment Times Invalid") {

        }

        public AppointmentTimesInvalidException(string message) : base(message) {

        }
    }
}
