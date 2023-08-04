using System.Collections.Generic;
using System.Web.Mvc;

namespace MrpAndSalesFactory.BusinessLayer.ManagerTools
{
    public class GenericOptionsManager<T>
    {
        public T Value { get; set; }
        public List<SelectListItem> Items { get; set; }


    }
}
