namespace Hospital;

class Program
{
    static void Main(string[] args)
    {
        var service = new HospitalService();
        service.AddPatient(new Patient("Aziz", "palonchiyev", "Headache", DateTime.Now.AddDays(-2)));
        service.AddPatient(new Patient("Firadvs", "Tolibov", "Meet with Aziz", DateTime.Now.AddDays(-1)));


        service.GetPatient(new Guid("12394ff1-5a9a-44a8-b063-e9274ed6504e"));
        
        service.UpdatePatient(new Guid("12394ff1-5a9a-44a8-b063-e9274ed6504e"),
            new Patient("New", "NNew", "deasee", DateTime.Now.AddDays(-1)));
        
        service.GetAll();
        
    }
}