namespace Examination_System.Models
{
    #region Exam Documentation
    /// <summary>
    /// Abstract base class for exams, implementing cloning and comparison functionality.
    /// </summary>
    #endregion

    public abstract class Exam : ICloneable, IComparable<Exam>
    {
        #region Subject Documentation
        /// <summary>
        /// Gets the subject associated with the exam.
        /// </summary>
        #endregion

        public Subject Subject { get; private set; }

        #region Questions Documentation
        /// <summary>
        /// Gets the list of questions for the exam.
        /// </summary>
        #endregion 

        public QuestionList Questions { get; private set; }

        #region Time Documentation
        /// <summary>
        /// Gets the duration of the exam in minutes.
        /// </summary>
        #endregion

        public int Time { get; private set; }

        #region CurrentMode Documentation
        /// <summary>
        /// Gets or sets the current mode of the exam (Queued, Starting, Finished).
        /// </summary>
        #endregion

        public Mode CurrentMode
        {
            #region CurrentMode Property Logic
            get => currentMode;
            set
            {
                if (value == Mode.Starting && currentMode != Mode.Starting)
                {
                    OnExamStarted?.Invoke(this);
                }
                currentMode = value;
            }
            #endregion
        }
        private Mode currentMode = Mode.Queued;


        #region Delegate Documentation
        /// <summary>
        /// Delegate for handling exam start events.
        /// </summary>
        /// <param name="exam">The exam that is starting.</param> 
        #endregion
        public delegate void ExamStartedHandler(Exam exam);

        #region Event Documentation
        /// <summary>
        /// Event triggered when the exam starts.
        /// </summary> 
        #endregion

        public event ExamStartedHandler OnExamStarted;

        #region Constructor Documentation
        /// <summary>
        /// Initializes a new instance of the Exam class.
        /// </summary>
        /// <param name="subject">The subject of the exam.</param>
        /// <param name="questions">The list of questions for the exam.</param>
        /// <param name="time">The duration of the exam in minutes.</param>
        #endregion

        // Initializes an exam with subject, questions, and time
        protected Exam(Subject subject, QuestionList questions, int time)
        {
            #region Step 1: Initialize Properties
            Subject = subject;
            Questions = questions;
            Time = time;
            #endregion

            #region Step 2: Subscribe to Event
            OnExamStarted += (exam) =>
            {
                string message = $"Exam for {exam.Subject.Name} is starting!";
                foreach (var student in exam.Subject.Students)
                {
                    student.Notify(message);
                }
            };
            #endregion
        }

        #region ShowExam Documentation
        /// <summary>
        /// Displays the exam content and processes user answers.
        /// </summary>
        #endregion

        // Displays and conducts the exam
        public abstract void ShowExam();

        #region CalculateScore Documentation
        /// <summary>
        /// Calculates the total score based on user answers.
        /// </summary>
        /// <param name="userAnswers">Dictionary of questions and their corresponding user answers.</param>
        /// <returns>The total score achieved.</returns>
        #endregion

        // Calculates the score for user answers
        protected int CalculateScore(Dictionary<Question, object> userAnswers)
        {
            #region Step 1: Initialize Score
            int score = 0;
            #endregion

            #region Step 2: Evaluate Answers
            foreach (var q in Questions)
            {
                if (q.CheckAnswer(userAnswers[q]))
                {
                    score += q.Marks;
                }
            }
            #endregion

            #region Step 3: Return Score
            return score;
            #endregion
        }

        #region TakeExam Documentation
        /// <summary>
        /// Administers the exam, collecting user answers for each question.
        /// </summary>
        /// <returns>A dictionary of questions and user answers.</returns>
        #endregion

