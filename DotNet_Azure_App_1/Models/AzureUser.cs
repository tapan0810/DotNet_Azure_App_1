namespace DotNet_Azure_App_1.Models
{
    public class AzureUser
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string UserEmail { get; set; } = string.Empty;
        public string UserRole { get; set; } = string.Empty;
        public bool IsActive { get; set; } = false;

    }
}
