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

		public Testing()
		{
			questions = Task.Task.AllQuestions;
			currentQuestionIndex = 0;
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
				// Ваш код для обработки баллов (если необходимо)
			}
		}

		public string GetQuizResult()
		{
			// Ваш код для обработки и вывода результатов теста
			return "Результат теста";
		}
		/*public string DoTesting()
		{
			int SumBal = 0;
			int ans = 0;

			foreach (Task.SingleTest p in Task.Task.AllQuestions)
			{
                Console.WriteLine("//////////////////////////");
				Console.WriteLine(p.Question);
                Console.WriteLine("//////////////////////////");
                Console.WriteLine("1. " + p.Answers[0]);
				Console.WriteLine("2. " + p.Answers[1]);
                Console.WriteLine("3. " + p.Answers[2]);
				Console.Write("Выберите номер ответа > ");
				ans = Convert.ToInt32(Console.ReadLine());
				SumBal += p.Balls[ans-1];
            }

			return Result.Result.GetMessage(SumBal);
		}*/	
	}
}
