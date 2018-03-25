﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using MassTransit;
using log4net;
using MassTransit.Log4NetIntegration.Logging;
using MassTransit.BusConfigurators;
using GreenPipes;

namespace Exchange
{

  public class CompanyCustomer : IConsumer<DTO.Customers.Company>
  {

    public async Task Consume(ConsumeContext<DTO.Customers.Company> context)
    {
      await Console.Out.WriteLineAsync("$Adding Company : " + context.Message.Name);
      return;
    }


  }

  public class BusInitializer
  {


    public IBus CreateBus(string queueName)
    {
      var bus = Bus.Factory.CreateUsingRabbitMq(sbc =>
      {
        var host = sbc.Host(new Uri("rabbitmq://localhost"), h =>
        {
          h.Username("guest");
          h.Password("guest");
        });


        sbc.ReceiveEndpoint(host, "Pleasework", e =>
        {
          e.Consumer(() => new CompanyCustomer());
      });      });

      bus.Start();
      return bus;
    }

  }
}