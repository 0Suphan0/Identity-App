namespace LoginApp.Models
{
    public class UserWithRolesVm
    {
        public string UserId { get; set; } = "";
        public string Email { get; set; } = "";
        public string UserName { get; set; } = "";
        public bool IsAdmin { get; set; }
    }
}
