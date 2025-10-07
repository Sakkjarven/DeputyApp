using DeputyApp.Services;

namespace DeputyApp.Pages
{
    public partial class DocumentsPage : ContentPage
    {
        public DocumentsPage()
        {
            InitializeComponent();
            DocsList.ItemsSource = TestDataService.GetDocuments();
        }
    }
}
