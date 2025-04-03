using Exam.UserManager.Repository.Models;

namespace Exam.UserManager.Repository
{
    public interface IUserRepository
    {
        string Add(UserModel user);
        IEnumerable<UserModel> Get();
        UserModel Get(int id);
        bool Update(UserModel user);
    }
}