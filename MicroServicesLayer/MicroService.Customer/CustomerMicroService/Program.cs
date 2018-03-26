
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroService.Customer
{
  class Program
  {
    static void Main(string[] args)
    {

      var bus = Bus.Factory.CreateUsingRabbitMq(sbc =>
      {
        var host = sbc.Host(new Uri("rabbitmq://localhost"), h =>
        {
          h.Username("guest");
          h.Password("guest");
        });

        sbc.ReceiveEndpoint(host, "AddIndividual", e =>
        {
          e.Consumer(() => new IndividualCustomer());
        });

        sbc.ReceiveEndpoint(host, "AddCompany", e =>
        {
          e.Consumer(() => new CompanyCustomer());
        });
      });

      bus.Start();

      //var bus = Exchange.BusInitializer.CreateBus("CustomerBus");
      //bus.

      //  , x =>
      //{
      //  x.Subscribe(subs =>
      //  {
      //    subs.Consumer<SomethingHappenedConsumer>().Permanent();
      //  });
      //});

      //kConsole.ReadKey();

      //bus.Dispose();
    }
  }
}
