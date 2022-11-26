namespace UB.Services.ViewModels
{
    public class WelcomeFormVM
    {
        public string UserName { get; set; }
        public Guid SpecializationId { get; set; }
        public Guid GradeId { get; set; }
        public bool IsPM { get; set; }
        public bool IsDocWriter { get; set; }
    }
}
