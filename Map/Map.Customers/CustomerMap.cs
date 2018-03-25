using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
namespace Map.Customers
{
  public class CustomerMap : ClassMap<Domain.Customers.Customer>
  {

    public CustomerMap()
    {

      Table("Customer");
      LazyLoad();
      Id(x => x.Id)
        .GeneratedBy
        .Identity()
        .Column("Id")
        .Access
        .CamelCaseField(Prefix.Underscore); 
      //References(x => x.Customer).Column("CustomerId");
      Map(x => x.ContactNumber).Column("ContactNumber").Length(50);
      Map(x => x.CustomerType, "CustomerTypeID").CustomType<Domain.Customers.CustomerTypes>().Access.ReadOnly(); ;
      
    }
  }
}
