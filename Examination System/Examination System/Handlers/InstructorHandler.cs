using Examination_System.Models;

namespace Examination_System.Handlers
{
    #region InstructorHandler Documentation
    /// <summary>
    /// Handles instructor-specific operations for managing exams and student assignments.
    /// </summary>
    #endregion

    public class InstructorHandler : ExaminationHandlerBase
    {
        #region CreateAnExam Documentation
        /// <summary>
        /// Creates a new exam and saves it to the exam data file.
        /// </summary>
        #endregion

        // Creates and saves a new exam
        public void CreateAnExam()
        {
            #region Step 1: Load Subjects
            LoadSubjectData();
            #endregion

            #region Step 2: Create Subject
            Subject subject = GetOrCreateSubject();
            #endregion

            #region Step 3: Get Exam Credentials
            int ExamType = Utilities.InputWithValidation("Enter (1). Final Exam (2). Practice Exam: ", x => x == 1 || x == 2, false, -1);
            int ExamTime = Utilities.InputWithValidation("Enter Time of Exam in minutes: ", x => x > 0, false, -1);
            #endregion

            #region Step 4: Create Question List
            string examTypeName = ExamType == 1 ? "FinalExam" : "PracticeExam";
            QuestionList Questions = CreateQuestionList(examTypeName);
            #endregion

            #region Step 5: Create and Save Exam
            Exam exam;
            if (ExamType == 1)
            {
                exam = new FinalExam(subject, Questions, ExamTime);
            }
            else
            {
                exam = new PracticeExam(subject, Questions, ExamTime);
            }
            Exams.Add(exam);
            SaveExamData(exam);
            SaveSubjectData();
            Console.WriteLine("Exam Added Successfully!");
            WaitForKeyPress();
            #endregion
        }

        #region DeleteAnExam Documentation
        /// <summary>
        /// Deletes an existing exam and its associated log file.
        /// </summary>
        #endregion

        // Deletes an exam from the system
        public void DeleteAnExam()
        {
            #region Step 1: Load Exams
            LoadExamData();
            #endregion

            #region Step 2: Check and Display Exams
            if (!CheckExamsAvailability()) return;
            DisplayExams();
            #endregion

            #region Step 3: Get Exam to Delete
            int examIndex = Utilities.InputWithValidation("\nEnter the number of the exam to delete (0 to go back): ",
                x => x >= 0 && x <= Exams.Count, false, 0);
            if (examIndex == 0)
            {
                return;
            }
            Exam examToDelete = Exams[examIndex - 1];
            string logFile = GetExamLogFile(examToDelete);
            #endregion

            #region Step 4: Delete Exam and Log File
            Exams.RemoveAt(examIndex - 1);
            if (File.Exists(logFile))
            {
                File.Delete(logFile);
            }
            UpdateExamDataFile();
            Console.WriteLine("Exam deleted successfully!");
            WaitForKeyPress();
            #endregion
        }

        #region EditAnExam Documentation
        /// <summary>
        /// Edits an existing exam's subject, time, or questions.
        /// </summary>
        #endregion

        // Edits an existing exam
        public void EditAnExam()
        {
            #region Step 1: Load Data
            LoadExamData();
            LoadSubjectData();
            #endregion

            #region Step 2: Check and Display Exams
            if (!CheckExamsAvailability()) return;
            DisplayExams();
            #endregion

            #region Step 3: Select Exam to Edit
            int examIndex = Utilities.InputWithValidation("Enter the number of the exam to edit (0 to go back): ",
                x => x >= 0 && x <= Exams.Count, false, -1);
            if (examIndex == 0)
            {
                return;
            }
            Exam oldExam = Exams[examIndex - 1];
            string oldLogFile = GetExamLogFile(oldExam);
            #endregion

            #region Step 4: Choose Edit Option
            Console.WriteLine("What do you want to edit?");
            Console.WriteLine("[1]. Subject");
            Console.WriteLine("[2]. Exam Time");
            Console.WriteLine("[3]. Questions");
            int editChoice = Utilities.InputWithValidation("Enter your choice: ", x => x >= 1 && x <= 3, false, -1);
            #endregion

            #region Step 5: Update Exam Details
            Subject subject = oldExam.Subject;
            int examTime = oldExam.Time;
            QuestionList questions = oldExam.Questions;
            if (editChoice == 1)
            {
                subject = GetOrCreateSubject();
            }
            else if (editChoice == 2)
            {
                examTime = Utilities.InputWithValidation("Enter new Time of Exam in minutes: ", x => x > 0, false, -1);
            }
            else if (editChoice == 3)
            {
                string examTypeName = oldExam is FinalExam ? "FinalExam" : "PracticeExam";
                questions = CreateQuestionList(examTypeName);
            }
            #endregion

            #region Step 6: Save Updated Exam
            Exam newExam = oldExam is FinalExam ? new FinalExam(subject, questions, examTime) : new PracticeExam(subject, questions, examTime);
            Exams[examIndex - 1] = newExam;
            if (File.Exists(oldLogFile))
            {
                File.Delete(oldLogFile);
            }
            UpdateExamDataFile();
            SaveSubjectData();
            Console.WriteLine("Exam edited successfully!");
            WaitForKeyPress();
            #endregion
        }

