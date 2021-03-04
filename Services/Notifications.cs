using Radzen;

namespace ControlDashboard.Services
{
    public class Notifications
    {
        private readonly NotificationService notification;

        public Notifications(NotificationService service)
        {
            notification = service;
        }

        public void Success(string message, int duration = 5000)
        {
            //notification.Notify(new NotificationMessage { Style = "position: relative; left:-500px; top:-115px", Severity = NotificationSeverity.Success, Summary = "Succes", Detail = message, Duration = duration });
        }

        public void Info(string message, int duration = 10000)
        {
            notification.Notify(new NotificationMessage { Style = "position: relative; left:-500px; top:-115px", Severity = NotificationSeverity.Info, Summary = "Info", Detail = message, Duration = duration });
        }

        public void Warning(string message, int duration = 10000)
        {
            notification.Notify(new NotificationMessage { Style = "position: relative; left:-500px; top:-115px", Severity = NotificationSeverity.Warning, Summary = "Warning", Detail = message, Duration = duration });
        }

        public void Error(string message, int duration = 10000)
        {
            notification.Notify(new NotificationMessage { Style = "position: relative; left:-500px; top:-115px", Severity = NotificationSeverity.Error, Summary = "Error", Detail = message, Duration = duration });
        }
    }
}
