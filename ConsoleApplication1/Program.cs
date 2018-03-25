using Exchange;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
  
    public class Program
    {
      static void Main(string[] args)
      {
      //BusInitializer.Main();


      IBus bus = new BusInitializer().CreateBus("Test");
      //IBus bus = BusInitializer.CreateBus("newQueue");

      while (true)
      {
        
        DTO.Customers.Company company = new DTO.Customers.Company();
        Console.WriteLine("Please Enter a Company Name or type Quit:");
        var input = Console.ReadLine();
        if (input == "Quit")
          break;
        company.Name = input;
        Console.WriteLine("Please Enter a Company Contact Number or type Quit:");
        input = Console.ReadLine();
        if (input == "Quit")
          break;
        company.ContactNumber= input;
        bus.Publish(company);

      }


      //bus.Publish()
      Console.ReadLine();
      



      DTO.Customers.IIndividual individual = new Individual();
        individual.ContactNumber = "1234";
        individual.FirstName = "FirstName";
        individual.LastName = "Lastname";

        BusinessLayer.Customers.Customers customerLayer = new BusinessLayer.Customers.Customers();
        customerLayer.InsertIndividual(individual);
        //Repo.Customers.Command.InsertCustomer(newIndividual);

        //var df = Repo.Customers.ReadOnly.GetCustomerById(1);
        //Console.WriteLine(df.ContactNumber.ToString() + " - ");

      }

    public class DTOCompany : DTO.Customers.ICompany
    {
      public string ContactNumber { get; set; }
      public string Name { get; set; }
    }
    public class Individual : DTO.Customers.IIndividual
      {
        public string ContactNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
      }
    }
  
}
