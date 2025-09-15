using System.Text;

namespace Examination_System.Models
{
    #region ChooseOneQuestion Documentation
    /// <summary>
    /// Represents a multiple-choice question with a single correct answer.
    /// </summary>
    #endregion

    public class ChooseOneQuestion : Question
    {
        #region Properties Documentation
        /// <summary>
        /// Gets the index of the correct answer option.
        /// </summary>
        #endregion

        public int CorrectIndex { get; private set; }

        #region Constructor Documentation
        /// <summary>
        /// Initializes a new instance of the ChooseOneQuestion class.
        /// </summary>
        /// <param name="header">The question header.</param>
        /// <param name="body">The question body.</param>
        /// <param name="marks">The marks awarded for the question.</param>
        /// <param name="options">The list of answer options.</param>
        /// <param name="correctOptionIndex">The index of the correct option.</param>
        /// <exception cref="ArgumentException">Thrown if options are invalid or correct index is invalid.</exception>
        #endregion

        // Creates a choose-one question with a single correct answer
        public ChooseOneQuestion(string header, string body, int marks, List<string> options, int correctOptionIndex)
            : base(header, body, marks)
        {
            #region Step 1: Validate Inputs
            if (options == null || options.Count < 2) throw new ArgumentException("At least two options required");
            if (correctOptionIndex < 0 || correctOptionIndex >= options.Count)
                throw new ArgumentException("Invalid correct option index");
            #endregion

            #region Step 2: Initialize Answers
            foreach (var opt in options)
            {
                Answers.Add(new Answer(opt));
            }
            #endregion

            #region Step 3: Set Correct Index
            CorrectIndex = correctOptionIndex;
            #endregion
        }

        #region GetQuestionRepresentation Documentation
        /// <summary>
        /// Returns a string representation of the question, including options.
        /// </summary>
        /// <returns>The formatted question string.</returns>
        #endregion

        // Formats the question for display
        public override string GetQuestionRepresentation()
        {
            #region Step 1: Build Question String
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Header);
            sb.AppendLine(Body);
            #endregion

            #region Step 2: Append Answer Options
            char optionLetter = 'A';
            foreach (var ans in Answers)
            {
                sb.AppendLine($"{optionLetter}) {ans}");
                optionLetter++;
            }
            #endregion

            #region Step 3: Append Marks and Return
            sb.AppendLine($"[Marks: {Marks}]");
            return sb.ToString();
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