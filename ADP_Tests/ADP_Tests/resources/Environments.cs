using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADP_Tests;

namespace ADP_SeleniumFramework.resources
{
    public class Environments
    {
        public String URL;
        public enum Environment
        {
            dev, staging
        }

        public String getEnv(Environment env)
        {
            switch (env)
            {
                case Environment.dev:
                    URL = SmokeTestWindow.env;
                    break;
                case Environment.staging:
                    URL = SmokeTestWindow.env;
                    break;
            }
            return URL; 
        }
    }
}
