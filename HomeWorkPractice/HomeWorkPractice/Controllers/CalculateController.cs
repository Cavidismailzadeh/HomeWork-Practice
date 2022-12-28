using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPractice.Controllers
{     
    public class CalculateController
    {
        public void MultiplyArrayItems()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 12 };
            ICalculateService calculateService = new CalculateService();

           var result= calculateService.MultiplyArrayItems(arr);

            Console.WriteLine(result);
        }

        public void PowOfSumArrayItems()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 12 };
            ICalculateService calculateService = new CalculateService();

            var result = calculateService.PowOfSumArrayItems(arr);

            Console.WriteLine(result);
        }

    }
}
