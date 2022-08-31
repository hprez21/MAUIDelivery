using MAUIDelivery.Enums;
using MAUIDelivery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIDelivery.Selectors
{
     public class ProductDataTemplateSelector : DataTemplateSelector
     {
protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
{
     var collection = container as CollectionView;

     if (container != null)
     {
          var product = item as BaseOptionsItem;
     if (product.Rule == EnumRule.None)
     {
          return (DataTemplate)collection.Resources["checkOption"];
     }
     else if (product.Rule == EnumRule.Min0_Max1)
     {
          return (DataTemplate)collection.Resources["checkOption"];
     }
     else if (product.Rule == EnumRule.Min1_Max1)
     {
          return (DataTemplate)collection.Resources["radioOption"];
     }
     else if (product.Rule == EnumRule.Max)
     {
          return (DataTemplate)collection.Resources["radioOption"];
     }
     }
     return null;
}
     }
}
