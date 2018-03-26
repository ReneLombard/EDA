using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Customers
{
  public class CommandBaseClass<T,TK>
  {
    protected NHibernateSetup.Connection<T, TK> connection;

    public CommandBaseClass()
    {
      SetupConnection();
    }

    protected virtual void  SetupConnection()
    {
      connection = new NHibernateSetup.Connection<T, TK>();
    }

    public CommandBaseClass(NHibernateSetup.Connection<T, TK> _connection)
    {
      _connection = new NHibernateSetup.Connection<T, TK>();
    }

    public string Insert(TK _parameter)
    {
      try
      {
        return connection.Insert(_parameter);
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
    

  }
}
