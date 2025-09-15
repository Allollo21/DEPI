using System.Text;

namespace Examination_System.Models
{
    #region QuestionList Documentation
    /// <summary>
    /// Represents a list of questions with logging functionality to a file.
    /// </summary>
    #endregion

    public class QuestionList : List<Question>
    {
        #region LogFile Documentation
        /// <summary>
        /// Gets or sets the file path for logging questions.
        /// </summary>
        #endregion

        public string LogFile { get; set; }

        #region Constructor Documentation
        /// <summary>
        /// Initializes a new instance of the QuestionList class with a specified log file.
        /// </summary>
        /// <param name="logFile">The file path for logging questions.</param>
        #endregion

        // Initializes a question list with a log file
        public QuestionList(string logFile)
        {
            #region Step 1: Initialize Log File
            LogFile = logFile;
            #endregion

            #region Step 2: Load Questions
            LoadExistingQuestions();
            #endregion
        }

        #region Add Documentation
        /// <summary>
        /// Adds a question to the list and logs it to the file.
        /// </summary>
        /// <param name="question">The question to add.</param>
        #endregion

        // Adds and logs a question
        public new void Add(Question question)
        {
            #region Step 1: Add to Base List
            base.Add(question);
            #endregion

            #region Step 2: Log Question
            LogQuestion(question);
            #endregion
        }

        #region LogQuestion Documentation
        /// <summary>
        /// Logs a question and its correct answer data to the log file.
        /// </summary>
        /// <param name="question">The question to log.</param>
        #endregion

        // Logs a question to the file
        private void LogQuestion(Question question)
        {
            #region Step 1: Write Question Data
            using TextWriter writer = new StreamWriter(LogFile, true);
            writer.WriteLine(question.ToString());
            writer.WriteLine($"CORRECT_DATA: {GetCorrectAnswerData(question)}");
            writer.WriteLine("-------------------");
            #endregion
        }

        #region GetCorrectAnswerData Documentation
        /// <summary>
        /// Generates a string representation of the correct answer data for a question.
        /// </summary>
        /// <param name="question">The question to process.</param>
        /// <returns>The formatted correct answer data.</returns>
        #endregion

        // Formats correct answer data for logging
        private string GetCorrectAnswerData(Question question)
        {
            #region Step 1: Determine Question Type
            string questionType = question.GetType().Name;
            #endregion

            #region Step 2: Format Answer Data
            return question switch
            {
                TrueFalseQuestion tfq => $"{questionType}|{tfq.CorrectIndex}",
                ChooseOneQuestion coq => $"{questionType}|{coq.CorrectIndex}",
                ChooseAllQuestion caq => $"{questionType}|{string.Join(",", caq.CorrectIndices)}",
                _ => $"{questionType}|",
            };
            #endregion
        }

        #region LoadExistingQuestions Documentation
        /// <summary>
        /// Loads questions from the log file into the list.
        /// </summary>
        #endregion

        // Loads questions from the log file
        private void LoadExistingQuestions()
        {
            #region Step 1: Check File Existence
            if (!File.Exists(LogFile))
                return;
            #endregion

            #region Step 2: Read and Parse Questions
            try
            {
                using TextReader reader = new StreamReader(LogFile);
                string line;
                StringBuilder questionData = new StringBuilder();
                string correctData = "";

                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("CORRECT_DATA: "))
                    {
                        correctData = line.Substring("CORRECT_DATA: ".Length);
                    }
                    else if (line == "-------------------")
                    {
                        if (questionData.Length > 0)
                        {
                            Question question = ParseQuestionFromString(questionData.ToString().Trim(), correctData);
                            if (question != null)
                            {
                                base.Add(question);
                            }
                        }
                        questionData.Clear();
                        correctData = "";
                    }
                    else
                    {
                        questionData.AppendLine(line);
                    }
                }

                if (questionData.Length > 0)
                {
                    Question question = ParseQuestionFromString(questionData.ToString().Trim(), correctData);
                    if (question != null)
                    {
                        base.Add(question);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading questions from {LogFile}: {ex.Message}");
            }
            #endregion
        }

        #region ParseQuestionFromString Documentation
        /// <summary>
        /// Parses a question from a string representation and its correct answer data.
        /// </summary>
        /// <param name="questionString">The string representation of the question.</param>
        /// <param name="correctData">The correct answer data.</param>
        /// <returns>The parsed question or null if parsing fails.</returns>
        #endregion

        // Parses a question from a string
        private Question ParseQuestionFromString(string questionString, string correctData)
        {
            try
            {
                #region Step 1: Validate Input
                var lines = questionString.Split('\n', StringSplitOptions.RemoveEmptyEntries);
                if (lines.Length < 3)
                    return null;
                #endregion

                #region Step 2: Parse Correct Answer Data
                var correctParts = correctData.Split('|');
                if (correctParts.Length < 2)
                    return null;
                string questionType = correctParts[0];
                string correctAnswerInfo = correctParts[1];
                #endregion

                #region Step 3: Parse Question by Type
                if (questionType == "TrueFalseQuestion" ||
                    (lines.Any(l => l.Contains("A) True")) && lines.Any(l => l.Contains("B) False"))))
                {
                    return ParseTrueFalseQuestion(lines, correctAnswerInfo);
                }
                else if (questionType == "ChooseAllQuestion" ||
                         lines.Any(l => l.Contains("Select all that apply:")))
                {
                    return ParseChooseAllQuestion(lines, correctAnswerInfo);
                }
                else if (questionType == "ChooseOneQuestion")
                {
                    return ParseChooseOneQuestion(lines, correctAnswerInfo);
                }
                return null;
                #endregion
            }
            catch (Exception)
            {
                return null;
            }
        }

