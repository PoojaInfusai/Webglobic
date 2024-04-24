namespace Webglobic.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public required string UserName { get; set; }
        public required string Password { get; set; }
        public  string UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public Country CountryName { get; set; }
        public UserRoles UserRolesName { get; set; }
        public UserGroup UserGroupName { get; set; }
        public string ProfileImage { get; set; }
        public string Signature { get; set; }


    }
}
