namespace DataAccess
{

    #region Usings
    using System;
    using Entities;
    using System.IO;
    #endregion

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
            AppPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");
            // sets the appPath field to the path of the log file.
            string m = "";
            Log(m);
        }
        #endregion


        #region Methods
        /// <summary>
        /// Writes a given message to the log file.
        /// </summary>
        /// <param name="message">the message to write</param>
        public static void Log(string message)
        {
            string m = DateTime.Now.ToString() + " : Application started.";

            StreamWriter file = null;

            try
            {
                file = new StreamWriter(AppPath, true);

                file.WriteLine(m);
            }
            catch(IOException)
            {
                throw;
            }
            finally
            {
                file.Close();
            }           
        }
        #endregion

    }
}
