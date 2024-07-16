using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.ClassControl
{
    public class LogError
    {
        string path = "C:\\ErrorLog\\Log.txt";
        public void NewError(string str,string fn)
        {
            if (!File.Exists(path))
            {
                DirectoryInfo di = Directory.CreateDirectory("C:\\ErrorLog");
                using (StreamWriter tw = File.CreateText(path))
                {
                    tw.WriteLine(" ---| Function = " + fn);
                    tw.WriteLine(" |______  " + str + " -" + DateTime.Now.ToString());
                }
            }
            else {
                using (StreamWriter tw = File.AppendText(path))
                {
                    tw.WriteLine(" ---| Function = " + fn);
                    tw.WriteLine(" |______  "+str +" -" +DateTime.Now.ToString());
                }
            }
        }
    }
}
