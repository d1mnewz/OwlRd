using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OwlRd.API.Controllers.Common;
using OwlRd.API.Models;

namespace OwlRd.API.Controllers
{
	public class QuestionsController : ApiController
	{
		[HttpGet, Route("")]
		public QuestionViewModel GetQuestions()
		{
			return new QuestionViewModel("What Alice have done at that moment?",
				new List<QuestionAnswer>
				{
					new QuestionAnswer("Nothing", false),
					new QuestionAnswer("Ran back", false),
					new QuestionAnswer("Thrown it away", false),
					new QuestionAnswer("Ate it", true)
				});
		}
	}
}