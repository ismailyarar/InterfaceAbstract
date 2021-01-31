using InterfaceAbstract.Abstract;
using InterfaceAbstract.Adapters;
using InterfaceAbstract.Concrete;
using InterfaceAbstract.Entities;
using System;

namespace InterfaceAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = 1988, FirstName = "ismail", LastName = "yarar", NationalityId = 12523658965 }); 
            Console.ReadLine();
        }
    }
}
