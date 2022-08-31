using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIDelivery.Models
{
     public class Extra
     {
          public List<Option> options { get; set; }
          public string name { get; set; }
          public int min { get; set; }
          public int max { get; set; }
     }
}
