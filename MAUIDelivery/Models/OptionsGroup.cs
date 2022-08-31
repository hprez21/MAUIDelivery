using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIDelivery.Models
{
     public class OptionsGroup : List<BaseOptionsItem>
     {
          public string Name { get; set; }

          public OptionsGroup(string name, List<BaseOptionsItem> subOptions) : base(subOptions)
          {
               Name = name;
          }
     }
}
