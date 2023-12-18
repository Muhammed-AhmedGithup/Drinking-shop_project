
using Drinking_shop_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drinking_shop_project.Data
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
