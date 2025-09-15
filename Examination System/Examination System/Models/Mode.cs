namespace Examination_System.Models
{
    #region Mode Documentation
    /// <summary>
    /// Defines the possible states of an exam in the examination system.
    /// </summary>
    /// <remarks>
    /// Values: Queued (exam is pending), Starting (exam is in progress), Finished (exam is completed).
    /// </remarks>
    #endregion

    public enum Mode
    {
        Queued,
        Starting,
        Finished
    }
}