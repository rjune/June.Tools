using System.Diagnostics;

namespace June.Tools.Functional
{
    /// <summary>Error when a method that returns <see cref="Result"/> fails.</summary>
    [DebuggerDisplay("{Message}")]
    public class Error
    {
        /// <summary>Error message indicating why the method failed.</summary>
        public string Message { get; set; }

        /// <summary>
        /// Create a new Error with <paramref name="message"/>
        /// </summary>
        /// <param name="message"></param>
        public Error(string message)
        {
            Message = message;
        }

        /// <summary>
        /// Returns only the <see cref="Message"/> property
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Message;
        }
    }
}
