using AllProjectOfEnginHocaCamp.Abstract;
using AllProjectOfEnginHocaCamp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllProjectOfEnginHocaCamp.Concrete
{
    class UserValidationManager : IUserValidationService
    {
       

        public bool Validate(Customer customer)
        {
            if(customer.FirstName.Equals("Muharrem") && customer.LastName.Equals("Candan") && customer.IdentityNumber==123123123 && customer.Id == 1 && customer.DateOfBirth== 2001)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
