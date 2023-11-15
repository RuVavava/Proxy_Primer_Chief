using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Primer_Chief
{
    //Интерфейс, где есть методы, которыми мы используем у ресурса
    public interface IChief
    {
        //Медот получения статуса
        IDictionary<int, string> GetStatuses();
        //Метод получения заказа
        IEnumerable<Order> GetOrders();
    }
}
