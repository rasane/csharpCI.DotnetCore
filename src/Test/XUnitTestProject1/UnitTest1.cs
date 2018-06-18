using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var classUnderTest = new ClassLibrary1.Class1();
            var returnValue = classUnderTest.Method("Jim");
            //Assert
            Assert.Equal("Hello Jim", returnValue);
        }
    }
}