        #region ShowAllExams Documentation
        /// <summary>
        /// Displays all available exams.
        /// </summary>
        #endregion

        // Shows all exams in the system
        public void ShowAllExams()
        {
            #region Step 1: Display Exams
            DisplayExams();
            WaitForKeyPress();
            #endregion
        }

        #region DisplayExams Documentation
        /// <summary>
        /// Displays a list of all exams with their details.
        /// </summary>
        #endregion

        // Displays the list of exams
        private void DisplayExams()
        {
            #region Step 1: Load Exams
            LoadExamData();
            #endregion

            #region Step 2: Check and Display Exams
            if (!CheckExamsAvailability()) return;
            Console.WriteLine("Available Exams:");
            for (int i = 0; i < Exams.Count; i++)
            {
                string examType = Exams[i] is FinalExam ? "Final Exam" : "Practice Exam";
                Console.WriteLine($"[{i + 1}] {examType} for {Exams[i].Subject.Name}, Time: {Exams[i].Time} minutes, Questions: {Exams[i].Questions.Count}");
            }
            #endregion
        }

        #region AssignStudentsToSubject Documentation
        /// <summary>
        /// Assigns students to a selected subject.
        /// </summary>
        #endregion

        // Assigns students to a subject
        public void AssignStudentsToSubject()
        {
            #region Step 1: Load and Check Subjects
            LoadSubjectData();
            if (Subjects.Count == 0)
            {
                Console.WriteLine("No subjects available. Create an exam first to add a subject.");
                WaitForKeyPress();
                return;
            }
            #endregion

            #region Step 2: Display Subjects
            Console.WriteLine("Available Subjects:");
            for (int i = 0; i < Subjects.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {Subjects[i].Name}");
            }
            #endregion

            #region Step 3: Select Subject
            int subjectIndex = Utilities.InputWithValidation("Enter the number of the subject (0 to go back): ",
                x => x >= 0 && x <= Subjects.Count, false, -1);
            if (subjectIndex == 0)
            {
                return;
            }
            Subject selectedSubject = Subjects[subjectIndex - 1];
            #endregion

            #region Step 4: Assign Students
            while (true)
            {
                string studentName = Utilities.InputAndCast("Enter student name (or press Enter to finish): ", true, "");
                if (string.IsNullOrEmpty(studentName))
                {
                    break;
                }
                Student student = new(studentName);
                selectedSubject.AddStudent(student);
                Console.WriteLine($"Student {studentName} assigned to {selectedSubject.Name}.");
            }
            #endregion

            #region Step 5: Save Subject Data
            SaveSubjectData();
            Console.WriteLine("Students assigned successfully!");
            WaitForKeyPress();
            #endregion
        }

        #region GetOrCreateSubject Documentation
        /// <summary>
        /// Retrieves an existing subject or creates a new one based on user input.
        /// </summary>
        /// <returns>The selected or created subject.</returns>
        #endregion

        // Gets or creates a subject
        private Subject GetOrCreateSubject()
        {
            #region Step 1: Get Subject Name
            Subject subject = new(Utilities.InputAndCast("Enter Subject Name: ", false, "Undefined"));
            #endregion

            #region Step 2: Check and Add Subject
            if (!Subjects.Exists(s => s.Name == subject.Name))
            {
                Subjects.Add(subject);
            }
            else
            {
                subject = Subjects?.Find(s => s.Name == subject.Name)!;
            }
            #endregion

            #region Step 3: Return Subject
            return subject;
            #endregion
        }

