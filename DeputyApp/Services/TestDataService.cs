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
                FirstName = "����",
                LastName = "������",
                Position = "������� ���������������� ��������� ����",
                Email = "ivan.petrov@egd.ru"
            };
        }

        public static List<EventModel> GetSchedule()
        {
            return new List<EventModel>
            {
                new EventModel { Id = 1, Title = "��������� �������� �� ��������", Location = "��� �3", StartTime = DateTime.Today.AddHours(10), EndTime = DateTime.Today.AddHours(12) },
                new EventModel { Id = 2, Title = "������ � ������������", Location = "���� �5", StartTime = DateTime.Today.AddDays(1).AddHours(14), EndTime = DateTime.Today.AddDays(1).AddHours(16) }
            };
        }

        public static List<DocumentModel> GetDocuments()
        {
            return new List<DocumentModel>
            {
                new DocumentModel { Id = 1, Title = "������ ������� �� 2025 ���", FilePath = "budget2025.pdf", UploadedAt = DateTime.Today.AddDays(-5) },
                new DocumentModel { Id = 2, Title = "�������� ��������� �12", FilePath = "protocol12.pdf", UploadedAt = DateTime.Today.AddDays(-2) }
            };
        }
    }
}
