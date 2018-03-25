using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroService.Customer
{
  public class CompanyCustomer : IConsumer<DTO.Customers.Company>
  {

    public async Task Consume(ConsumeContext<DTO.Customers.Company> context)
    {
      var businessLayer = new BusinessLayer.Customers.Customers();
      Console.WriteLine(context.Message.Name + " : " + context.Message.ContactNumber);
      await businessLayer.InsertCompany(context.Message);
      return;
    }


  }

}
