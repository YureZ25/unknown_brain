namespace UB.Services
{
    public class RespModel<T> where T : class
    {
        public bool Success { get; private set; }

        public T Data { get; private set; }

        public string ErrorMessage { get; private set; }

        public RespModel(T data)
        {
            Success = true;
            Data = data;
            ErrorMessage = string.Empty;
        }

        public RespModel(string errorMessage)
        {
            Success = false;
            Data = default;
            ErrorMessage = errorMessage;
        }
    }
}
