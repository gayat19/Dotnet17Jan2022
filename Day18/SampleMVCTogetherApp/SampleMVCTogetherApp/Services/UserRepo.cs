using Microsoft.Data.SqlClient;
using SampleMVCTogetherApp.Exceptions;
using SampleMVCTogetherApp.Models;

namespace SampleMVCTogetherApp.Services
{
    public class UserRepo : IAdding<string, User>
    {
        private readonly ShopContext _context;

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

        
    }
}
