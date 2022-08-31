using MAUIDelivery.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIDelivery.Models
{
     public class Product
     {
          public int Id { get; set; }
          public string Image { get; set; }
          public string Name { get; set; }
          public string Description { get; set; }
          public double Price { get; set; }
          public int Quantity { get; set; }
          public EnumRule Rule { get; set; }
          public List<Ingredient> Ingredients { get; set; }
          public List<Extra> Extras { get; set; }
     }
}
