namespace Library.AbstractComputers
{
    public class Notebook : AbstractComputer<PC>
    {
        protected override string Type { get; set; }
        public override string Name { get; protected set; }
        public override string Brand { get; protected set; }
        public override double Price { get; set; }

        public Notebook()
        {
            this.Type = "Notebook";
        }
        public Notebook(string Type, string Name, string Brand, double Price)
        {
            this.Type = Type;
            this.Name = Name;
            this.Brand = Brand;
            this.Price = Price;
        }

        public override string Show(PC notebook = null)
        {
            return notebook != null ? $"{Type}: {Brand}|{Name}|{Price} and PC: {notebook.Brand}|{notebook.Name}|{notebook.Price}" : $"{Type}: {Brand}|{Name}|{Price}";
        }
    }
}
