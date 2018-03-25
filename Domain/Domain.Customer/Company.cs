using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Customers
{
  public class Company : Customer
  {
    public virtual string Name { get; set; }
    public override CustomerTypes CustomerType { get { return CustomerTypes.Company; } }

  }
}
