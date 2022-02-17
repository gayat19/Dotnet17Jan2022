namespace FirstAPI.Services
{
    public interface IRepo<K,T> where T: class
    {
        T Add(T item);
        T Update(T item);
        T Delete(K key);
        IEnumerable<T> GetAll();
        T GetT(K key);
    }
}
