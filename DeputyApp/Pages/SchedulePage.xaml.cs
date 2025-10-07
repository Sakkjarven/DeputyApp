using DeputyApp.Services;

namespace DeputyApp.Pages
{
    public partial class SchedulePage : ContentPage
    {
        public SchedulePage()
        {
            InitializeComponent();
            ScheduleList.ItemsSource = TestDataService.GetSchedule();
        }
    }
}
