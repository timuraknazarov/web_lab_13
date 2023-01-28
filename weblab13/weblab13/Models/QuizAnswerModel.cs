using lab2_3.Utils;

namespace lab2_3.Models
{
    public class QuizAnswerModel
    {
        [LessThanOrNull(101, ErrorMessage = "Здесь не может быть такого большого числа")]
        public int? Answer { get; set; }
    }
}
