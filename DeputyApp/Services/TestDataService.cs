using DeputyApp.Models;

namespace DeputyApp.Services
{
    public static class TestDataService
    {
        public static DeputyModel GetDeputy()
        {
            return new DeputyModel
            {
                Id = 1,
                FirstName = "Иван",
                LastName = "Петров",
                Position = "Депутат Екатеринбургской городской Думы",
                Email = "ivan.petrov@egd.ru"
            };
        }

        public static List<EventModel> GetSchedule()
        {
            return new List<EventModel>
            {
                new EventModel { Id = 1, Title = "Заседание комиссии по финансам", Location = "Зал №3", StartTime = DateTime.Today.AddHours(10), EndTime = DateTime.Today.AddHours(12) },
                new EventModel { Id = 2, Title = "Работа с избирателями", Location = "Офис №5", StartTime = DateTime.Today.AddDays(1).AddHours(14), EndTime = DateTime.Today.AddDays(1).AddHours(16) }
            };
        }

        public static List<DocumentModel> GetDocuments()
        {
            return new List<DocumentModel>
            {
                new DocumentModel { Id = 1, Title = "Проект бюджета на 2025 год", FilePath = "budget2025.pdf", UploadedAt = DateTime.Today.AddDays(-5) },
                new DocumentModel { Id = 2, Title = "Протокол заседания №12", FilePath = "protocol12.pdf", UploadedAt = DateTime.Today.AddDays(-2) }
            };
        }
    }
}
