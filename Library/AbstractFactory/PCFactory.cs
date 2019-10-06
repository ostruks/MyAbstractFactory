using Library.AbstractComputers;

namespace Library.AbstractFactory
{
    public class PCFactory : AbstractFactory<PC>
    {
        public override PC Create(string[] param = null)
        {
            if (param != null && param.Length == 4)
                return new PC(param[0], param[1], param[2], double.Parse(param[3]));
            return new PC();
        }
    }
}
