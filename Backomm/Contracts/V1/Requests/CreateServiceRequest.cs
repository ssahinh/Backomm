namespace Backomm.Contracts.V1.Requests
{
    public class CreateServiceRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class GetServiceByIdRequest
    {
        public int ServiceId { get; set; }
    }
}