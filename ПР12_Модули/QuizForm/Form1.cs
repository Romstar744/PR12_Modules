using Task;
using Quiz;

namespace QuizForm
{
	public partial class Form1 : Form
	{
		private Testing testing;
		public Form1()
		{
			InitializeComponent();
			InitializeTesting();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			int selectedAnswerIndex = GetSelectedAnswerIndex();
			testing.ProcessAnswer(selectedAnswerIndex);
			ShowNextQuestion();
		}

		private void InitializeTesting()
		{
			testing = new Testing();
			ShowNextQuestion();
		}

		private void ShowNextQuestion()
		{
			if (testing.HasNextQuestion())
			{
				SingleTest currentQuestion = testing.GetNextQuestion();
				DisplayQuestion(currentQuestion);
			}
			else
			{
				ShowQuizResult();
			}
		}

		private void DisplayQuestion(SingleTest question)
		{
			label1.Text = question.Question;

			radioButton1.Text = question.Answers[0];
			radioButton2.Text = question.Answers[1];
			radioButton3.Text = question.Answers[2];
		}

		private void ShowQuizResult()
		{
			string resultMessage = testing.GetQuizResult();
			MessageBox.Show(resultMessage, "Результат опроса ");
			Application.Exit();
		}


		private int GetSelectedAnswerIndex()
		{
			if (radioButton1.Checked) return 0;
			if (radioButton2.Checked) return 1;
			if (radioButton3.Checked) return 2;
			return -1;
		}

	}
}
