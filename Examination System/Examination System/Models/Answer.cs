namespace Examination_System.Models
{
    #region Answer Documentation
    /// <summary>
    /// Represents an answer option for a question in the examination system.
    /// </summary>
    #endregion

    public class Answer
    {
        #region Properties Documentation
        /// <summary>
        /// Gets the text of the answer.
        /// </summary>
        #endregion

        public string Text { get; private set; }

        #region Constructor Documentation
        /// <summary>
        /// Initializes a new instance of the Answer class with the specified text.
        /// </summary>
        /// <param name="text">The text of the answer.</param>
        #endregion

        // Creates an answer with given text
        public Answer(string text)
        {
            #region Step 1: Set Text
            Text = text;
            #endregion
        }

        #region ToString Documentation
        /// <summary>
        /// Returns the text of the answer as a string.
        /// </summary>
        /// <returns>The answer text.</returns>
        #endregion

        // Converts answer to string representation
        public override string ToString()
        {
            #region Step 1: Return Text
            return Text;
            #endregion
        }
    }
}