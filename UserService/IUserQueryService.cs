
namespace Exam.UserManager.Service
{
    public interface IUserQueryService
    {
        UserDTO Get(int id);
        IEnumerable<UserDTO> GetAll();
    }
}