using AllProjectOfEnginHocaCamp.Abstract;
using AllProjectOfEnginHocaCamp.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace AllProjectOfEnginHocaCamp.Concrete
{
    class CustomerManager : ICustomerService
    {
        // eğer bir manager sınıfın içerisinde başka bir manager kullanman gerekli ise asla onu newleme onun yerine constructer çağır
        IUserValidationService _userValidationService;

        public CustomerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Customer customer)
        {
            if (_userValidationService.Validate(customer) == true)
            {
                Console.WriteLine("Customer has added! ");
            }
            else
            {
                Console.WriteLine("Validation is unsuccesfully !");
            }
           
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer has deleted! ");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Customer has updated! ");
        }
    }
}
