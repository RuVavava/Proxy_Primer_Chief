using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proxy_Primer_Chief
{
    //КЛАСС ДОЛЖЕН РЕАЛИЗОВЫВАТЬ ИНТЕРФЕЙС
    internal class Chief : IChief
    {
        //Метод, вовращающий статус заказа (словарик)
        public IDictionary<int, string> GetStatuses()
        {
            Dictionary <int, string> statuses = new Dictionary<int, string>();

            //Заполнение словарика статусами
            statuses.Add(1, "Готово");
            statuses.Add(2, "Не готово");
            statuses.Add(3, "В процессе");

            Thread.Sleep(2000); //Имуляция задержки заказов

            return statuses;
        }

        //Заказ
        public IEnumerable<Order> GetOrders()
        {        
            //Создание списка
            List<Order> orders = new List<Order>();

            //Рандомный статус заказа (от 1 до 3)
            Random rnd = new Random();
            //Заполнение листа заказами
            orders.Add(new Order() { Name = "Бургер", StatusId = rnd.Next(1, 4)});
            orders.Add(new Order() { Name = "Салат", StatusId = rnd.Next(1, 4) });
            orders.Add(new Order() { Name = "Паста", StatusId = rnd.Next(1, 4) });

            return orders;
        }
    }
}
