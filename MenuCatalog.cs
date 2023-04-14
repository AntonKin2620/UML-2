using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UML_2_Pizza_Store
{
    public class MenuCatalog
    {
        List<Pizza> _pizzas;

     public MenuCatalog()
        {
            _pizzas = new List<Pizza>(); 
        }

        public void Create(Pizza p)
        {
            _pizzas.Add(p);
        }

        public void Update(Pizza p) 
        {
            Update(p);
        }

        public void Read(Pizza p) 
        {
            Read(p);        
        }
        public void Delete(Pizza p) 
        {
            _pizzas.Remove(p);
        }
        public void PrintMenu()
        {
            foreach(Pizza p in _pizzas) 
            {
                Console.WriteLine(p);
            }

        }

        internal void Delete(int pizzaToBeDeleted)
        {
            throw new NotImplementedException();
        }

        internal void Update(object foundPizza)
        {
            throw new NotImplementedException();
        }

        internal Pizza SearchPizza(object searchCriteria)
        {
            throw new NotImplementedException();
        }
    }
}
