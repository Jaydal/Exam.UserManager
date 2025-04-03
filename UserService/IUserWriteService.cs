namespace Exam.UserManager.Service
{
    public interface IUserWriteService
    {
        string Add(UserDTO userDto);
        bool Delete(int id);
        bool Update(UserDTO userDto);
    }
}