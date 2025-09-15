namespace Examination_System.Models
{
    #region Subject Documentation
    /// <summary>
    /// Represents a subject in the examination system, associated with a list of students.
    /// </summary>
    #endregion

    public class Subject
    {
        #region Name Documentation
        /// <summary>
        /// Gets the name of the subject.
        /// </summary> 
        #endregion

        public string Name { get; private set; }

        #region Students Documentation
        /// <summary>
        /// Gets the list of students enrolled in the subject.
        /// </summary> 
        #endregion

        public List<Student> Students { get; private set; } = new List<Student>();

        #region Constructor Documentation
        /// <summary>
        /// Initializes a new instance of the Subject class with the specified name.
        /// </summary>
        /// <param name="name">The name of the subject.</param>
        #endregion

        // Creates a subject with a given name
        public Subject(string name)
        {
            #region Step 1: Set Name
            Name = name;
            #endregion
        }

        #region AddStudent Documentation
        /// <summary>
        /// Adds a student to the subject's student list.
        /// </summary>
        /// <param name="student">The student to add.</param>
        #endregion

        // Adds a student to the subject
        public void AddStudent(Student student)
        {
            #region Step 1: Add Student
            Students.Add(student);
            #endregion
        }
    }
}