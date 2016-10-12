namespace DataAccess
{

    using System;
    using Entities;
    using System.IO;

    /// <summary>
    /// A static class for logging.
    /// </summary>
    public static class Logger
    {

        #region Fields
        /// <summary>
        /// The path to the app.
        /// </summary>
        private static readonly string AppPath;
        #endregion


        #region Constructors
        /// <summary>
        /// Creates this class.
        /// </summary>
        static Logger()
        {
            AppPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "test.txt");
            // sets the appPath field to the path of the log file.
        }
        #endregion


        #region Methods
        /// <summary>
        /// Writes a given message to the log file.
        /// </summary>
        /// <param name="message">the message to write</param>
        public static void Log(string message)
        {
            StreamWriter file = new StreamWriter(AppPath, true);

            try
            {                
                file.WriteLine(message);
            }
            catch(IOException ex)
            {
                throw ex;
            }
            finally
            {
                file.Close();
            }           
        }
        #endregion

    }
}
