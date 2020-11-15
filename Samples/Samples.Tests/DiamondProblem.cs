using System;

using Samples.DefaultInterfaces.DiamondProblem;

using Xunit;

namespace Samples.Tests
{
    public class DiamondProblem
    {
        [Fact]
        public void Test()
        {
            A instanceA = new D();
            B instanceB = new D();
            C instanceC = new D();
            D instanceD = new D();
            

            Assert.Equal("D", instanceA.Method());
            Assert.Equal("D", instanceB.Method());
            Assert.Equal("D", instanceC.Method());
            Assert.Equal("D", instanceD.Method());


        }
    }
}
