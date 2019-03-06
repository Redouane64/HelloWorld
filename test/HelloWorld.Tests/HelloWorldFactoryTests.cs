using System;
using HelloWorld.Core;
using Xunit;

namespace HelloWorld.Tests
{
    public class HelloWorldFactoryTests
    {
        [Fact]
        public void CreateFactoryThatWrapsHelloWorldMessage()
        {
            var factory = new HelloWorldFactory();
            var hw = factory.Create();

            Assert.IsType<HelloWorld.Core.HelloWorld>(hw);

            var expected = "Hello, World";
            Assert.Equal(expected, hw.Message);
        }
    }
}
