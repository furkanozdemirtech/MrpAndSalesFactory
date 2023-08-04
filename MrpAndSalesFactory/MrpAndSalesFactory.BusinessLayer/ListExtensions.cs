using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.WebPages.Html;

namespace MrpAndSalesFactory.BusinessLayer
{
    public static class ListExtensions
    {
        public static List<SelectListItem> ToSelectList<T>(this List<T> list, string idPropertyName, string namePropertyName = "Name")
            where T : class, new()

        {
            List<SelectListItem> selectListItems = new List<SelectListItem>();

            list.ForEach(item =>
            {
                selectListItems.Add(new SelectListItem
                {
                    Text = item.GetType().GetProperty(namePropertyName).GetValue(item).ToString(),
                    Value = item.GetType().GetProperty(idPropertyName).GetValue(item).ToString()
                });
            });
            return selectListItems;
        }

        public static System.Web.Mvc.SelectList ToEnumSelectList<TEnum>(this TEnum obj)
            where TEnum : struct, IComparable, IFormattable, IConvertible
        {
            return new System.Web.Mvc.SelectList(Enum.GetValues(typeof(TEnum))
                .OfType<Enum>()
                .Select(X => new SelectListItem
                {
                    Text = Enum.GetName(typeof(TEnum), X),
                    Value = (Convert.ToInt32(X)).ToString()
                }), "Value", "Text");
        }





    }
}
