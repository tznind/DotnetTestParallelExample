using MyLibrary;
using NUnit.Framework;
using System;
using System.IO;
[assembly: LevelOfParallelism(1)]
[assembly: NonParallelizable]

namespace TestsCore2
{
    [NonParallelizable]
    [TestFixture]
    public class MyTestsCore
    {
        [SetUp]
        public void SetUp()
        {
            File.AppendAllText(MyNetStandardClass.LogFile, "Core SetUp " + Environment.TickCount + Environment.NewLine);
        }

        [Test]
        public void TestCore()
        {
            File.AppendAllText(MyNetStandardClass.LogFile, "Core Enter Test " + Environment.TickCount + Environment.NewLine);

            var c = new MyNetStandardClass();
            c.Sleep();

            File.AppendAllText(MyNetStandardClass.LogFile, "Core Exit Test " + Environment.TickCount + Environment.NewLine);

            Assert.Pass();
        }
    }
}
