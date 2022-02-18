namespace GatewayAPI.Services
{
    public interface IManageUSer<T>
    {
        Task<T> Add(T user);
        Task<T> Login(T user);
    }
}
