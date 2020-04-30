namespace FunTODOModels.Individual
{
    public class User : IIndividual
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
