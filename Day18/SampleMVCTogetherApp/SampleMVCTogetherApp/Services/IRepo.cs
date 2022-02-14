namespace SampleMVCTogetherApp.Services
{
    public interface IRepo<K,T> : IAdding<K,T>
    {
        ICollection<T> GetAll();
        T Get(K id);
       
        bool Remove(K id);
        bool Update(T item);
    }
}
