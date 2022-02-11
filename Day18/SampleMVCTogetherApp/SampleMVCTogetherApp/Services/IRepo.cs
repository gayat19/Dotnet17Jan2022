namespace SampleMVCTogetherApp.Services
{
    public interface IRepo<K,T>
    {
        ICollection<T> GetAll();
        T Get(K id);
        bool Add(T item);
        bool Remove(K id);
        bool Update(T item);
    }
}
