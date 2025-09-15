namespace Examination_System.Models
{
    #region Question Documentation
    /// <summary>
    /// Abstract base class for questions in the examination system.
    /// </summary>
    #endregion

    public abstract class Question
    {
        #region Header Documentation
        /// <summary>
        /// Gets the header of the question.
        /// </summary> 
        #endregion

        public string Header { get; private set; }

        #region Body Documentation
        /// <summary>
        /// Gets the body of the question.
        /// </summary> 
        #endregion

        public string Body { get; private set; }

        #region Marks Documentation
        /// <summary>
        /// Gets the marks awarded for the question.
        /// </summary> 
        #endregion

        public int Marks { get; private set; }

        #region Answers Documentation
        /// <summary>
        /// Gets the list of answer options for the question.
        /// </summary> 
        #endregion

        public AnswerList Answers { get; private set; } = new AnswerList();

        #region Constructor Documentation
        /// <summary>
        /// Initializes a new instance of the Question class.
        /// </summary>
        /// <param name="header">The question header.</param>
        /// <param name="body">The question body.</param>
        /// <param name="marks">The marks awarded for the question.</param>
        /// <exception cref="ArgumentException">Thrown if header or body is empty, or marks is not positive.</exception>
        #endregion

        // Initializes a question with header, body, and marks
        protected Question(string header, string body, int marks)
        {
            #region Step 1: Validate Inputs
            if (string.IsNullOrEmpty(header)) throw new ArgumentException("Header cannot be empty");
            if (string.IsNullOrEmpty(body)) throw new ArgumentException("Body cannot be empty");
            if (marks <= 0) throw new ArgumentException("Marks must be positive");
            #endregion

            #region Step 2: Initialize Properties
            Header = header;
            Body = body;
            Marks = marks;
            #endregion
        }

        #region GetQuestionRepresentation Documentation
        /// <summary>
        /// Returns a string representation of the question, including options.
        /// </summary>
        /// <returns>The formatted question string.</returns>
        #endregion

        // Formats the question for display
        public abstract string GetQuestionRepresentation();

        #region CheckAnswer Documentation
        /// <summary>
        /// Checks if the provided answer is correct.
        /// </summary>
        /// <param name="userAnswer">The user's answer.</param>
        /// <returns>True if the answer is correct, false otherwise.</returns>
        #endregion

        // Verifies the user's answer
        public abstract bool CheckAnswer(object userAnswer);

        #region GetCorrectAnswerRepresentation Documentation
        /// <summary>
        /// Returns a string representation of the correct answer(s).
        /// </summary>
        /// <returns>The formatted correct answer string.</returns>
        #endregion

        // Formats the correct answer(s) for display
        public abstract string GetCorrectAnswerRepresentation();

        #region ToString Documentation
        /// <summary>
        /// Returns the string representation of the question.
        /// </summary>
        /// <returns>The formatted question string.</returns>
        #endregion

        // Returns the question representation as a string
        public override string ToString()
        {
            #region Step 1: Return Question Representation
            return GetQuestionRepresentation();
            #endregion
        }
    }
}