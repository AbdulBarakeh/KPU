using NUnit.Framework;
using CprDLLShared;
using System.Diagnostics;

namespace CprCheck_Test
{
    public class Tests
    {
        public CprCheck Checker = new CprCheck();
        string CprTest = "0609240121";
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Format()
        {
            var res = Checker.CheckFormat(CprTest);
            Assert.That(res == CprCheck.CprError.NoError);
        }

        [Test]
        public void Date()
        {
            var res = Checker.CheckDate(CprTest);
            Assert.That(res == CprCheck.CprError.NoError);
        }

        [Test]
        public void Check11()
        {
            var res = Checker.Check11Test(CprTest);
            Assert.That(res == CprCheck.CprError.NoError);
        }
    }
}