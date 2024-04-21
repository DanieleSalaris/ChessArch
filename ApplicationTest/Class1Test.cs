using Application;
using NUnit.Framework;

namespace ApplicationTest
{
    [TestFixture]
    public class Class1Test
    {
        [Test]
        public void Test1()
        {
            int initField = 10;
            var cut = new Class1(initField);
            Assert.That(cut.Property, Is.EqualTo(initField));
        }

    }
}
