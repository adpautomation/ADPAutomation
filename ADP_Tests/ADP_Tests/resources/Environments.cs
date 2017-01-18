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
                    Url = TestCredentialsWindow.Env;
                    break;
                case Environment.Staging:
                    Url = TestCredentialsWindow.Env;
                    break;
            }
            return Url; 
        }
    }
}
