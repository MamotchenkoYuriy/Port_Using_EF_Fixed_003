using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using DataAccessLayer.DAO;
using DataAccessLayer.Manager;

namespace InteractiveConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //new InteractiveConsole().Menu("Меню");
            //IManager<Captain> manager = new Manager<Captain>();
            var listCity = DAOManager.GetInstance().Manager<City>().FindAll();
            foreach (var item in listCity)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }
    }
}
