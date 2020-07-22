﻿using _09_StreamingContent_Console.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_StreamingContent_UIRefactorTests.UI
{
    public class MockConsole : IConsole

    {
        public Queue<string> UserInput;
        public string Output;
        public MockConsole(IEnumerable<string> input)
        {
            UserInput = new Queue<string>(input);
            Output = "";
        }

        public void Clear()
        {
            Output += "Called Clear Method\n";
            //Output = Output + "Called Clear Method\n"; ----> This is the same as the above; this is what the += operator creates
        }
        public ConsoleKeyInfo ReadKey()
        {
            return new ConsoleKeyInfo();
        }
        public string ReadLine()
        {
            return UserInput.Dequeue();
        }
        public void WriteLine(string s)
        {
            Output += s + "\n";
        }
        public void WriteLine(object o)
        {
            Output += o + "\n";
        }
    }
}
