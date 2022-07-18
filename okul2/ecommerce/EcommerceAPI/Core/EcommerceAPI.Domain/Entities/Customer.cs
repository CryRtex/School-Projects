using EcommerceAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Domain.Entities
{
  public class Customer : BaseEntity
  {
    public string name { get; set; }
    public ICollection<Order> Orders { get; set; }
  }
}
