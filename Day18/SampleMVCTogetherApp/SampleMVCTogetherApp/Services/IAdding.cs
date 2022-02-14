namespace SampleMVCTogetherApp.Services
{
    public interface IAdding<K,T>
    {
        T Add(T item);
    }
}
