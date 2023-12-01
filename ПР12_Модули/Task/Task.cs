using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    // Класс для представления одного тествого задания
    public class SingleTest
    {
        public string Question { get; set; } // вопрос
        public List<string> Answers; // Ответы
        public List<int> Balls; // Баллы за ответы
    }

    // Статический класс для представления для инициализации коллекции
    public static class Task
    {
        // Список отдельных вопросов с ответами
        public static List<SingleTest> AllQuestions;

        // Статический конструктор для инициализации коллекции
        static Task()
        {
            AllQuestions = new List<SingleTest>()
            {
                new SingleTest()
                {
                    Question = "Main - точка входа программы...",
                    Answers = new List<string>() { "1", "7", "Не знаю" },
                    Balls = new List<int> { 20, 5, 0}
                },
                new SingleTest()
                {
                    Question = "Какой оператор не является оператором цикла?",
                    Answers = new List<string>() { "while", "for", "if" },
                    Balls = new List<int> { -5, 0, 10}
                },
                new SingleTest()
                {
                    Question = "Как обозначить составной оператор? ",
                    Answers = new List<string>() { "{ ... }", "( ... )", "< ... >" },
                    Balls = new List<int> { 50, 0, 0}
                },
                new SingleTest()
                {
                    Question = "Что обозначает символ ;",
                    Answers = new List<string>() { "Пустой оператор", "Конец программы", "Не знаю" },
                    Balls = new List<int> { 20, 5, 0}
                },
				new SingleTest()
				{
					Question = "Когда необходимо составлять блок-схему программы?",
					Answers = new List<string>() { "До начала составления самой программы", "В процессе составления программы", "После составления программы" },
					Balls = new List<int> { 40, -5, -15}
				},
				new SingleTest()
				{
					Question = "Символьный тип данных объявляется служебным словом",
					Answers = new List<string>() { "STRING", "WORD", "CHAR" },
					Balls = new List<int> { -10, -5, 15}
				}
			};
		}
    }
}
