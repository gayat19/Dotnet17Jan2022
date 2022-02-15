using SampleMVCTogetherApp.Models;

namespace SampleMVCTogetherApp.Services
{
    public class UserTempService : IRepo<string, User>
    {
        public User Add(User item)
        {
            throw new NotImplementedException();
        }

        public User Get(string id)
        {
            throw new NotImplementedException();
        }

        public ICollection<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Remove(string id)
        {
            int number = new Random().Next(100,200);
            if (number > 150)
                return true;
            return false;
        }

        public bool Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}
