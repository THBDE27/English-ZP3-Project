using System.ComponentModel.DataAnnotations;

namespace English_ZP3_Project.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; } = "";
        public List<string> Options { get; set; } = new List<string>();
        public int CorrectOption { get; set; } // 0-based index
        public string Explanation { get; set; } = "";
    }


    public class AnswerRequest
    {
        public int QuestionId { get; set; }
        public int SelectedOption { get; set; }
    }

}
