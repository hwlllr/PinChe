using Bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PinCheApi.Controllers
{
    /// <summary>
    /// 网络相关API
    /// </summary>
    public class NetworkController : Controller
    {
        /// <summary>
        /// 注册网络接口
        /// </summary>
        /// <param name="openid">openid</param>
        /// <param name="appid">appid</param>
        /// <param name="userName">账号</param>
        /// <param name="password">密码</param>
        /// <param name="userPhoto">用户头像</param>
        /// <param name="money">交易金额</param>
        /// <returns>返回networkId</returns>
        [HttpGet]
        public string Register(string openid="",string appid="",string userName="",string password="",string userPhoto="",string money="")
        {
            string result = NetworkBll.Register(openid, appid, userName, password, userPhoto, money);
            return result;
        }
    }
}