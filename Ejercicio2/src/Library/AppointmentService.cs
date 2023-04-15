using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        public static string CreateAppointment(Paciente paciente, DateTime date, string appoinmentPlace, Doctor doctor)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

           

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}


