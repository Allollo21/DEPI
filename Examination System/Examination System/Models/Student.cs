namespace Examination_System.Models
{
    #region Student Documentation
    /// <summary>
    /// Represents a student in the examination system.
    /// </summary>
    #endregion

    public class Student
    {
        #region Name Documentation
        /// <summary>
        /// Gets the name of the student.
        /// </summary>
        #endregion

        public string Name { get; private set; }

        #region Default Constructor Documentation
        /// <summary>
        /// Initializes a new instance of the Student class with a default name.
        /// </summary>
        #endregion

        // Creates a student with a default name
        public Student()
        {
            #region Step 1: Set Default Name
            Name = "Unknown";
            #endregion
        }

        #region Parameterized Constructor Documentation
        /// <summary>
        /// Initializes a new instance of the Student class with the specified name.
        /// </summary>
        /// <param name="name">The name of the student.</param>
        #endregion

        // Creates a student with a given name
        public Student(string name)
        {
            #region Step 1: Set Name
            Name = name;
            #endregion
        }

        #region Notify Documentation
        /// <summary>
        /// Displays a notification message for the student.
        /// </summary>
        /// <param name="message">The message to display.</param>
        #endregion

        // Notifies the student with a message
        public void Notify(string message)
        {
            #region Step 1: Display Notification
            Console.WriteLine($"{Name} notified: {message}");
            #endregion
        }
    }
}