using System.Text;

namespace Examination_System.Models
{
    #region ChooseAllQuestion Documentation
    /// <summary>
    /// Represents a multiple-choice question where multiple answers can be correct.
    /// </summary>
    #endregion

    public class ChooseAllQuestion : Question
    {
        #region Properties Documentation
        /// <summary>
        /// Gets the indices of the correct answer options.
        /// </summary>
        #endregion

        public List<int> CorrectIndices { get; private set; }

        #region Constructor Documentation
        /// <summary>
        /// Initializes a new instance of the ChooseAllQuestion class.
        /// </summary>
        /// <param name="header">The question header.</param>
        /// <param name="body">The question body.</param>
        /// <param name="marks">The marks awarded for the question.</param>
        /// <param name="options">The list of answer options.</param>
        /// <param name="correctOptionIndices">The indices of the correct options.</param>
        /// <exception cref="ArgumentException">Thrown if options are invalid or correct indices are invalid.</exception>
        #endregion

        // Creates a choose-all question with multiple correct answers
        public ChooseAllQuestion(string header, string body, int marks, List<string> options, List<int> correctOptionIndices)
            : base(header, body, marks)
        {
            #region Step 1: Validate Inputs
            if (options == null || options.Count < 2) throw new ArgumentException("At least two options required");
            if (correctOptionIndices == null || !correctOptionIndices.Any())
                throw new ArgumentException("At least one correct option required");
            if (correctOptionIndices.Any(i => i < 0 || i >= options.Count))
                throw new ArgumentException("Invalid correct option index");
            #endregion

            #region Step 2: Initialize Answers
            foreach (var opt in options)
            {
                Answers.Add(new Answer(opt));
            }
            #endregion

            #region Step 3: Set Correct Indices
            CorrectIndices = correctOptionIndices;
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
            sb.AppendLine("Select all that apply:");
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
        /// Checks if the provided answer matches the correct indices.
        /// </summary>
        /// <param name="userAnswer">The user's selected answer indices.</param>
        /// <returns>True if the answer matches the correct indices, false otherwise.</returns>
        #endregion

        // Verifies the user's answer
        public override bool CheckAnswer(object userAnswer)
        {
            #region Step 1: Validate and Compare Answer
            if (userAnswer is List<int> l)
            {
                var sortedL = l.OrderBy(x => x).ToList();
                var sortedCorrect = CorrectIndices.OrderBy(x => x).ToList();
                return sortedL.SequenceEqual(sortedCorrect);
            }
            return false;
            #endregion
        }

        #region GetCorrectAnswerRepresentation Documentation
        /// <summary>
        /// Returns a string representation of the correct answers.
        /// </summary>
        /// <returns>The formatted correct answers string.</returns>
        #endregion

        // Formats the correct answers for display
        public override string GetCorrectAnswerRepresentation()
        {
            #region Step 1: Format Correct Answers
            var sorted = CorrectIndices.OrderBy(i => i);
            return string.Join(", ", sorted.Select(i => $"{(char)('A' + i)}) {Answers[i]}"));
            #endregion
        }
    }
}