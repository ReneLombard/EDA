using Domain.Customers;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Customers
{
  public partial class CompanyMap : SubclassMap<Company>
  {

    public CompanyMap()
    {
      Table("Company");
      Map(x => x.Name).Column("Name").Length(50);
    }
  }
}
