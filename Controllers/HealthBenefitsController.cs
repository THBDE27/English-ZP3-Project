
using English_ZP3_Project.Helpers;
using English_ZP3_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace English_ZP3_Project.Controllers
{
    public class HealthBenefitsController : Controller
    {
        private readonly QuizHelper _quizHelper;

        public HealthBenefitsController(QuizHelper quizHelper)
        {
            _quizHelper = quizHelper;
        }

        public IActionResult Benefits()
        {
            var questions = _quizHelper.GetAllQuestions();
            return View("~/Views/Biology/Benefits.cshtml", questions);
        }

        [HttpPost]
        public IActionResult CheckAnswer([FromBody] AnswerRequest request)
        {
            var question = _quizHelper.GetAllQuestions()
                                      .FirstOrDefault(q => q.Id == request.QuestionId);

            bool correct = question != null && question.CorrectOption == request.SelectedOption;

            return Json(new { correct, explanation = question?.Explanation ?? "" });
        }

    }
}
