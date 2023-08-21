namespace Hospital;

public class HospitalService
{
    List<Patient> _patients = new List<Patient>
    {
        new Patient("John", "Doe", "Sore throat", new DateTime(2023, 8, 20)),
        new Patient("Jane", "Smith", "Fever", new DateTime(2023, 8, 18)),
        new Patient("Michael", "Johnson", "Cough", new DateTime(2023, 8, 17)),
        new Patient("Emily", "Brown", "Headache", new DateTime(2023, 8, 15)),
        new Patient("William", "Davis", "Fatigue", new DateTime(2023, 8, 12)),
        new Patient("Olivia", "Miller", "Nausea", new DateTime(2023, 8, 10)),
        new Patient("James", "Wilson", "Sore throat", new DateTime(2023, 8, 8)),
        new Patient("Sophia", "Anderson", "Cough", new DateTime(2023, 8, 6)),
        new Patient("Liam", "Martinez", "Fever", new DateTime(2023, 8, 4)),
        new Patient("Ava", "Hernandez", "Headache", new DateTime(2023, 8, 2)),
    };

    public void AddPatient(Patient patient)
    {
        _patients.Add(patient);
    }

    public void UpdatePatient(Guid id, Patient patient)
    {
        var patientToUpdate = _patients.FirstOrDefault(p => p.Id == id);
        if (patientToUpdate!= null)
        {
            patientToUpdate.Name = patient.Name;
            patientToUpdate.Surname = patient.Surname;
            patientToUpdate.Disease = patient.Disease;
            patientToUpdate.RegistrationDate = patient.RegistrationDate;
        }
    }
    
    public void DeletePatient(Guid id)
    {
        var patientToDelete = _patients.FirstOrDefault(p => p.Id == id);
        if (patientToDelete!= null)
        {
            _patients.Remove(patientToDelete);
        }
    }
    
    public void GetPatient(Guid id)
    {
        Console.WriteLine(_patients.FirstOrDefault(p => p.Id == id));
    }
    
    
    public void GetAll()
    {
        foreach (var patient in _patients)
        {
            Console.WriteLine($"{patient.Id} - {patient.Name} - {patient.Surname} - {patient.RegistrationDate} - {patient.Disease}");
        }
    }
        
}