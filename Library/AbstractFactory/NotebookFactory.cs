using Library.AbstractComputers;

namespace Library.AbstractFactory
{
    public class NotebookFactory : AbstractFactory<Notebook>
    {
        public override Notebook Create(string[] param = null)
        {
            if(param != null && param.Length == 4)
                return new Notebook(param[0], param[1], param[2], double.Parse(param[3]));
            return new Notebook();
        }
    }
}
