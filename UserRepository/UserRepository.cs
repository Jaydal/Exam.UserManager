using Exam.UserManager.Repository.Models;
using LiteDB;
using Microsoft.Extensions.Configuration;

namespace Exam.UserManager.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ILiteCollection<UserModel> _userCollection;

        public UserRepository(ILiteDatabase database, IConfiguration configuration)
        {
            string collectionName = configuration.GetSection("Database:UserCollectionName").Value ?? "Users";
            _userCollection = database.GetCollection<UserModel>(collectionName);
        }

        public UserModel Get(int id)
        {
            return _userCollection.FindById(id);
        }

        public IEnumerable<UserModel> Get()
        {
            return _userCollection.FindAll();
        }

        public string Add(UserModel user)
        {
            return _userCollection.Insert(user);
        }

        public bool Update(UserModel user)
        {
            return _userCollection.Update(user);
        }
    }
}
