namespace Backomm.Contracts.V1.Responses
{
    public class BaseResponse<T>
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}