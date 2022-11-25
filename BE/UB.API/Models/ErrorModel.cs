namespace UB.API.Models
{
    public class ErrorModel
    {
        public string ErrorMessage { get; set; }

        public ErrorModel(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }
    }
}
