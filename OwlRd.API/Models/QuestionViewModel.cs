using System.Collections.Generic;

namespace OwlRd.API.Models
{
	public class QuestionViewModel
	{
		public QuestionViewModel(string text, List<QuestionAnswer> answers)
		{
			Text = text;
			Answers = answers;
		}

		public string Text { get; set; }
		public List<QuestionAnswer> Answers { get; set; }
	}

	public class QuestionAnswer
	{
		public QuestionAnswer(string text, bool isCorrect)
		{
			Text = text;
			IsCorrect = isCorrect;
		}

		public string Text { get; set; }
		public bool IsCorrect { get; set; }
	}
}