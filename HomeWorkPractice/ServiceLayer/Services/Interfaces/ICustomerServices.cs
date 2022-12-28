using DoaminLayer1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface ICustomerServices
    {
        int GetCustomerCountByFiltred();
        Customer[] GetCustomersByFiltred(int startAge,int endAge);
        double GetCustomerAvaregeByAges();
    }
}
