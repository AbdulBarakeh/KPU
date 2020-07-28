using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Runtime.CompilerServices;

namespace DependencyInjection
{
    class Program
    {
        private CompositionContainer _container;
        [Import(typeof(ICalculator))]
        public ICalculator calculator;
        private Program()
        {
            // An aggregate catalog that combines multiple catalogs.
            var catalog = new AggregateCatalog();
            // Adds all the parts found in the same assembly as the Program class.
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(Program).Assembly));

            // Create the CompositionContainer with the parts in the catalog.
            _container = new CompositionContainer(catalog);

            // Fill the imports of this object.
            try
            {
                this._container.ComposeParts(this);
            }
            catch (CompositionException compositionException)
            {
                Console.WriteLine(compositionException.ToString());
            }
        }

        static void Main(string[] args)
        {
            // Composition is performed in the constructor.
            var p = new Program();
            string s;
            Console.WriteLine("Enter Command:");
            while (true)
            {
                s = Console.ReadLine();
                Console.WriteLine(p.calculator.Calculate(s));
            }
        }
    }
}
