using System;
using System.Windows.Forms;


namespace C969_Software_2
{
    class AppointmentException : ApplicationException
    {
        public void BusinessHours()
        {
            MessageBox.Show("Exception occured. Please reschedule for normal business hours.");

        }

        public void AppOverlap()
        {
            MessageBox.Show("Exception occured. This appointment time has already been taken.");
        }

        public AppointmentException(string message) : base(message)
        {
        }

        public AppointmentException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public AppointmentException()
        {
        }
    }
}
