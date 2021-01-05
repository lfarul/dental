using Dental.Models;
using System.Collections.Generic;


namespace Dental.Repositories
{
    public interface IAppointmentRepository
    {
        Appointment GetAppointment(int AppointmentID);
        IEnumerable<Appointment> GetAllAppointments();
        Appointment Add(Appointment appointment);
        Appointment Update(Appointment appointmentUpdate);
        Appointment Delete(int Id);
    }
}
