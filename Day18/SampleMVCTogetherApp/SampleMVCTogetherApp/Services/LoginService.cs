using SampleMVCTogetherApp.Models;

namespace SampleMVCTogetherApp.Services
{
    public class LoginService
    {
        private readonly IRepo<string, User> _repo;

        public LoginService(IRepo<string,User> repo)
        {
            _repo = repo;
        }
        public User LoginCheck(User user)
        {
            var myuser = _repo.Get(user.Username);
            if(myuser != null)
            {
                if(user.Password== myuser.Password)
                {
                    user.Password = null;
                    return user;
                }
            }
            return null;
        }
    }
}
