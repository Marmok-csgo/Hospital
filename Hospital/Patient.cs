namespace Hospital;

public class Patient
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Disease { get; set; }
    public DateTime RegistrationDate { get; set; }
        
    public Patient(string? name, string? surname, string? disease, DateTime registrationDate)
    {
        Id = Guid.NewGuid();
        Name = name;
        Surname = surname;
        Disease = disease;
        RegistrationDate = registrationDate;
    }
}