namespace Examination_System.Models
{
    #region FinalExam Documentation
    /// <summary>
    /// Represents a final exam, displaying questions and results with user answers.
    /// </summary>
    #endregion
    public class FinalExam : Exam
    {
        #region Constructor Documentation
        /// <summary>
        /// Initializes a new instance of the FinalExam class.
        /// </summary>
        /// <param name="subject">The subject of the exam.</param>
        /// <param name="questions">The list of questions for the exam.</param>
        /// <param name="time">The duration of the exam in minutes.</param>
        #endregion

        // Creates a final exam
        public FinalExam(Subject subject, QuestionList questions, int time)
            : base(subject, questions, time)
        {
            #region Step 1: Initialize Base Class
            // Base class constructor handles initialization
            #endregion
        }

        #region ShowExam Documentation
        /// <summary>
        /// Displays the exam, collects user answers, and shows the final results with scores.
        /// </summary>
        #endregion

        // Conducts and displays the final exam results
        public override void ShowExam()
        {
            #region Step 1: Take Exam
            var userAnswers = TakeExam();
            #endregion

            #region Step 2: Calculate Score
            int score = CalculateScore(userAnswers);
            #endregion

            #region Step 3: Display Results
            Console.WriteLine("Final Exam Results:");
            foreach (var q in Questions)
            {
                Console.WriteLine(q.GetQuestionRepresentation());
                Console.WriteLine($"Your answer: {GetUserAnswerRepresentation(q, userAnswers[q])}");
                Console.WriteLine("-------------------");
            }
            Console.WriteLine($"Total Score: {score}");
            #endregion
        }
    }
}