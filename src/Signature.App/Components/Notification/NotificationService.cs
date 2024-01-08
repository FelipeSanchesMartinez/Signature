namespace Signature.App.Components.Notification
{
    public class NotificationService
    {
        public event Action<string, string, NotificationType> OnNotify;

        public async void Notify(string message, string title = "", NotificationType type = NotificationType.Info)
        {
          
            OnNotify?.Invoke(message, title, type);
            await Task.Delay(3000);
            ClearNotification();
        }

    public void ClearNotification()
    {
        OnNotify?.Invoke(null, null, NotificationType.Info);
    }
}
}
