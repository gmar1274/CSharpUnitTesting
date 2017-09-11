using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.Tests
{
    [TestClass()]
    public class MainWindowTests
    {
        [TestMethod()]
        public void testEscapeKeysTest()
        {
            MainWindow mw = new MainWindow();
            try
            {
                mw.testEscapeKeys("testing");
            }catch(Exception e)
            {
                StringAssert.Contains(e.Message, "Escape keys found");

                return;
            }
                Assert.Fail("Nothing wrong");
        }
    }
}