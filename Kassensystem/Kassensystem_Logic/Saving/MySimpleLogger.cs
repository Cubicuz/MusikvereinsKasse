using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassensystem_Logic.Saving
{
    class MySimpleLogger
    {
        const String pathToFile = @"c:\temp\logfile.txt";
        const String separator = ";";
        public static void log(String message)
        {
            try
            {
                using (StreamWriter w = File.AppendText(pathToFile))
                {
                    w.WriteLine(DateTime.Now + separator + message);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
