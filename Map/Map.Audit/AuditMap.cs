using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Audit
{
  public partial class AuditMap : ClassMap<Domain.Audit.Audit>
  {
    public AuditMap()
    {
      Table("Audit");
      LazyLoad();
      Id(x => x.Id).GeneratedBy.Identity().Column("Id");
      Map(x => x.TableName).Column("TableName").Not.Nullable().Length(50);
      Map(x => x.TimeStamp).Column("TimeStamp").Not.Nullable();
      Map(x => x.User).Column("User").Not.Nullable().Length(50);
      HasMany(x => x.AuditParameters).KeyColumn("ParentID");
    }
  }
}
