namespace CashFlow.Communication.Responses;

public class ResponseErrorJson
{
    public required string ErrorMessage { get; set; } = string.Empty;

    // Uncomment the constructor if you want to initialize ErrorMessage directly in constructor mode
    //public ResponseErrorJson(string errorMessage)
    //{
    //    ErrorMessage = errorMessage;
    //}
}