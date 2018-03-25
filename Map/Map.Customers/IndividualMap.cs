using Domain.Customers;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Customers
{
  public partial class IndividualMap : SubclassMap<Individual>
  {

    public IndividualMap()
    {
      Table("Individual");
      Map(x => x.FirstName).Column("FirstName").Length(50);
      Map(x => x.LastName).Column("LastName").Length(50);
    }
  }
}
