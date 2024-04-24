namespace Webglobic.Models
{
    public class UserRoleDetails
    {
        public Guid Id { get; set; }
        public string RolesName { get; set; }
        public string MenuName { get; set; }
        public bool AllowRead { get; set; }
        public bool AllowCreate { get; set; }
        public bool AllowUpdate { get; set; }
        public bool AllowDelete { get; set; }
        public bool AddInNavigation { get; set; }
    }
}
