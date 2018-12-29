using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind.Common
{
    public class CoreConstants
    {
        public static string NewsSearchApiKey
        {
            get { return "[YOUR MSFT CG NEWS SEARCH API KEY]"; }
        }

        public static string ApplicationURL = @"https://[your azure mobile app].azurewebsites.net";
        public static string FirebaseSenderId = "[YOUR FIREBASE SENDER ID]";
    }
}
