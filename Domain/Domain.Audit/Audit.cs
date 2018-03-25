using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Audit
{
  public partial class Audit
  {
    public virtual int Id { get; set; }
    public virtual string  TableName { get; set; }
    public virtual DateTime TimeStamp { get; set; }
    public virtual string User { get; set; }
    public Audit()
    {
      AuditParameters = new List<Auditparameter>();
    }
    public virtual IList<Auditparameter> AuditParameters { get; set; }
  }
}
