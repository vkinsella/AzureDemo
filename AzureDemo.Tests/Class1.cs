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
            
            int ans = Program.Add(3, 5);
            Assert.That(ans, Is.EqualTo(8));



        }

    }
    
}