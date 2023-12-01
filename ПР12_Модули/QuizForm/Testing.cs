using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task;

namespace Quiz
{
	class Testing
	{
		private List<SingleTest> questions;
		private int currentQuestionIndex;
		private int totalPoints;

		public Testing()
		{
			questions = Task.Task.AllQuestions;
			currentQuestionIndex = 0;
			totalPoints = 0;
		}

		public bool HasNextQuestion()
		{
			return currentQuestionIndex < questions.Count;
		}

		public SingleTest GetNextQuestion()
		{
			if (HasNextQuestion())
			{
				SingleTest nextQuestion = questions[currentQuestionIndex];
				currentQuestionIndex++;
				return nextQuestion;
			}
			return null;
		}

		public void ProcessAnswer(int selectedAnswerIndex)
		{
			if (selectedAnswerIndex >= 0 && selectedAnswerIndex < questions[currentQuestionIndex - 1].Balls.Count)
			{
				int points = questions[currentQuestionIndex - 1].Balls[selectedAnswerIndex];
				totalPoints += points;
				// Ваш код для обработки баллов (если необходимо)
			}
		}

		public string GetQuizResult()
		{
			
				return Result.Result.GetMessage(totalPoints);
		}
	}
}
