using Bll;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace PinCheApi.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        public string Register(string openid,string appid,string userName,string userPhoto,string region,string gender,string network)
        {
            string userid= UserBll.Register(openid, appid, userName, userPhoto, region, gender, network);
            return JsonConvert.SerializeObject(userid);
        }
    }
}