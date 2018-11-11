using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3.Analyzers.Test.Extensions
{

    [TestClass]
    public class SyntaxTriviaListExtensionTest
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            var test = @"";
            Assert.IsTrue(1 == 1);
        }

    }
}
