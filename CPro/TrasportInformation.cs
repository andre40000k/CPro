namespace CPro_1
{
    public class TrasportInformation<T> where T : class, new()
    {
        public T WriteInformation() 
        {
            return new T();
        }
    }
}
