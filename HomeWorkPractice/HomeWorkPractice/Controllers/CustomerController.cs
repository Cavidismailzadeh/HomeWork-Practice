using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPractice.Controllers
{
    public class CustomerController
    {
        private readonly ICustomerServices _service;
        public CustomerController()
        {
            _service = new CustomerService();
        }

        public void GetCustomerAvaregeByAges()
        {
            Console.WriteLine(_service.GetCustomerAvaregeByAges());
        }

        public void GetCustomerCountByFiltred()
        {
            Console.WriteLine(_service.GetCustomerCountByFiltred());
        }

        public void GetCustomerByFiltred()
        {
            int startAge = 22;
            int endAge = 30;

           var result = _service.GetCustomersByFiltred(startAge, endAge);

            foreach (var item in result)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.Id} {item.Name} {item.Surname} {item.Age} {item.Position}");

                }

            }
        }
    }
}
