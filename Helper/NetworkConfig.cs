using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
   public class NetworkConfig
    {
        public static string Message(int val)
        {
            string message = "";
            switch (val)
            {
                case 1:
                    message = "注册失败";
                    break;
                case 2:
                    break;
                default:
                    message = "注册成功";
                    break;
            }
            return message;
        }
    }
}
