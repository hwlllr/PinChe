using Bll;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace PinCheApi.Controllers
{
    /// <summary>
    /// 用户相关API
    /// </summary>
    public class UserController : ApiController
    {
        /// <summary>
        /// 注册普通用户接口
        /// </summary>
        /// <param name="openid">微信openId</param>
        /// <param name="appid">微信appId</param>
        /// <param name="userName">用户名</param>
        /// <param name="userPhoto">头像</param>
        /// <param name="region">地区</param>
        /// <param name="gender">性别</param>
        /// <param name="network">所属网络</param>
        /// <returns>返回userId</returns>
        [HttpGet]
        public string Register(string openid,string appid,string userName,string userPhoto,string region,string gender,string network)
        {
            string result= UserBll.Register(openid, appid, userName, userPhoto, region, gender, network);
            return result;
        }
    }
}