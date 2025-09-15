using AuthAppV2.Dtos;
using AuthAppV2.Types;

namespace AuthAppV2.Services
{
    public interface IUserService
    {
        ServiceMessage AddUser(UserAddDto user);
       
    
    
    }
}
