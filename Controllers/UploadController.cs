using ClientProjetDomLog.CUC;
using ClientProjetDomLog.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientProjetDomLog.CUT
{
    public static class UploadController
    {
        public static void Upload(FileData filedata1, FileData filedata2)
        {
            object[] data = { (object)filedata1, (object)filedata2 };
            Message message = new Message();
            message.Info = "Request to decrypt files.";
            message.OperationName = "decrypt";
            message.OperationVersion = "1";
            message.AppVersion = "1";
            message.Data = data;
            message.TokenUser = LoginController.UserToken;
            message.TokenApp = LoginController.AppToken;

            var answer = ServerController.SendMessage(message);
        }
    }
}
