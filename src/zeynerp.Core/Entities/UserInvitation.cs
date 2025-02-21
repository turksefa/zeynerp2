namespace zeynerp.Core.Entities
{
    public class UserInvitation : BaseEntity
    {
        public string Email { get; set; } = string.Empty;
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public string Token { get; set; }
        public bool IsAccepted { get; set; }
    }
}