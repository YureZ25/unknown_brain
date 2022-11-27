namespace UB.Data.Domain
{
    public class Recomendation : Entity
    {
        public Guid? GradeId { get; set; }
        public Grade Grade { get; set; }    

        public Guid? SpecializationId { get; set; }
        public Specialization Specialization { get; set; }

        public string Author { get; set; }

        public string Title { get; set; }
    }
}
