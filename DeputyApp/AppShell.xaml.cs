using DeputyApp.Pages;

namespace DeputyApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(SchedulePage), typeof(SchedulePage));
            Routing.RegisterRoute(nameof(DocumentsPage), typeof(DocumentsPage));
            Routing.RegisterRoute(nameof(NotificationsPage), typeof(NotificationsPage));
        }
    }
}
