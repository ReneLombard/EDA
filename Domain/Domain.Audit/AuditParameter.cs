using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Audit
{
  public partial class Auditparameter
  {
   
    public virtual int Id { get; set; }
    public virtual Audit Audit { get; set; }
    public virtual Auditparameter AuditParameterVal{ get; set; }
    public virtual string Key { get; set; }
    public virtual string Value { get; set; }
    public Auditparameter()
    {
      AuditParameters = new List<Auditparameter>();
    }
    public virtual IList<Auditparameter> AuditParameters { get; set; }
  }
}
