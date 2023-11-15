using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Primer_Chief
{
    //РЕАЛИЗОВЫВАТЬ ВЫДЕЛЕННЫЙ ИНТЕРФЕЙС
    internal class ChiefProxy : IChief
    {
        //Прокси должен содержать ссылку на ресурс
        private readonly Chief _chief;

        //Словарь для КЭШИРОВАННЫХ статусов
        private IDictionary<int, string> _statuses;

        //Принимаем через конструктор
        public ChiefProxy(Chief chief)
        {
            _chief = chief;
        }

        public IEnumerable<Order> GetOrders()
        {
            return _chief.GetOrders(); //проксируем запрос 
        }

        public IDictionary<int, string> GetStatuses() //Статусы кэшируем
        {
            if( _statuses == null ) //Если не заполнил - проксируем запрос к Chief
            {
                _statuses = _chief.GetStatuses();
            }

            return _statuses;
        }
    }
}
