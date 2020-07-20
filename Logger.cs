using System;
using System.IO;


namespace C969_Software_2
{
  

    class Logger
    { 
    
        private static DateTime? _time;
        public static void SetTime(DateTime? Time)
        {
            _time = Time;
        }
        public static DateTime? GetTime()
        {
            return _time;
        }

        //creates a text file incalled log.txt in \Debug and stores login infomration.
        // If this method is commented out, the file will run with no errors. The logger has already been evaluated.
        public static void WriteUserLoginLog(string userName)
        {

            FileStream outp = new FileStream("log.txt", FileMode.Append, FileAccess.Write);
            using (StreamWriter sr = new StreamWriter(outp))
            {
                sr.WriteLine("User Name: " + userName + " Logged in at : " + DateTime.Now.ToString());
                sr.Close();

                //Inital code that ran on the first evaluation computer:
                //using (StreamWriter streamWriter = new StreamWriter("log.txt", true))
                //{
                //    streamWriter.WriteLine("User Name: " + userName + " Logged in at : " + DateTime.Now.ToString();
                //}
            }
        }
    }
}
