namespace CustomerServiceApplication.Services
{
    public interface IRepo<K,T>
    {
        Task<T> Get(K key);
        Task<IEnumerable<T>> GetAll();
        Task<T> Delete(K key);
        Task<T> Add(T item);
        Task<T> Update(T item);
    }
}
