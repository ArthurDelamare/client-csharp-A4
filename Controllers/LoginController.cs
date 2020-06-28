using ClientProjetDomLog.Controllers;
using ClientProjetDomLog.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientProjetDomLog.CUT
{
    public static class LoginController
    {
        public static string UserToken = "";
        public static string AppToken = "Client123";

        public static bool Authenticate(string username, string password)
        {
            var message2 = new Message();
            message2.OperationName = "authenticate";
            message2.OperationVersion = "1";
            message2.TokenApp = AppToken;

            Credentials credentials = new Credentials()
            {
                Username = username,
                Password = password
            };
            object[] data = { credentials };
            message2.Data = data;

            bool valid = false;

            var answer = ServerController.SendMessage(message2);

            try
            {
                valid = (bool)answer.Data[0];
                UserToken = (string)answer.Data[1];
            }
            catch
            {
                Console.WriteLine("Error while parsing login answer");
            }

            return valid;
        }
    }
}
