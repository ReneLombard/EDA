using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Customers
{
  public class Individual : Customer 
  {
    public override CustomerTypes CustomerType 
    {
      get
      {
        return CustomerTypes.Individual;
      }
    }
    public virtual string FirstName { get; set; }
    public virtual string LastName { get; set; }
  }
}
