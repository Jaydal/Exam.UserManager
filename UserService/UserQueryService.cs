using AutoMapper;
using Exam.UserManager.Repository;
using Exam.UserManager.Repository.Models;
using Exam.UserManager.Service.Security;

namespace Exam.UserManager.Service
{
    public class UserQueryService : IUserQueryService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserPermission _userPermission;
        private readonly IMapper _mapper;

        public UserQueryService(IUserRepository userRepository, IUserPermission userPermission, IMapper mapper)
        {
            _userRepository = userRepository;
            _userPermission = userPermission;
            _mapper = mapper;
        }

        public UserDTO Get(int id)
        {
            if (_userPermission.CanRead())
            {
                UserModel user = _userRepository.Get(id);
                UserDTO userDto = _mapper.Map<UserDTO>(user);
                return userDto;
            }

            throw new ArgumentException("Permission not allowed!");
        }

        public IEnumerable<UserDTO> GetAll()
        {
            //TODO Item 1: Implement the logic to get all users
            throw new NotImplementedException();
        }
    }
}
