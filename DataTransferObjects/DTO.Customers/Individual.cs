
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Customers
{
  public class Individual : IIndividual
  {
    public string ContactNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
  }
  public interface IIndividual
  {
    string ContactNumber { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
  }
}
