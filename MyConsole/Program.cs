using System;
using Library;
using Library.AbstractFactory;

namespace MyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager(new PCFactory());
            manager.Show();

            Console.WriteLine("==========================");

            manager = new Manager(new NotebookFactory());
            manager.Show();

            Console.WriteLine("==========================");

            manager = new Manager(new NotebookFactory(), new string[] { "Notebook", "45736", "Asus", "34,5" });
            manager.Show();

            Console.WriteLine("==========================");

            manager = new Manager(new PCFactory(), new string[] { "PC", "34522", "MSI", "78,7" });
            manager.Show();

            Console.WriteLine("==========================");

            manager = new Manager(new PCFactory(), new NotebookFactory(), new string[] { "PC", "34522", "MSI", "78,7", "Notebook", "45736", "Asus", "34,5" });
            manager.Show();

            Console.ReadKey();
        }
    }
}
