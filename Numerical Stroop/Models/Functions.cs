using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Numerical_Stroop.Models
{
    public class Functions
    {
        public static Progress CorrectPage(int workerId)
        {
            return Progress.Consent;
        }

        public static string GoToCorrectPage(int? workerId)
        {
            if (workerId == null)
            {
                return "~/";
            }

            return "";
        }

        public static string GetUserIP()
        {
            string ipList = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (!string.IsNullOrEmpty(ipList))
            {
                return ipList.Split(',')[0];
            }
            
            return HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
        }

        public static Group? GetUserGroup(int userId)
        {
            using (var db = new DB())
            {
                var user = db.WorkerIds.SingleOrDefault(m => m.Id == userId);
                if (user == null)
                {
                    return null;
                }
                else
                {
                    return user.Group;
                }
            }
        }

    }
}