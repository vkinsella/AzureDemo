using NUnit;
using NUnit.Framework;
using AzureDemo;

namespace AzureDemo.Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public static void Test1()
        {
            //test1
            int ans = Program.Add(3, 5);
            Assert.That(ans, Is.EqualTo(8));



        }
        public static void Test2()
        {
            //test1
            int ans = Program.Add(3, 3);
            Assert.That(ans, Is.EqualTo(6));



        }
    }
    
}