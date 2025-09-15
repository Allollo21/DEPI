using Examination_System.Handlers;

namespace Examination_System
{
    #region Program Documentation
    /// <summary>
    /// Main entry point for the Examination System console application.
    /// </summary>
    #endregion

    internal class Program
    {
        #region Main Documentation
        /// <summary>
        /// Displays the main menu and handles user navigation to instructor or student interfaces.
        /// </summary>
        /// <param name="args">Command-line arguments (not used).</param>
        #endregion

        // Main entry point for the application
        public static void Main(string[] args)
        {
            #region Step 1: Initialize Loop
            char choice = 'a';
            #endregion

            #region Step 2: Main Menu Loop
            while (choice != '0')
            {
                #region Step 3: Display Menu
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\t\t\t---------------------------------");
                Console.WriteLine("\t\t\t\t|       EXAMINATION SYSTEM      |");
                Console.WriteLine("\t\t\t\t---------------------------------");
                Console.WriteLine("\t\t\t\t[1]. Instructor ");
                Console.WriteLine("\t\t\t\t[2]. Student");
                Console.WriteLine("\t\t\t\t[0]. Exit");
                Console.Write("\t\t\t\t> ");
                #endregion

                #region Step 4: Handle Input
                if (!char.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid Input, Try Again!");
                    Thread.Sleep(1000);
                    continue;
                }
                #endregion

                #region Step 5: Reset Console
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                #endregion

                #region Step 6: Process User Choice
                switch (choice)
                {
                    case '1':
                        InstructorInnerInterface();
                        break;

                    case '2':
                        StudentInnerInterface();
                        break;

                    case '0':
                        break;

                    default:
                        Console.WriteLine("Invalid Input, Try Again!");
                        Thread.Sleep(1000);
                        break;
                }
                #endregion
            }
            #endregion

            #region Step 7: Exit Message
            Console.WriteLine("BYE BYE YA 7BEBI!");
            #endregion
        }

        #region InstructorInnerInterface Documentation
        /// <summary>
        /// Displays the instructor interface menu and handles instructor-specific actions.
        /// </summary>
        #endregion

        // Instructor interface for managing exams and student assignments
        public static void InstructorInnerInterface()
        {
            #region Step 1: Initialize Handler and Loop
            InstructorHandler handler = new();
            char choice = 'a';
            #endregion

            #region Step 2: Instructor Menu Loop
            while (choice != '0')
            {
                #region Step 3: Display Menu
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\t\t\t---------------------------------");
                Console.WriteLine("\t\t\t\t|       INSTRUCTOR INTERFACE       |");
                Console.WriteLine("\t\t\t\t---------------------------------");
                Console.WriteLine("\t\t\t\t[1]. Create an Exam");
                Console.WriteLine("\t\t\t\t[2]. Delete an Exam");
                Console.WriteLine("\t\t\t\t[3]. Modify an Exam");
                Console.WriteLine("\t\t\t\t[4]. Show All Exams");
                Console.WriteLine("\t\t\t\t[5]. Assign Students to Subject");
                Console.WriteLine("\t\t\t\t[0]. Back");
                Console.Write("\t\t\t\t> ");
                #endregion

                #region Step 4: Handle Input
                if (!char.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid Input, Try Again!");
                    Thread.Sleep(1000);
                    continue;
                }
                #endregion

                #region Step 5: Reset Console
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                #endregion

                #region Step 6: Process Instructor Choice
                switch (choice)
                {
                    case '1':
                        handler.CreateAnExam();
                        break;

                    case '2':
                        handler.DeleteAnExam();
                        break;

                    case '3':
                        handler.EditAnExam();
                        break;

                    case '4':
                        handler.ShowAllExams();
                        break;

                    case '5':
                        handler.AssignStudentsToSubject();
                        break;

                    case '0':
                        break;

                    default:
                        Console.WriteLine("Invalid Input, Try Again!");
                        Thread.Sleep(1000);
                        break;
                }
                #endregion
            }
            #endregion
        }

        #region StudentInnerInterface Documentation
        /// <summary>
        /// Displays the student interface menu and handles student-specific actions.
        /// </summary>
        #endregion

        // Student interface for taking and viewing exams
        public static void StudentInnerInterface()
        {
            #region Step 1: Initialize Handler and Loop
            StudentHandler handler = new();
            char choice = 'a';
            #endregion

            #region Step 2: Student Menu Loop
            while (choice != '0')
            {
                #region Step 3: Display Menu
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\t\t\t---------------------------------");
                Console.WriteLine("\t\t\t\t|       STUDENT INTERFACE       |");
                Console.WriteLine("\t\t\t\t---------------------------------");
                Console.WriteLine("\t\t\t\t[1]. Take an Exam");
                Console.WriteLine("\t\t\t\t[2]. Show All Exams");
                Console.WriteLine("\t\t\t\t[0]. Back");
                Console.Write("\t\t\t\t> ");
                #endregion

                #region Step 4: Handle Input
                if (!char.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid Input, Try Again!");
                    Thread.Sleep(1000);
                    continue;
                }
                #endregion

                #region Step 5: Reset Console
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                #endregion

                #region Step 6: Process Student Choice
                switch (choice)
                {
                    case '1':
                        handler.TakeAnExam();
                        break;

                    case '2':
                        handler.ShowAllExams();
                        break;

                    case '0':
                        break;

                    default:
                        Console.WriteLine("Invalid Input, Try Again!");
                        Thread.Sleep(1000);
                        break;
                }
                #endregion
            }
            #endregion
        }
    }
}