using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleThreadTest
{
    public class CSVtoTXT : ContextBoundObject
    {
        private static readonly object _syncRoot = new object();
        public static void DoConvert(string filePath)
        {
            lock ( _syncRoot )
            {
                string temp = String.Empty;
                using(StreamReader fileReadStream = new StreamReader(path: filePath, encoding: Encoding.Default))
                {
                    using(StreamWriter fileStreamWriter = new StreamWriter(path: @"D:\students.txt"))
                    {
                        while(!fileReadStream.EndOfStream)
                        {
                            temp = fileReadStream.ReadLine();
                            string someData = temp.Replace(oldChar: ';', newChar: ' ');
                            fileStreamWriter.WriteLine(someData);
                        }
                    }
                }
            }
        }
    }
}
