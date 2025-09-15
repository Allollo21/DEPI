using Examination_System.Models;

namespace Examination_System.Handlers
{
    #region ExaminationHandlerBase Documentation
    /// <summary>
    /// Abstract base class for handling exam and subject data operations.
    /// </summary>
    #endregion

    public abstract class ExaminationHandlerBase
    {
        #region Fields
        // List of exams loaded from file.
        protected List<Exam> Exams = [];

        // List of subjects loaded from file.
        protected List<Subject> Subjects = [];

        // File path for exam data storage.
        protected readonly string ExamDataFile = "exams_data.txt";

        // File path for subject data storage.
        protected readonly string SubjectDataFile = "subjects_data.txt";
        #endregion

        #region WaitForKeyPress Documentation
        /// <summary>
        /// Pauses execution and waits for a key press to continue.
        /// </summary>
        #endregion

        // Pauses the console for user interaction
        protected void WaitForKeyPress()
        {
            #region Step 1: Prompt and Wait
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            #endregion
        }

        #region LoadExamData Documentation
        /// <summary>
        /// Loads exam data from a file into the Exams list.
        /// </summary>
        /// <remarks>Requires subject data to be loaded first. Creates new subjects if not found.</remarks>
        #endregion

        // Loads exam data from file
        protected void LoadExamData()
        {
            #region Step 1: Clear Exams List
            Exams.Clear();
            #endregion

            #region Step 2: Load Subjects
            LoadSubjectData(); // Load subjects first as they are needed for exams
            #endregion

            #region Step 3: Check File Existence
            if (!File.Exists(ExamDataFile))
            {
                return;
            }
            #endregion

            #region Step 4: Read and Parse Exam Data
            using TextReader reader = new StreamReader(ExamDataFile);
            string line;
            while ((line = reader.ReadLine()!) != null)
            {
                string[] parts = line.Split('|');
                if (parts.Length != 4) continue;

                string examType = parts[0];
                string subjectName = parts[1];
                int time = int.Parse(parts[2]);
                string logFile = parts[3];

                Subject subject = Subjects.Find(s => s.Name == subjectName)!;
                if (subject == null)
                {
                    subject = new Subject(subjectName);
                    Subjects.Add(subject);
                }

                QuestionList questions = new(logFile);
                Exam exam = examType == "FinalExam" ? new FinalExam(subject, questions, time) : new PracticeExam(subject, questions, time);
                Exams.Add(exam);
            }
            #endregion
        }

        #region LoadSubjectData Documentation
        /// <summary>
        /// Loads subject data from a file into the Subjects list.
        /// </summary>
        /// <remarks>Parses subject names and associated student names from the file.</remarks>
        #endregion

        // Loads subject data from file
        protected void LoadSubjectData()
        {
            #region Step 1: Clear Subjects List
            Subjects.Clear();
            #endregion

            #region Step 2: Check File Existence
            if (!File.Exists(SubjectDataFile))
            {
                return;
            }
            #endregion

            #region Step 3: Read and Parse Subject Data
            using TextReader reader = new StreamReader(SubjectDataFile);
            string line;
            while ((line = reader.ReadLine()!) != null)
            {
                string[] parts = line.Split('|');
                if (parts.Length != 2) continue;

                string subjectName = parts[0];
                string[] studentNames = parts[1].Split(',', StringSplitOptions.RemoveEmptyEntries);

                Subject subject = new(subjectName);
                foreach (var name in studentNames)
                {
                    subject.AddStudent(new Student(name));
                }
                Subjects.Add(subject);
            }
            #endregion
        }
    }
}