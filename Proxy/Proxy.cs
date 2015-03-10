using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Proxy : IServer
    {
        private Server hiddenServer = new Server();
        private Boolean isAuthenticated = false;
        public String Authenticate(String username, String password)
        {
            if (username == "user" && password == "password")
            {
                isAuthenticated = true;
                return "Authorization Granted.";
            }
            else
            {
                return "Authorization Denied.";
            }
        }

        public String Request()
        {
            if (isAuthenticated)
            {
                return hiddenServer.Request();
            }
            else
            {
                return "Operation not Authorized. Authenticate First";
            }
        }

       
    }
}
