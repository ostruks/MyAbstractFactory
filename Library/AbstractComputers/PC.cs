namespace Library.AbstractComputers
{
    public class PC : AbstractComputer<Notebook>
    {
        protected override string Type { get; set; }
        public override string Name { get; protected set; }
        public override string Brand { get; protected set; }
        public override double Price { get; set; }

        public PC()
        {
            this.Type = "PC";
        }
        public PC(string Type, string Name, string Brand, double Price)
        {
            this.Type = Type;
            this.Name = Name;
            this.Brand = Brand;
            this.Price = Price;
        }

        public override string Show(Notebook notebook = null)
        {
            return notebook != null ? $"{Type}: {Brand}|{Name}|{Price} and Notebook: {notebook.Brand}|{notebook.Name}|{notebook.Price}" : $"{Type}: {Brand}|{Name}|{Price}";
        }
    }
}
