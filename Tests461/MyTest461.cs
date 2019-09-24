using MyLibrary;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
[assembly: LevelOfParallelism(1)]
[assembly: NonParallelizable]

namespace Tests461
{
    [NonParallelizable]
    [TestFixture]
    public class MyTest461
    {
        [SetUp]
        public void SetUp()
        {
            File.AppendAllText(MyNetStandardClass.LogFile, "461 SetUp " + Environment.TickCount + Environment.NewLine);
        }

        [Test]
        public void Test461()
        {
            File.AppendAllText(MyNetStandardClass.LogFile, "461 Enter Test " + Environment.TickCount + Environment.NewLine);

            var c = new MyNetStandardClass();
            c.Sleep();

            File.AppendAllText(MyNetStandardClass.LogFile, "461 Exit Test " + Environment.TickCount + Environment.NewLine);

            Assert.Pass();
        }
    }
}
