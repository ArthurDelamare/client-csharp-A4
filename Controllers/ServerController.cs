using ClientProjetDomLog.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientProjetDomLog.Controllers
{
    public static class ServerController
    {
        private static ServerClient client = new ServerClient();

        public static Message SendMessage(Message message)
        {
            return client.Process(message);
        }
    }
}
