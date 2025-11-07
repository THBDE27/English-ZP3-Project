using System.Text.Json;
using English_ZP3_Project.Models;

namespace English_ZP3_Project.Helpers
{
    public class QuizHelper
    {
        private readonly string _filePath;

        public QuizHelper(IWebHostEnvironment env)
        {
            _filePath = Path.Combine(env.WebRootPath, "data", "healthBenefits.json");
        }

        public List<Question> GetAllQuestions()
        {
            if (!File.Exists(_filePath))
                return new List<Question>(); // File not found, returns empty list

            var json = File.ReadAllText(_filePath);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var questions = JsonSerializer.Deserialize<List<Question>>(json, options);

            return questions ?? new List<Question>();
        }

    }
}