        #region CreateQuestionList Documentation
        /// <summary>
        /// Creates a list of questions for an exam and saves them to a unique file.
        /// </summary>
        /// <param name="examTypeName">The type of exam (FinalExam or PracticeExam).</param>
        /// <returns>The created question list.</returns>
        #endregion

        // Creates a question list for an exam
        private QuestionList CreateQuestionList(string examTypeName)
        {
            #region Step 1: Generate Unique File Name
            Random rand = new();
            string FileName;
            do
            {
                int randomNumber = rand.Next(100, 1000);
                FileName = $"{examTypeName}_{randomNumber}.txt";
            } while (File.Exists(FileName));
            QuestionList Questions = new(FileName);
            Console.WriteLine("Question List:\n__________________________");
            #endregion

            #region Step 2: Add Questions Loop
            int flag = 1;
            while (flag == 1)
            {
                int QuestionType = Utilities.InputWithValidation("Enter (1).True Or False Question (2). Choose All Question (3). Choose One Question: ",
                    x => x >= 1 && x <= 3, false, -1);
                string QuestionBody = Utilities.InputAndCast("Enter the body of the question: ", false, "Unknown");
                int QuestionMarks = Utilities.InputWithValidation("Enter marks of this question: ", x => x > 0, false, -1);

                if (QuestionType == 1)
                {
                    CreateTrueFalseQuestion(Questions, QuestionBody, QuestionMarks);
                }
                else if (QuestionType == 2)
                {
                    CreateChooseAllQuestion(Questions, QuestionBody, QuestionMarks);
                }
                else if (QuestionType == 3)
                {
                    CreateChooseOneQuestion(Questions, QuestionBody, QuestionMarks);
                }

                flag = Utilities.InputWithValidation("Enter (1). To Add Another Question (0). To Finish: ", (int x) => x == 0 || x == 1, false, -1);
            }
            #endregion

            #region Step 3: Return Question List
            return Questions;
            #endregion
        }

        #region CreateTrueFalseQuestion Documentation
        /// <summary>
        /// Creates a true/false question and adds it to the question list.
        /// </summary>
        /// <param name="questions">The question list to add to.</param>
        /// <param name="questionBody">The body of the question.</param>
        /// <param name="questionMarks">The marks for the question.</param>
        #endregion

        // Creates a true/false question
        private void CreateTrueFalseQuestion(QuestionList questions, string questionBody, int questionMarks)
        {
            #region Step 1: Get Correct Answer
            int correctAnswerInput = Utilities.InputWithValidation("Enter the correct answer (1). True (2). False: ", x => x == 1 || x == 2, false, -1);
            bool CorrectAnswer = correctAnswerInput == 1;
            #endregion

            #region Step 2: Create and Add Question
            TrueFalseQuestion TrueFalseQ = new("True OR False :-", questionBody, questionMarks, CorrectAnswer);
            questions.Add(TrueFalseQ);
            #endregion
        }

        #region CreateChooseAllQuestion Documentation
        /// <summary>
        /// Creates a multiple-choice question with multiple correct answers.
        /// </summary>
        /// <param name="questions">The question list to add to.</param>
        /// <param name="questionBody">The body of the question.</param>
        /// <param name="questionMarks">The marks for the question.</param>
        #endregion

        // Creates a choose-all question
        private void CreateChooseAllQuestion(QuestionList questions, string questionBody, int questionMarks)
        {
            #region Step 1: Get Choices
            int TotalAnswers = Utilities.InputWithValidation("How Many Choices You will provide: ", x => x >= 2, false, -1);
            List<string> Choices = [];
            List<int> CorrectChoices = [];
            #endregion

            #region Step 2: Collect Choices and Correct Answers
            for (int i = 0; i < TotalAnswers; i++)
            {
                string choice = Utilities.InputAndCast<string>($"Enter Choice No.{i + 1}: ", false);
                Choices.Add(choice);
                bool Correct = Utilities.InputWithValidation("Is it a correct answer? (Enter 1 If it is correct, 0 otherwise): ",
                    x => x == 0 || x == 1, false, -1) == 1;
                if (Correct)
                    CorrectChoices.Add(i);
            }
            #endregion

            #region Step 3: Create and Add Question
            ChooseAllQuestion AllQuestion = new("Choose All Correct:- ", questionBody, questionMarks, Choices, CorrectChoices);
            questions.Add(AllQuestion);
            #endregion
        }

