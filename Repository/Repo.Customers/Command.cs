using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Customers
{
  public  class Command : CommandBaseClass<Map.Customers.CustomerMap, Domain.Customers.Customer>
  {
    //private NHibernateSetup.Connection<Map.Customers.CustomerMap, Domain.Customers.Customer> connection;

    public Command() : base()
    {
    }

    protected override void SetupConnection()
    {
      connection = new NHibernateSetup.Connection<Map.Customers.CustomerMap, Domain.Customers.Customer>();
    }
    public Command(NHibernateSetup.Connection<Map.Customers.CustomerMap, Domain.Customers.Customer> _connection) : base(_connection)
    {
      _connection = new NHibernateSetup.Connection<Map.Customers.CustomerMap, Domain.Customers.Customer>();
    }

    //private  string InsertCustomer(Domain.Customers.Customer _customer)
    //{
    //  try
    //  {
    //    return connection.Insert(_customer);
    //  }
    //  catch (Exception ex)
    //  {
    //    throw ex;
    //  }
    //}

    //public  string InsertCompany(DTO.Customers.ICompany _company)
    //{
    //  try
    //  {
    //    var company = new Domain.Customers.Company();
    //    company.ContactNumber = _company.ContactNumber;
    //    company.Name = _company.Name;
    //    return InsertCustomer(company);
    //  }
    //  catch(Exception ex)
    //  {
    //    throw ex;

    //  }
    //}

    //public  string InsertIndividual(DTO.Customers.IIndividual _individual)
    //{
    //  try
    //  {
    //    var individual = new Domain.Customers.Individual();
    //    individual.ContactNumber = _individual.ContactNumber;
    //    individual.FirstName= _individual.FirstName;
    //    individual.LastName = _individual.LastName;
    //    return InsertCustomer(individual);
    //  }
    //  catch (Exception ex)
    //  {
    //    throw ex;

    //  }
    //}

  }
}
