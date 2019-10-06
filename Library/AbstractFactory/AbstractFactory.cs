namespace Library.AbstractFactory
{
    public abstract class AbstractFactory<T> where T : class
    {
        public abstract T Create(string[] param = null);
    }
}
