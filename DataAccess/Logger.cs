using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.IO;

namespace DataAccess
{
    public static class Logger
    {

        private static readonly string AppPath;


        static Logger()
        {
            AppPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "test.txt");
        }

        public static void Log(string message)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(AppPath, true);

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
        
        
    }
}
