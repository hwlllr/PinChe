using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class NetworkBll
    {
        public static string Register(string openid, string appid, string userName, string password, string userPhoto, string money)
        {
            NetworkDal.Register(openid, appid, userName, password, userPhoto, money);
        }
    }
}
