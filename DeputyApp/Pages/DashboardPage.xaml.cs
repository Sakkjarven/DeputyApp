namespace DeputyApp.Pages
{
    public partial class DashboardPage : ContentPage
    {
        public DashboardPage()
        {
            InitializeComponent(); // <- ошибка? значит проблема с генерацией
        }
        private async void GoToSchedule(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("SchedulePage");
        }

        private async void GoToDocuments(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("DocumentsPage");
        }

        private async void GoToNotifications(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("NotificationsPage");
        }

        private async void Logout(object sender, EventArgs e)
        {
            // Пока просто возвращаем на страницу логина
            await Shell.Current.GoToAsync("LoginPage");
        }
    }
}
