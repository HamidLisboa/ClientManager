namespace ClientManager.Models
{
    public class Client
    {
        public required int id { get; set; }
        public required string? firstName { get; set; }
        public required string? lastName { get; set; }
        public required int age { get; set; }
        public required string? email { get; set; }
        public string? phoneNumber { get; set; }
    }
}
