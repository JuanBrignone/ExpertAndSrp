using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Paciente persona1 = new Paciente("Juan","54257051","50","099237485");
            Doctor doctor1 = new Doctor("Jose","Cardiologo");

            Paciente persona2 = new Paciente("Miguel","53146041","23","097513523");
            Doctor doctor2 = new Doctor("Andres","Gastroenterologo");


            string appointmentResult = AppointmentService.CreateAppointment(persona2, DateTime.Now, "Wall Street", doctor1);
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment(persona2, DateTime.Now, "Queen Street", doctor2);
            Console.WriteLine(appointmentResult2);

        }
    }
}
