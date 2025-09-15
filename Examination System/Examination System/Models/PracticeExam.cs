namespace Examination_System.Models
{
    #region PracticeExam Documentation
    /// <summary>
    /// Represents a practice exam, displaying questions and results with feedback on incorrect answers.
    /// </summary>
    #endregion

    public class PracticeExam : Exam
    {
        #region Constructor Documentation
        /// <summary>
        /// Initializes a new instance of the PracticeExam class.
        /// </summary>
        /// <param name="subject">The subject of the exam.</param>
        /// <param name="questions">The list of questions for the exam.</param>
        /// <param name="time">The duration of the exam in minutes.</param>
        #endregion

        // Creates a practice exam
        public PracticeExam(Subject subject, QuestionList questions, int time)
            : base(subject, questions, time)
        {
            #region Step 1: Initialize Base Class
            // Base class constructor handles initialization
            #endregion
        }

        #region ShowExam Documentation
        /// <summary>
        /// Displays the exam, collects user answers, and shows results with feedback for incorrect answers.
        /// </summary>
        #endregion

        // Conducts and displays the practice exam results
        public override void ShowExam()
        {
            #region Step 1: Take Exam
            var userAnswers = TakeExam();
            #endregion

            #region Step 2: Calculate Score
            int score = CalculateScore(userAnswers);
            #endregion

            #region Step 3: Display Results with Feedback
            Console.WriteLine("Practice Exam Results:");
            foreach (var q in Questions)
            {
                bool isCorrect = q.CheckAnswer(userAnswers[q]);
                if (!isCorrect)
                {
                    Console.WriteLine($"Wrong answer for: {q.Body}");
                    Console.WriteLine($"Your answer: {GetUserAnswerRepresentation(q, userAnswers[q])}");
                    Console.WriteLine($"Correct answer: {q.GetCorrectAnswerRepresentation()}");
                }
            }
            Console.WriteLine($"Total Score: {score}");
            #endregion
        }
    }
}