using MrpAndSalesFactory.BusinessLayer.Abstract;
using MrpAndSalesFactory.BusinessLayer.Results;
using MrpAndSalesFactory.Common.Helpers;
using MrpAndSalesFactory.Entity.Models;
using MrpAndSalesFactory.Entity.ValueObject;

namespace MrpAndSalesFactory.BusinessLayer.User
{
    public class UserManager : ManagerBase<Users>
    {
        public BusinessLayerResult<Users> RegisterUser(FillUserObjectsLogin data)
        {
            Users user = Find(x => x.Username == data.Username || x.Pasword == data.Password);
            BusinessLayerResult<Users> res = new BusinessLayerResult<Users>();
            if (user != null)
            {
                if (user.Username == data.Username)
                {
                    res.AddError(Entity.Messages.ErrorMessageCode.UsernameAlreadyExists, "Kullanıcı adı kayıtlı");
                }

            }
            else
            {
                int dbResult = base.Insert(new Users()
                {
                    Username = data.Username,
                    Pasword = data.Password,
                    Access = "None",
                    HizliSatisYetki = false,
                    Sistemdurumu = true

                });
                if (dbResult > 0)
                {
                    res.Result = Find(x => x.Username == data.Username || x.Pasword == data.Password);
                    string siteUri = ConfigHelper.Get<string>("SitringUri");
                    string activateUri = $"{siteUri}/Home/UserActivate/{res.Result.Id}";
                    string body = $"Merhaba{res.Result.Username};<br><br>Hesabınızı aktifleştirmek için <a href='{activateUri}' target='_blank'>tıkla</a>.";

                }
            }

            return res;
        }
    }
}