        #region CreateChooseOneQuestion Documentation
        /// <summary>
        /// Creates a multiple-choice question with a single correct answer.
        /// </summary>
        /// <param name="questions">The question list to add to.</param>
        /// <param name="questionBody">The body of the question.</param>
        /// <param name="questionMarks">The marks for the question.</param>
        #endregion

        // Creates a choose-one question
        private void CreateChooseOneQuestion(QuestionList questions, string questionBody, int questionMarks)
        {
            #region Step 1: Get Choices
            int TotalAnswers = Utilities.InputWithValidation("How Many Choices You will provide: ", x => x >= 2, false, -1);
            List<string> Choices = [];
            int CorrectIndex = 0;
            bool CorrectIndexFlag = true;
            #endregion

            #region Step 2: Collect Choices and Correct Answer
            for (int i = 0; i < TotalAnswers; i++)
            {
                string choice = Utilities.InputAndCast<string>($"Enter Choice No.{i + 1}: ", false);
                Choices.Add(choice);
                if (CorrectIndexFlag)
                {
                    bool Correct = Utilities.InputWithValidation("Is it the correct answer? (Enter 1 If it is correct, 0 otherwise): ",
                        x => x == 0 || x == 1, false, -1) == 1;
                    if (Correct)
                    {
                        CorrectIndex = i;
                        CorrectIndexFlag = false;
                    }
                }
            }
            #endregion

            #region Step 3: Create and Add Question
            ChooseOneQuestion OneQuestion = new("Choose One Correct:- ", questionBody, questionMarks, Choices, CorrectIndex);
            questions.Add(OneQuestion);
            #endregion
        }

        #region GetExamLogFile Documentation
        /// <summary>
        /// Retrieves the log file path for an exam's questions.
        /// </summary>
        /// <param name="exam">The exam to get the log file for.</param>
        /// <returns>The log file path.</returns>
        #endregion

        // Gets the log file for an exam
        private string GetExamLogFile(Exam exam)
        {
            #region Step 1: Return Log File
            return exam.Questions.LogFile;
            #endregion
        }

        #region CheckExamsAvailability Documentation
        /// <summary>
        /// Checks if there are any exams available.
        /// </summary>
        /// <returns>True if exams exist, false otherwise.</returns>
        #endregion

        // Checks if exams are available
        private bool CheckExamsAvailability()
        {
            #region Step 1: Check and Notify
            if (Exams.Count == 0)
            {
                Console.WriteLine("No exams available.");
                return false;
            }
            return true;
            #endregion
        }

        #region SaveExamData Documentation
        /// <summary>
        /// Saves an exam's data to the exam data file.
        /// </summary>
        /// <param name="exam">The exam to save.</param>
        #endregion

        // Saves exam data to file
        private void SaveExamData(Exam exam)
        {
            #region Step 1: Prepare Exam Data
            string logFile = GetExamLogFile(exam);
            string examType = exam is FinalExam ? "FinalExam" : "PracticeExam";
            string data = $"{examType}|{exam.Subject.Name}|{exam.Time}|{logFile}";
            #endregion

            #region Step 2: Write to File
            using TextWriter writer = new StreamWriter(ExamDataFile, true);
            writer.WriteLine(data);
            #endregion
        }

        #region UpdateExamDataFile Documentation
        /// <summary>
        /// Updates the exam data file with the current list of exams.
        /// </summary>
        #endregion

        // Updates the exam data file
        private void UpdateExamDataFile()
        {
            #region Step 1: Write All Exams
            using TextWriter writer = new StreamWriter(ExamDataFile, false);
            foreach (var exam in Exams)
            {
                string logFile = GetExamLogFile(exam);
                string examType = exam is FinalExam ? "FinalExam" : "PracticeExam";
                writer.WriteLine($"{examType}|{exam.Subject.Name}|{exam.Time}|{logFile}");
            }
            #endregion
        }

        #region SaveSubjectData Documentation
        /// <summary>
        /// Saves the current list of subjects to the subject data file.
        /// </summary>
        #endregion

        // Saves subject data to file
        private void SaveSubjectData()
        {
            #region Step 1: Write All Subjects
            using TextWriter writer = new StreamWriter(SubjectDataFile, false);
            foreach (var subject in Subjects)
            {
                string studentNames = string.Join(",", subject.Students.Select(s => s.Name));
                writer.WriteLine($"{subject.Name}|{studentNames}");
            }
            #endregion
        }
    }
}