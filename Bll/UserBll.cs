using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class UserBll
    {
        public static string Register(string openid, string appid, string userName, string userPhoto, string region, string gender, string network)
        {
            return UserDal.Register(openid, appid, userName, userPhoto, region, gender, network);
        }
    }
}
