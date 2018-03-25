using Domain.Audit;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Audit
{
  public partial class AuditparameterMap : ClassMap<Auditparameter>
  {

    public AuditparameterMap()
    {
      Table("AuditParameter");
      LazyLoad();
      Id(x => x.Id).GeneratedBy.Identity().Column("Id");
      References(x => x.Audit).Column("ParentID");
      References(x => x.AuditParameterVal).Column("PreviousID");
      Map(x => x.Key).Column("Key").Not.Nullable().Length(50);
      Map(x => x.Value).Column("Value").Not.Nullable();
      HasMany(x => x.AuditParameters).KeyColumn("PreviousID");
    }
  }
}
