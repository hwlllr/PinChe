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
        /// 网络接口注册
        /// </summary>
        /// <returns></returns>
        public string Register(string openid="",string appid="",string userName="",string password="",string userPhoto="",string money="")
        {
            string result = NetworkBll.Register(openid, appid, userName, password, userPhoto, money);
            return result;
        }
    }
}