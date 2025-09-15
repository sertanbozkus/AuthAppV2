using AuthAppV2.Context;
using AuthAppV2.Dtos;
using AuthAppV2.Entities;
using AuthAppV2.Services;
using AuthAppV2.Types;

namespace AuthAppV2.Managers
{
    public class UserManager : IUserService
    {
        private readonly AuthAppDbContext _db;

        public UserManager(AuthAppDbContext db)
        {
            _db = db;
        }

        public ServiceMessage AddUser(UserAddDto user)
        {
            var newUserEntity = new UserEntity
            {
                Email = user.Email,
                Password = user.Password
            };

            _db.Users.Add(newUserEntity);
            _db.SaveChanges();

            return new ServiceMessage
            {
                IsSucceed = true,
                Message = "Başarıyla kayıt olundu."
            };
           
        }
    }
}
