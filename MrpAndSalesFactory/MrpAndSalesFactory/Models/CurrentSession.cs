using System.Web;

namespace MrpAndSalesFactory.Models
{
    public class CurrentSession
    {
        public static Entity.Models.Users User
        {
            get
            {
                return Get<Entity.Models.Users>("login");
            }
        }
        public static T Get<T>(string key)
        {
            if (HttpContext.Current.Session[key] != null)
            {
                return (T)HttpContext.Current.Session[key];
            }
            return default(T);
        }
        public static void Remove(string key)
        {
            if (HttpContext.Current.Session[key] != null)
            {
                HttpContext.Current.Session.Remove(key);
            }
        }
        public static void Clear()
        {
            HttpContext.Current.Session.Clear();
        }
    }
}