namespace AuthAppV2.Entities
{
    public class UserEntity : BaseEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public UserType UserType { get; set; }
    }

    // Property'deki UserType ya User ya Admin atanabilir.
    public enum UserType
    {
        User, Admin
    }

}
