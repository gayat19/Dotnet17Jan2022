namespace CustomerServiceApplication.Services
{
    public interface IRepo<K,T>
    {
        T Get(K key);
        Task<IEnumerable<T>> GetAll();
        T Delete(K key);
        Task<T> Add(T item);
        T Update(T item);
    }
}
