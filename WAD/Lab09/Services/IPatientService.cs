using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab09.Models;

namespace Lab09.Services
{
    public interface IPatientService
    {
        List<Patient> GetPatients();
        Patient GetPatient(int id);
        bool AddPatient(Patient patient);
        bool UpdatePatient(Patient patient);
        bool RemovePatient(int id);
    }
}
