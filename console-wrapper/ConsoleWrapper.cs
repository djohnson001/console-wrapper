using System;

namespace console_wrapper
{
    public class ConsoleWrapper : IConsoleWrapper
    {
        public void Clear()
        {
            Console.Clear();
        }

        public ConsoleColor ForegroundColor
        {
            get { return Console.ForegroundColor; }
            set { Console.ForegroundColor = value; }
        }

        public ConsoleColor BackgroundColor
        {
            get { return Console.BackgroundColor; }
            set { Console.BackgroundColor = value; }
        }

        public void Write(string format, params object[] arg)
        {
            Console.Write(format ?? string.Empty, arg);
        }

        public void WriteLine()
        {
            Console.WriteLine(string.Empty);
        }

        public void WriteLine(string format, params object[] arg)
        {
            Console.WriteLine(format ?? string.Empty, arg);
        }

        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }

        public ConsoleKeyInfo ReadKey(bool intercept)
        {
            return Console.ReadKey(intercept);
        }

        public void SetCursorPosition(int left, int top)
        {
            Console.SetCursorPosition(left, top);
        }

        public string Title
        {
            get { return Console.Title; }
            set { Console.Title = value; }
        }
    }
}
