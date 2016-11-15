using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;

namespace HelloWorldTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Produto p = new Produto("Sabao", 10.0m);
            Assert.IsTrue(p.Nome == "Sabao");
            Assert.IsTrue(p.Preco == 10.0m);
        }
    }
}
