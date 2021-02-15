using System;
using System.Collections.Generic;
using System.Text;
using AllProjectOfEnginHocaCamp.Entities;

namespace AllProjectOfEnginHocaCamp.Abstract
{
    internal interface ICustomerService 
    {
        public void Add(Customer customer);
        public void Update(Customer customer);
        public void Delete(Customer customer);

    }
}
