using System;

namespace hrAPP.Helpers
{
    public class UserSession
    {
        private static String username;
        private static String password;

        public static void SetUser(String uname, String passwd)
        {
            username = uname;
            password = passwd;
        }

        public static String[] GetUser()
        {
            String[] userdata = new String[2];
            userdata[0] = username;
            userdata[1] = password;
            return userdata;
        }
    }
}
