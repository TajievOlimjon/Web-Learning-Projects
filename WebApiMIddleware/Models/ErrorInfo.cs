namespace WebApiMIddleware.Models
{
    public class ErrorInfo
    {
        public int StatusCode { get; set; } = 0;
        public string ErrorMessage { get; set; } = string.Empty;
    }
}
