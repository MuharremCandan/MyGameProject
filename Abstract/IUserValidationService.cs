using AllProjectOfEnginHocaCamp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllProjectOfEnginHocaCamp.Abstract
{
    interface IUserValidationService
    {
        bool Validate(Customer customer);
    }
}
