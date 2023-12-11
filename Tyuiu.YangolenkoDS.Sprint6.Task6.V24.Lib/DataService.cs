using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.YangolenkoDS.Sprint6.Task6.V24.Lib
{
    public class DataService : ISprint6Task6V24
    {

        public string CollectTextFromFile(string str, string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    resStr = resStr + " " + line.Split(' ')[0];
                }
            }
            return resStr;
        }
    }
}