        #region ParseTrueFalseQuestion Documentation
        /// <summary>
        /// Parses a true/false question from a string array and correct answer data.
        /// </summary>
        /// <param name="lines">The lines containing the question data.</param>
        /// <param name="correctAnswerInfo">The correct answer data.</param>
        /// <returns>The parsed true/false question or null if parsing fails.</returns>
        #endregion

        // Parses a true/false question
        private TrueFalseQuestion ParseTrueFalseQuestion(string[] lines, string correctAnswerInfo)
        {
            #region Step 1: Extract Question Data
            string header = lines[0];
            string body = lines[1];
            int marks = ExtractMarks(lines);
            #endregion

            #region Step 2: Parse Correct Answer
            if (int.TryParse(correctAnswerInfo, out int correctIndex))
            {
                bool correctAnswer = correctIndex == 0; // 0 = True, 1 = False
                return new TrueFalseQuestion(header, body, marks, correctAnswer);
            }
            #endregion

            #region Step 3: Handle Parsing Failure
            return null;
            #endregion
        }

        #region ParseChooseOneQuestion Documentation
        /// <summary>
        /// Parses a choose-one question from a string array and correct answer data.
        /// </summary>
        /// <param name="lines">The lines containing the question data.</param>
        /// <param name="correctAnswerInfo">The correct answer data.</param>
        /// <returns>The parsed choose-one question or null if parsing fails.</returns>
        #endregion

        // Parses a choose-one question
        private ChooseOneQuestion ParseChooseOneQuestion(string[] lines, string correctAnswerInfo)
        {
            #region Step 1: Extract Question Data
            string header = lines[0];
            string body = lines[1];
            int marks = ExtractMarks(lines);
            #endregion

            #region Step 2: Extract Options
            List<string> options = ExtractOptions(lines);
            if (options.Count < 2)
                return null;
            #endregion

            #region Step 3: Parse Correct Index
            if (int.TryParse(correctAnswerInfo, out int correctIndex) &&
                correctIndex >= 0 && correctIndex < options.Count)
            {
                return new ChooseOneQuestion(header, body, marks, options, correctIndex);
            }
            #endregion

            #region Step 4: Handle Parsing Failure
            return null;
            #endregion
        }

        #region ParseChooseAllQuestion Documentation
        /// <summary>
        /// Parses a choose-all question from a string array and correct answer data.
        /// </summary>
        /// <param name="lines">The lines containing the question data.</param>
        /// <param name="correctAnswerInfo">The correct answer data.</param>
        /// <returns>The parsed choose-all question or null if parsing fails.</returns>
        #endregion

        // Parses a choose-all question
        private ChooseAllQuestion ParseChooseAllQuestion(string[] lines, string correctAnswerInfo)
        {
            #region Step 1: Extract Question Data
            string header = lines[0];
            string body = lines[1];
            int marks = ExtractMarks(lines);
            #endregion

            #region Step 2: Extract Options
            List<string> options = ExtractOptions(lines);
            if (options.Count < 2)
                return null;
            #endregion

            #region Step 3: Parse Correct Indices
            if (string.IsNullOrEmpty(correctAnswerInfo))
                return null;
            var correctIndices = correctAnswerInfo.Split(',')
                .Where(s => int.TryParse(s.Trim(), out _))
                .Select(s => int.Parse(s.Trim()))
                .Where(i => i >= 0 && i < options.Count)
                .ToList();
            if (correctIndices.Any())
            {
                return new ChooseAllQuestion(header, body, marks, options, correctIndices);
            }
            #endregion

            #region Step 4: Handle Parsing Failure
            return null;
            #endregion
        }

        #region ExtractMarks Documentation
        /// <summary>
        /// Extracts the marks from a question's string representation.
        /// </summary>
        /// <param name="lines">The lines containing the question data.</param>
        /// <returns>The extracted marks or a default value of 1 if parsing fails.</returns>
        #endregion

        // Extracts marks from question data
        private int ExtractMarks(string[] lines)
        {
            #region Step 1: Find and Parse Marks
            foreach (var line in lines)
            {
                if (line.Contains("[Marks:") && line.Contains("]"))
                {
                    int start = line.IndexOf("[Marks:") + 7;
                    int end = line.IndexOf("]", start);
                    if (end > start)
                    {
                        string marksStr = line.Substring(start, end - start).Trim();
                        if (int.TryParse(marksStr, out int marks))
                            return marks;
                    }
                }
            }
            return 1; // Default marks
            #endregion
        }

        #region ExtractOptions Documentation
        /// <summary>
        /// Extracts answer options from a question's string representation.
        /// </summary>
        /// <param name="lines">The lines containing the question data.</param>
        /// <returns>A list of answer options.</returns>
        #endregion

        // Extracts answer options from question data
        private List<string> ExtractOptions(string[] lines)
        {
            #region Step 1: Collect Options
            List<string> options = [];
            foreach (var line in lines)
            {
                if (line.Length > 3 &&
                    char.IsLetter(line[0]) &&
                    line[1] == ')' &&
                    line[2] == ' ')
                {
                    string option = line.Substring(3).Trim();
                    if (!string.IsNullOrEmpty(option))
                    {
                        options.Add(option);
                    }
                }
            }
            return options;
            #endregion
        }
    }
}