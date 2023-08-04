using MrpAndSalesFactory.BusinessLayer.Kategories;
using System.Collections.Generic;
using System.Web.Helpers;

namespace MrpAndSalesFactory.Models
{
    public class CacheHelper
    {
        public static List<Entity.Models.UrtKategoriUstGrup> GetCategoriesFromCache()
        {
            var result = WebCache.Get("category-cache");
            if (result == null)
            {
                UrtKategoriUstGrupManager catgoryManager = new UrtKategoriUstGrupManager();
                result = catgoryManager.List();

            }
            return result;
        }
        public static void RemoveCategoriesFromCache()
        {
            Remove("category-cache");
        }
        public static void Remove(string key)
        {
            WebCache.Remove(key);
        }
    }
}