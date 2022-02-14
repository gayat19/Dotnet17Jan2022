namespace SampleMVCTogetherApp.Exceptions
{
    public class UsernameDuplicateException : Exception
    {
        string msg;
        public UsernameDuplicateException()
        {
            msg = "Username already present";
        }
        public override string Message => msg;
    }
}
