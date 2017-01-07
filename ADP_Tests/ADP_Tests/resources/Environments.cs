using System;

namespace ADP_Tests.resources
{
    public class Environments
    {
        public String Url;
        public enum Environment
        {
            Dev, Staging
        }

        public String GetEnv(Environment env)
        {
            switch (env)
            {
                case Environment.Dev:
                    Url = SmokeTestWindow.Env;
                    break;
                case Environment.Staging:
                    Url = SmokeTestWindow.Env;
                    break;
            }
            return Url; 
        }
    }
}
