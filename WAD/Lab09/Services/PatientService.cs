using Lab09.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab09.DataConnect;

namespace Lab09.Services
{
    public class PatientService : IPatientService
    {
        public PatientContext service;
        public PatientService(PatientContext service)
        {
            this.service = service;
        }
        public bool AddPatient(Patient patient)
        {
            service.Patient.Add(patient);
            service.SaveChanges();
            return true;
        }

        public Patient GetPatient(int id)
        {
            Patient model = service.Patient.Find(id);
            return model;
        }

        public List<Patient> GetPatients()
        {
            return service.Patient.ToList();
        }

        public bool RemovePatient(int id)
        {
            Patient patient = service.Patient.SingleOrDefault(p => p.Id.Equals(id));
            if (patient != null)
            {
                service.Patient.Remove(patient);
                service.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdatePatient(Patient patient)
        {
            Patient pt = service.Patient.SingleOrDefault(p => p.Id.Equals(patient.Id));
            if (pt != null)
            {
                pt.PatientName = patient.PatientName;
                pt.JoinDate = patient.JoinDate;
                pt.Address = patient.Address;
                pt.Description = patient.Description;
                service.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
