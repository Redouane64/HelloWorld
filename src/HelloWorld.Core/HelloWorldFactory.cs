using System;

namespace HelloWorld.Core
{
    public class HelloWorldFactory : IGreetsFactory
    {
        public IGreet Create() => new HelloWorld();
    }
}
