using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Customers
{

  public class Company : ICompany
  {
   public string ContactNumber { get; set; }
   public string Name { get; set; }
  }
  public interface ICompany
  {
    string ContactNumber { get; set; }
    string Name { get; set; }
  }
}
