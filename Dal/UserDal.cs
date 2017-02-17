
using Config;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class UserDal
    {
        public static string Register(string openid, string appid, string userName, string userPhoto, string region, string gender, string network)
        {

            string userId = Guid.NewGuid().ToString();
            DateTime createTime = DateTime.Now;
            string sql = "insert into user(userId,openId,appId,userName,userPhoto,region,gender,network,createTime)values(@userId,@openId,@appId,@userName,@userPhoto,@region,@gender,@network,@createTime)";
            MySqlParameter[] pa = {
                    new MySqlParameter("@userId",userId),
                    new MySqlParameter("@openId",openid),
                    new MySqlParameter("@appId",appid),
                    new MySqlParameter("@userName",userId),
                    new MySqlParameter("@userPhoto",userPhoto),
                    new MySqlParameter("@region",region),
                    new MySqlParameter("@gender",gender),
                    new MySqlParameter("@network",network),
                    new MySqlParameter("@createTime",createTime)
            };
            if (MySqlHelper.ExecuteNonQuery(MySqlConfig.MySqlConnectionString, sql, pa) > 0)
            {
                return userId;
            }
            else {
                return "";
            }
        }
    }
}
