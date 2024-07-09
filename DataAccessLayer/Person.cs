namespace AzureContinuousIntegration.DataAccessLayer
{
    public class Person
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
