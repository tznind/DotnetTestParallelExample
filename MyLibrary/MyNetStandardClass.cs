using System;
using System.Threading;

namespace MyLibrary
{
    public class MyNetStandardClass
    {
        public const string LogFile = @"c:\temp\output.txt";


        public void Sleep(int milliseconds = 3000)
        {
            Thread.Sleep(milliseconds);
        }
    }
}
