namespace CPro_1
{
    //update new class
    public class TrasportInformation<T> where T : class, new()
    {
        public T WriteInformation() 
        {
            return new T();
        }
    }
}
