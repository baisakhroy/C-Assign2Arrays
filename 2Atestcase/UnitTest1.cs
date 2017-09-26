using System;
using Xunit;
using C_assignment2_a;
namespace _2Atestcase
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
Arr x = new Arr();

int k = x.initialize(5);

    Assert.IsType<int>(k);
            Assert.Equal(3,k);
        }
    }
}
