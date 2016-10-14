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
            string message = "Application started.";
            Log(message);
        }
        #endregion


        #region Methods
        /// <summary>
        /// Writes a given message to the log file.
        /// </summary>
        /// <param name="message">the message to write</param>
        public static void Log(string message)
        {
            string fullMessage = DateTime.Now.ToString() + " : " + message;

            StreamWriter file = null;

            try
            {
                file = new StreamWriter(AppPath, true);

                file.WriteLine(fullMessage);
            }

            #region Exceptions
            catch (DirectoryNotFoundException)
            {
                throw;
            }
            catch (PathTooLongException)
            {
                throw;
            }
            catch (IOException)
            {
                throw;
            }
            catch (ObjectDisposedException)
            {
                throw;
            }
            catch (UnauthorizedAccessException)
            {
                throw;
            }
            catch (ArgumentNullException)
            {
                throw;
            }
            catch (ArgumentException)
            {
                throw;
            }
            catch (System.Security.SecurityException)
            {
                throw;
            }
            catch (SystemException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            #endregion

            finally
            {
                file.Close();
            }           
        }
        #endregion

    }
}
