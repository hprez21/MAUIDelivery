using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIDelivery.Models
{
     public class Option
     {
          public string name { get; set; }
          public List<Suboption> suboptions { get; set; }
          public int min { get; set; }
          public int max { get; set; }
     }
}
