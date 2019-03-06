using System;

namespace HelloWorld.Core
{
    public class HelloWorld : IGreet
    {
        public HelloWorld()
        {
            Message = "Hello, World";
        }

        public string Message { get; }
    }
}
