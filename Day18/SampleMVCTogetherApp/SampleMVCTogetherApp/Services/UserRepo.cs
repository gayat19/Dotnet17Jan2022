using Microsoft.Data.SqlClient;
using SampleMVCTogetherApp.Exceptions;
using SampleMVCTogetherApp.Models;

namespace SampleMVCTogetherApp.Services
{
    public class UserRepo : IRepo<string, User>
    {
        private readonly ShopContext _context;
        public UserRepo()
        {

        }
        public UserRepo(ShopContext context)
        {
            _context = context;
        }
        public User Add(User item)
        {
            try
            {
                _context.Add(item);
                _context.SaveChanges();
                return item;
            }
            catch (Exception e)
            {
                if((e.InnerException as SqlException).Number == 2601 )
                {
                    throw new UsernameDuplicateException();
                }
            }
            return null;
        }

        public virtual User Get(string id)
        {
            var user = _context.Users.SingleOrDefault(u=>u.Username==id);
            return user;
        }

        public ICollection<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Remove(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}
