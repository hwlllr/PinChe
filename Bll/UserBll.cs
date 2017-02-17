using Config;
using Dal;
using Newtonsoft.Json;
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
            int error = 0;
            string userid=UserDal.Register(openid, appid, userName, userPhoto, region, gender, network);
            if (userid == "")
            {
                error = 1;
            }
            var result = new
            {
                flag = 1,
                error = error,
                message =UserConfig.Message(error),
                data = userid
            };
            return JsonConvert.SerializeObject(result);
        }
    }
}
