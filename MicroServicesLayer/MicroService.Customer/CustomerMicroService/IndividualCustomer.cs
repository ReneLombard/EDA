using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroService.Customer
{
  public class IndividualCustomer : IConsumer<DTO.Customers.Individual>
  {
    public async Task Consume(ConsumeContext<DTO.Customers.Individual> context)
    {
      var businessLayer = new BusinessLayer.Customers.Customers();
      Console.WriteLine(context.Message.FirstName + " : " + context.Message.LastName + " : " + context.Message.ContactNumber);
      await businessLayer.InsertIndividual(context.Message);
      return;
    }
  }
}
