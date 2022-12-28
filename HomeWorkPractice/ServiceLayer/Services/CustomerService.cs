using DoaminLayer1.Models;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class CustomerService : ICustomerServices
    {
        int ICustomerServices.GetCustomerCountByFiltred()
        {
            var customer = GetAll();

            int count = 0;
            foreach (var item in customer)
            {
                if (item.Age > 25 && item.Age < 30)
                {
                    count++;
                }
            }
            return count;

        }

        double ICustomerServices.GetCustomerAvaregeByAges()
        {
            var customer = GetAll();
            double sumAge = 0;


            foreach (var item in customer)
            {
                sumAge += item.Age;
            }

            return Math.Ceiling(sumAge / customer.Length);
        }

        private Customer[] GetAll()
        {
            Customer c1 = new Customer
            {
                Id = 1,
                Name = "Shaiq",
                Surname = "Kazimov",
                Age = 25,
                Position = "Backend developer"
            };

            Customer c2 = new Customer
            {
                Id = 2,
                Name = "Pervin",
                Surname = "Rehimli",
                Age = 25,
                Position = "Frontend developer"
            };

            Customer c3 = new Customer
            {
                Id = 3,
                Name = "Aqshin",
                Surname = "Hummetov",
                Age = 27,
                Position = "Fullstack developer"
            };

            Customer c4 = new Customer
            {
                Id = 4,
                Name = "Jale",
                Surname = "Abdullayeva",
                Age = 18,
                Position = "Software instructor"
            };

            Customer[] customers = { c1, c2, c3, c4 };

            return customers;
        }

        public Customer[] GetCustomersByFiltred(int startAge, int endAge)
        {
            var customer = GetAll();
            
            Customer[] result = new Customer[customer.Length];

            int count = 0;

                       
            foreach (var item in customer)
            {
                if (item.Age > startAge && item.Age < endAge)
                {
                    result[count] = item;
                    count++;
                }
            }
             
             return result;
        }
    }

       
}
