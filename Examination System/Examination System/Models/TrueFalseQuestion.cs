namespace Examination_System.Models
{
    #region TrueFalseQuestion Documentation
    /// <summary>
    /// Represents a true/false question with a single correct answer.
    /// </summary>
    #endregion
    public class TrueFalseQuestion : Question
    {
        #region CorrectIndex Documentation
        /// <summary>
        /// Gets the index of the correct answer (0 for True, 1 for False).
        /// </summary>
        #endregion

        public int CorrectIndex { get; private set; }

        #region Constructor Documentation
        /// <summary>
        /// Initializes a new instance of the TrueFalseQuestion class.
        /// </summary>
        /// <param name="header">The question header.</param>
        /// <param name="body">The question body.</param>
        /// <param name="marks">The marks awarded for the question.</param>
        /// <param name="correctAnswer">True if the correct answer is "True", false if "False".</param>
        #endregion

        // Creates a true/false question
        public TrueFalseQuestion(string header, string body, int marks, bool correctAnswer)
            : base(header, body, marks)
        {
            #region Step 1: Add Answer Options
            Answers.Add(new Answer("True"));
            Answers.Add(new Answer("False"));
            #endregion

            #region Step 2: Set Correct Index
            CorrectIndex = correctAnswer ? 0 : 1;
            #endregion
        }

        #region GetQuestionRepresentation Documentation
        /// <summary>
        /// Returns a string representation of the true/false question.
        /// </summary>
        /// <returns>The formatted question string.</returns>
        #endregion

        // Formats the question for display
        public override string GetQuestionRepresentation()
        {
            #region Step 1: Build Question String
            return $"{Header}\n{Body}\nA) {Answers[0]}\nB) {Answers[1]}\n[Marks: {Marks}]";
            #endregion
        }

        #region CheckAnswer Documentation
        /// <summary>
        /// Checks if the provided answer matches the correct index.
        /// </summary>
        /// <param name="userAnswer">The user's selected answer index.</param>
        /// <returns>True if the answer matches the correct index, false otherwise.</returns>
        #endregion

        // Verifies the user's answer
        public override bool CheckAnswer(object userAnswer)
        {
            #region Step 1: Validate and Compare Answer
            if (userAnswer is int i && i >= 0 && i < Answers.Count)
            {
                return i == CorrectIndex;
            }
            return false;
            #endregion
        }

        #region GetCorrectAnswerRepresentation Documentation
        /// <summary>
        /// Returns a string representation of the correct answer.
        /// </summary>
        /// <returns>The formatted correct answer string.</returns>
        #endregion

        // Formats the correct answer for display
        public override string GetCorrectAnswerRepresentation()
        {
            #region Step 1: Format Correct Answer
            char letter = (char)('A' + CorrectIndex);
            return $"{letter}) {Answers[CorrectIndex]}";
            #endregion
        }
    }
}