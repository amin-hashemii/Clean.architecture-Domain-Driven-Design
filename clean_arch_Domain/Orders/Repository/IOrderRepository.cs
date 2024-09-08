﻿using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace clean_arch_Domain.Orders.Repository
{
    public interface IOrderRepository
    {


        List<Order> GetList();
        Order GetById(long id);
        void Add(Order order);
        void Update(Order order);

        void  SaveChanges();
    }
}
