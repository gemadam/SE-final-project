
namespace QuickFlattener.Logging
{
    /// <summary>
    /// General interface of logger.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Method logs the message.
        /// </summary>
        /// <param name="message">Message to be logged.</param>
        void Log(string message);
    }
}