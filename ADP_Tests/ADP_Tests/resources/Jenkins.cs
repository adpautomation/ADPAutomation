using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADP_Tests.resources
{
    public class Jenkins
    {
        public static string Browser = System.Environment.GetEnvironmentVariable("Browser");
        public static string Environment = System.Environment.GetEnvironmentVariable("Environment");
        public static string Impersonate = System.Environment.GetEnvironmentVariable("User to impersonate");


        public static string Env()
        {
            if (Environment.Equals("prod"))
            {
                Environment = "http://bsg-mobile-prod/dist/#/lobby";
            }
            else if (Environment.Equals("dev"))
            {
                Environment = "http://bsg-mobile-dev/dist/#/lobby";
            }
            else if (Environment.Equals("staging"))
            {
                Environment = "http://bsg-mobile-staging/dist/#/lobby";
            }
            return Environment;
        }
    }
}
