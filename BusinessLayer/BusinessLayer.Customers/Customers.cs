using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Customers
{
  public class Customers
  {

    public Customers()
    { }
    public Task InsertCompany(DTO.Customers.ICompany _company)
    {
      try
      {

        Repo.Customers.Command command = new Repo.Customers.Command();
        Domain.Customers.Company company = new Domain.Customers.Company();
        company.ContactNumber = _company.ContactNumber;
        company.Name = _company.Name;
        command.Insert(company);
        return new Task(() => Console.Out.WriteLineAsync("Console Write"));
        //return command.Insert(company);
        //return string.Empty;
      }

      catch (Exception ex)
      {
        throw ex;
      }

    }

    public Task InsertIndividual(DTO.Customers.IIndividual _individual)
    {
      try
      {

        Repo.Customers.Command command = new Repo.Customers.Command();
        Domain.Customers.Individual individual = new Domain.Customers.Individual();
        individual.ContactNumber = _individual.ContactNumber;
        individual.FirstName = _individual.FirstName;
        individual.LastName = _individual.LastName;
        
        return new Task(() =>command.Insert(individual));
      }
      catch (Exception ex)
      {
        throw ex;
      }

    }
  }
}
