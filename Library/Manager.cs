using Library.AbstractComputers;
using Library.AbstractFactory;
using System;

namespace Library
{
    public class Manager
    {
        private PC _pc = null;
        private Notebook _notebook = null;

        public Manager(AbstractFactory<PC> factory, string[] param = null)
        {
            _pc = factory.Create(param);
        }

        public Manager(AbstractFactory<Notebook> factory, string[] param = null)
        {
            _notebook = factory.Create(param);
        }

        public Manager(AbstractFactory<PC> factory1, AbstractFactory<Notebook> factory2, string[] param = null)
        {
            string[] param2 = new string[4];
            Array.Copy(param, 0, param2, 0, param2.Length);
            _pc = factory1.Create(param2);
            param2 = new string[4];
            Array.Copy(param, 4, param2, 0, param2.Length);
            _notebook = factory2.Create(param2);
        }

        public void Show()
        {
            if(_pc != null)
                Console.WriteLine(_pc.Show((_notebook != null ? _notebook : null)));
            if (_notebook != null)
                Console.WriteLine(_notebook.Show((_pc != null ? _pc : null)));
        }
    }
}
