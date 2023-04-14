using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UML_2_Pizza_Store
{
    public class Store
    {
        MenuCatalog menuCatalog;

        public Store()
        { 
            menuCatalog = new MenuCatalog();
        }

        public void Test()
        {
            Pizza p = new Pizza(){ Number = 1, Name = "Pizza#1", Price = 50 };
            menuCatalog.Create(p);

            p = new Pizza() { Number = 2, Name = "Pizza#2", Price = 55 };
            menuCatalog.Create(p);

            p = new Pizza() { Number = 3, Name = "Pizza#3", Price = 65 };
            menuCatalog.Create(p);

            menuCatalog.PrintMenu();


            
            //Console.Writeline();
            //int pizzaToBeFound = 2;
            //Console.Writeline($"Finding Pizza starting with: {searchCriteria}");
            //foundPizza = menuCatalog.SearchPizza(searchCriteria);
            //Console.Writeline(foundPizza);

            //Console.WriteLine();
            //Console.WriteLine($"Updating Pizza #{foundPizza.Number}");
            //foundPizza.Name += " (Updated)";
            //menuCatalog.Update(foundPizza);

            //Console.WriteLine();
            //menuCatalog.PrintMenu();

            //Console.WriteLine();
            //int pizzaToBeDeleted = 2;
            //Console.WriteLine($"Deleting pizza#: {pizzaToBeDeleted}");
            //menuCatalog.Delete(pizzaToBeDeleted);
            //Console.WriteLine();
            //menuCatalog.PrintMenu();

        }
        public void Run()
        {
            new UserDialog(menuCatalog).Run();
        }

        internal void Start()
        {
            throw new NotImplementedException();
        }
    }
}
