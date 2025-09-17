using AuthAppV2.Entities;

namespace AuthAppV2.Dtos
{
    public class UserInfoDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public UserType UserType { get; set; }
    }
}
