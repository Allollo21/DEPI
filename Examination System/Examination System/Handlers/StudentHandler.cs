using Examination_System.Models;

namespace Examination_System.Handlers
{
    #region StudentHandler Documentation
    /// <summary>
    /// Handles student-specific operations for taking and viewing exams.
    /// </summary>
    #endregion

    public class StudentHandler : ExaminationHandlerBase
    {
        #region TakeAnExam Documentation
        /// <summary>
        /// Allows a student to take an assigned exam.
        /// </summary>
        #endregion

        // Facilitates taking an exam by a student
        public void TakeAnExam()
        {
            #region Step 1: Load Data
            LoadExamData();
            LoadSubjectData();
            #endregion

            #region Step 2: Get Student Name
            string studentName = Utilities.InputAndCast("Enter your name: ", false, "");
            #endregion

            #region Step 3: Get Available Exams
            List<Exam> availableExams = GetAvailableExamsForStudent(studentName);
            #endregion

            #region Step 4: Check and Display Exams
            if (!CheckExamsAvailability(availableExams)) return;
            DisplayAvailableExams(availableExams);
            #endregion

            #region Step 5: Select and Take Exam
            int examIndex = Utilities.InputWithValidation("Enter the number of the exam to take: ",
                x => x >= 1 && x <= availableExams.Count, false, -1);
            Exam selectedExam = availableExams[examIndex - 1];
            selectedExam.CurrentMode = Mode.Starting;
            selectedExam.ShowExam();
            selectedExam.CurrentMode = Mode.Finished;
            #endregion

            #region Step 6: Complete Exam
            Console.WriteLine("Exam completed!");
            WaitForKeyPress();
            #endregion
        }

        #region ShowAllExams Documentation
        /// <summary>
        /// Displays all exams available to a specific student.
        /// </summary>
        #endregion

        // Displays all exams available to a student
        public void ShowAllExams()
        {
            #region Step 1: Load Data
            LoadExamData();
            LoadSubjectData();
            #endregion

            #region Step 2: Get Student Name
            string studentName = Utilities.InputAndCast("Enter your name: ", false, "");
            #endregion

            #region Step 3: Get Available Exams
            List<Exam> availableExams = GetAvailableExamsForStudent(studentName);
            #endregion

            #region Step 4: Check and Display Exams
            if (!CheckExamsAvailability(availableExams)) return;
            DisplayAvailableExams(availableExams);
            WaitForKeyPress();
            #endregion
        }

        #region GetAvailableExamsForStudent Documentation
        /// <summary>
        /// Retrieves a list of exams available to a specific student based on their assigned subjects.
        /// </summary>
        /// <param name="studentName">The name of the student.</param>
        /// <returns>A list of exams the student can access.</returns>
        #endregion

        // Gets exams available for a student
        private List<Exam> GetAvailableExamsForStudent(string studentName)
        {
            #region Step 1: Initialize Variables
            Student currentStudent;
            List<Exam> availableExams = [];
            #endregion

            #region Step 2: Find Matching Exams
            foreach (var subject in Subjects)
            {
                currentStudent = subject.Students.Find(s => s.Name == studentName)!;
                if (currentStudent != null)
                {
                    availableExams.AddRange(Exams.Where(e => e.Subject.Name == subject.Name));
                }
            }
            #endregion

            #region Step 3: Return Available Exams
            return availableExams;
            #endregion
        }

        #region CheckExamsAvailability Documentation
        /// <summary>
        /// Checks if there are any exams available for the student.
        /// </summary>
        /// <param name="availableExams">The list of exams to check.</param>
        /// <returns>True if exams exist, false otherwise.</returns>
        #endregion

        // Checks if exams are available for a student
        private bool CheckExamsAvailability(List<Exam> availableExams)
        {
            #region Step 1: Check and Notify
            if (availableExams.Count == 0)
            {
                Console.WriteLine("No exams assigned to you.");
                WaitForKeyPress();
                return false;
            }
            return true;
            #endregion
        }

        #region DisplayAvailableExams Documentation
        /// <summary>
        /// Displays a list of exams available to the student.
        /// </summary>
        /// <param name="availableExams">The list of exams to display.</param>
        #endregion

        // Displays available exams for a student
        private void DisplayAvailableExams(List<Exam> availableExams)
        {
            #region Step 1: Display Exams
            Console.WriteLine("Available Exams:");
            for (int i = 0; i < availableExams.Count; i++)
            {
                string examType = availableExams[i] is FinalExam ? "Final Exam" : "Practice Exam";
                Console.WriteLine($"[{i + 1}] {examType} for {availableExams[i].Subject.Name}, Time: {availableExams[i].Time} minutes, Questions: {availableExams[i].Questions.Count}");
            }
            #endregion
        }
    }
}