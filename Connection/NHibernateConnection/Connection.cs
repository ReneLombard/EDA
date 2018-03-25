using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateSetup
{
  public class Connection<T, TK>
  {

    public ISessionFactory CreateSessionFactory()
    {
      try
      {
        var value = Fluently
          .Configure()
          //.Database(MsSqlConfiguration.MsSql2012.ConnectionString(c => c.FromConnectionStringWithKey("connectionStringKey")))
          .Database(MsSqlConfiguration.MsSql2012.ConnectionString("Integrated Security=True;server=(local);database=TestDatabase;MultipleActiveResultSets=True;Connection Timeout=180;"))
          .Mappings(m => m.FluentMappings.AddFromAssemblyOf<T>())

              //      //.ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
              .BuildSessionFactory();
        return value;
      }
      catch (Exception e)
      {
        Console.WriteLine(e.ToString());
        throw e;
      }
    }
    public List<TK> GetAll()
    {
      using (ISessionFactory isession = CreateSessionFactory())
      {
        var test = isession.OpenSession();

        var list = test.Query<TK>().ToList();
        test.Close();
        return list;
      }
    }

    public TK GetByProperty(KeyValuePair<string, object> parameter)
    {
      try
      {
        using (ISessionFactory isession = CreateSessionFactory())
        {
          var test = isession.OpenSession();

          var list = test.Query<TK>().ToList();
          foreach (TK item in list)
          {
            var property = item.GetType().GetRuntimeProperties().FirstOrDefault(p => string.Equals(p.Name, parameter.Key, StringComparison.OrdinalIgnoreCase));
            if (property == null)
              continue;

            if (property.GetValue(item).ToString() == parameter.Value.ToString())
            {
              test.Close();
              return item;
            }

          }

          throw new Exception("No Value found");
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    public string Insert(TK value)
    {

      try
      {
        using (ISessionFactory isession = CreateSessionFactory())
        {
          var session = isession.OpenSession();
          using (var transaction = session.BeginTransaction())
          {
            session.Save(value);
            transaction.Commit();
          }
          session.Close();
        }
        return "Inserted Record";
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }





  }
}
