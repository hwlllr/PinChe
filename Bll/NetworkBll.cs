using Dal;
using Helper;
using Newtonsoft.Json;
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
            int error = 0;
            string networkId=NetworkDal.Register(openid, appid, userName, password, userPhoto, money);
            if (networkId == "")
            {
                error = 1;
            }
            var result = new
            {
                flag = 1,
                error = error,
                message = NetworkConfig.Message(error),
                data = networkId
            };
            return JsonConvert.SerializeObject(result);
        }
    }
}
