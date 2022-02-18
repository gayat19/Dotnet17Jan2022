namespace GatewayAPI.Services
{
    public interface IGenerateToken<T>
    {
        string CreateToken(T user);
    }
}
