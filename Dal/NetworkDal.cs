using Config;
using MySql.Data.MySqlClient;
using System;

namespace Dal
{
    public class NetworkDal
    {
        public static string Register(string openid, string appid, string userName, string password, string userPhoto, string money)
        {
            string guid = Guid.NewGuid().ToString();
            string sql = "insert into networkadmin(network,openid,appid,userName,password,userPhoto,tradeState,money)values(@network,@openid,@appid,@userName,@password,@userPhoto,@tradeState,@money)";

            MySqlParameter[] pa = {
                    new MySqlParameter("@network",guid),
                    new MySqlParameter("@openid",openid),
                    new MySqlParameter("@appid",appid),
                    new MySqlParameter("@userName",userName),
                    new MySqlParameter("@password",password),
                    new MySqlParameter("@userPhoto",userPhoto),
                    new MySqlParameter("@tradeState",1),
                    new MySqlParameter("@money",money)
            };
            if (MySqlHelper.ExecuteNonQuery(MySqlConfig.MySqlConnectionString, sql, pa) > 0)
            {
                return guid;
            }
            else {
                return "";
            }

        }
    }
}
