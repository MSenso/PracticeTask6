using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeTask6;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Form1 form = new Form1();
            form.buf[0] = 1;
            form.buf[1] = 2;
            form.buf[2] = 3;
            form.m = 10;
            form.Calculating();

            form.buf[0] = 1;
            form.buf[1] = 2;
            form.buf[2] = 3;
            form.m = -10;
            form.Calculating();

            form.buf[0] = 1;
            form.buf[1] = 0;
            form.buf[2] = 1;
            form.m = 100;
            form.Calculating();

            form.buf[0] = 0;
            form.buf[1] = 0;
            form.buf[2] = 1;
            form.m = 1;
            form.Calculating();

            form.buf[0] = 0;
            form.buf[1] = 0;
            form.buf[2] = 1;
            form.m = 0;
            form.Calculating();

            form.buf[0] = 0;
            form.buf[1] = 0;
            form.buf[2] = 0;
            form.m = 0;
            form.Calculating();

            form.buf[0] = 1;
            form.buf[1] = 2;
            form.buf[2] = 3;
            form.m = 164;
            form.Calculating();
        }
    }
}
