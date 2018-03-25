using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Customers
{
  public abstract class Customer 
  {
    private  int _id;
    public virtual int Id
    {
      get { return _id; }
      set { _id = value; }
    }
    public virtual string ContactNumber { get; set; }
    public abstract CustomerTypes CustomerType { get; }
  }
}