        // Collects user answers during the exam
        protected Dictionary<Question, object> TakeExam()
        {
            #region Step 1: Initialize Answer Dictionary
            Dictionary<Question, object> userAnswers = new Dictionary<Question, object>();
            #endregion

            #region Step 2: Display Exam Information
            Console.WriteLine($"Exam: {this.ToString()}");
            Console.WriteLine($"Time: {Time} minutes");
            Console.WriteLine("Start answering:");
            #endregion

            #region Step 3: Process Each Question
            foreach (var q in Questions)
            {
                Console.WriteLine(q.GetQuestionRepresentation());
                string input = Console.ReadLine().Trim().ToUpper();
                object userAnswer;

                if (q is ChooseAllQuestion)
                {
                    List<int> selected = new List<int>();
                    string[] parts = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var part in parts)
                    {
                        if (part.Length > 0)
                        {
                            char c = part[0];
                            if (char.IsLetter(c))
                            {
                                int index = c - 'A';
                                if (index >= 0 && index < (q as ChooseAllQuestion).Answers.Count)
                                {
                                    selected.Add(index);
                                }
                            }
                        }
                    }
                    userAnswer = selected;
                }
                else
                {
                    if (input.Length > 0)
                    {
                        char c = input[0];
                        userAnswer = c - 'A';
                    }
                    else
                    {
                        userAnswer = -1; // Invalid
                    }
                }
                userAnswers[q] = userAnswer;
            }
            #endregion

            #region Step 4: Return Answers
            return userAnswers;
            #endregion
        }

        #region GetUserAnswerRepresentation Documentation
        /// <summary>
        /// Formats the user's answer for display.
        /// </summary>
        /// <param name="q">The question being answered.</param>
        /// <param name="userAnswer">The user's answer.</param>
        /// <returns>A string representation of the user's answer.</returns>
        #endregion

        // Formats user answers for display
        protected string GetUserAnswerRepresentation(Question q, object userAnswer)
        {
            #region Step 1: Format Single Answer
            if (userAnswer is int i && i >= 0 && i < q.Answers.Count)
            {
                char letter = (char)('A' + i);
                return $"{letter}) {q.Answers[i]}";
            }
            #endregion

            #region Step 2: Format Multiple Answers
            else if (userAnswer is List<int> l)
            {
                var sorted = l.OrderBy(x => x);
                return string.Join(", ", sorted.Select(idx => $"{(char)('A' + idx)}) {q.Answers[idx]}"));
            }
            #endregion

            #region Step 3: Handle Invalid Answer
            return "Invalid answer";
            #endregion
        }

        #region Clone Documentation
        /// <summary>
        /// Creates a shallow copy of the exam.
        /// </summary>
        /// <returns>A cloned exam object.</returns>
        #endregion

        // Creates a shallow clone of the exam
        public object Clone()
        {
            #region Step 1: Perform Shallow Clone
            return this.MemberwiseClone();
            #endregion
        }

        #region CompareTo Documentation
        /// <summary>
        /// Compares this exam to another based on duration.
        /// </summary>
        /// <param name="other">The exam to compare to.</param>
        /// <returns>A value indicating the relative order based on time.</returns>
        #endregion

        // Compares exams by time
        public int CompareTo(Exam other)
        {
            #region Step 1: Compare by Time
            if (other == null) return 1;
            return this.Time.CompareTo(other.Time);
            #endregion
        }

        #region ToString Documentation
        /// <summary>
        /// Returns a string representation of the exam.
        /// </summary>
        /// <returns>The exam description.</returns>
        #endregion

        // Formats exam description
        public override string ToString()
        {
            #region Step 1: Return Exam Description
            return $"Exam for {Subject.Name} with {Questions.Count} questions";
            #endregion
        }

        #region Equals Documentation
        /// <summary>
        /// Determines if this exam is equal to another based on subject, time, and question count.
        /// </summary>
        /// <param name="obj">The object to compare with.</param>
        /// <returns>True if the exams are equal, false otherwise.</returns>
        #endregion

        // Checks equality of exams
        public override bool Equals(object obj)
        {
            #region Step 1: Compare Exam Properties
            if (obj is not Exam other) return false;
            return this.Subject.Name == other.Subject.Name && this.Time == other.Time && this.Questions.Count == other.Questions.Count;
            #endregion
        }

        #region GetHashCode Documentation
        /// <summary>
        /// Generates a hash code for the exam.
        /// </summary>
        /// <returns>The hash code based on subject, time, and question count.</returns>
        #endregion

        // Generates hash code for the exam
        public override int GetHashCode()
        {
            #region Step 1: Compute Hash Code
            return HashCode.Combine(Subject.Name, Time, Questions.Count);
            #endregion
        }
    }
}