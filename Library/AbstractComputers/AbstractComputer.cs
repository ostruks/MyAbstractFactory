namespace Library.AbstractComputers
{
    public abstract class AbstractComputer<T> where T : class
    {
        protected abstract string Type { get; set; }
        public abstract string Name { get; protected set; }
        public abstract string Brand { get; protected set; }
        public abstract double Price { get; set; }

        public virtual string Show(T book = null)
        {
            return $"{Type}: {Brand}|{Name}|{Price}";
        }
    }
}
