using ClientProjetDomLog.ServiceReference1;

namespace ClientProjetDomLog.CUC
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
