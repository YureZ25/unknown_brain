namespace UB.Data.Domain
{
    public class User : Entity
    {
        public string UserName { get; set; }

        public Guid GradeId { get; set; }
        public Grade Grade { get; set; }
    }
}
