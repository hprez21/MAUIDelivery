using MAUIDelivery.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIDelivery.Models
{
     public class Ingredient : BaseOptionsItem
     {
          public int Product_id { get; set; }
          public string Name { get; set; }
          public object Image { get; set; }
     }

     public class BaseOptionsItem
     {
          public int Id { get; set; }
          public string GroupName { get; set; }
          public EnumRule Rule { get; set; }
          public bool IsSelected { get; set; }
     }
}
