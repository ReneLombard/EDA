
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Customers
{
  public class ReadOnly
  {
    NHibernateSetup.Connection<Map.Customers.CustomerMap, Domain.Customers.Customer> connection;

    public ReadOnly(NHibernateSetup.Connection<Map.Customers.CustomerMap, Domain.Customers.Customer> _connection)
    {
      connection = _connection;
    }

    public ReadOnly()
    {
      SetupConnection();
    }
    
    public List<Domain.Customers.Customer> GetAllCustomers()
    {
      return connection.GetAll();
    }

    public Domain.Customers.Customer GetCustomerById(int id)
    {
      return connection.GetByProperty(new KeyValuePair<string, object>("Id", id));
    }
    private void SetupConnection()
    {
      connection = new NHibernateSetup.Connection<Map.Customers.CustomerMap, Domain.Customers.Customer>();
    }
  }
}
