using Microsoft.Azure.NotificationHubs;

namespace NotificacaoWebApp.Models
{
    public class Notifications
    {
        public static Notifications Instance = new Notifications();

        public NotificationHubClient Hub { get; set; }

        private Notifications()
        {
            Hub = NotificationHubClient.CreateClientFromConnectionString("Endpoint=sb://notificacaonamespace.servicebus.windows.net/;SharedAccessKeyName=DefaultFullSharedAccessSignature;SharedAccessKey=J1bH8wy+DJoKuD+HS1Z3BqmYeP51r1KlEY/5WN9RBc8=",
                                                                         "Notificacao");
        }
    }
}