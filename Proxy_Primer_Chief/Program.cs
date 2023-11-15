using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proxy_Primer_Chief
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Chief chief = new Chief(); //Без интерфейса

            IChief chief = new Chief(); //С интерфейсом, без прокси
            IChief chief = new ChiefProxy(new Chief()); //ПРОКСИ

            //Имулируем мониторинг заказов
            while (true)
            {
                Thread.Sleep(2000); //Переодичность обновления 2 секунды
                Console.Clear(); //Очистим консоль

                Console.WriteLine("Добро пожаловать!");
                Console.WriteLine("======== СТАТУС ЗАКАЗА ========\n");

                IEnumerable<Order> orders = chief.GetOrders();

                foreach(Order order in orders)
                {
                    string status = chief.GetStatuses().First(s => s.Key == order.StatusId).Value;
                    
                    Console.WriteLine($"{order.Name} \t\t {status}");
                }
            }
        }
    }
}
