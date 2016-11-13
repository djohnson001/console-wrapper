using System;

namespace console_wrapper
{
    public interface IConsoleWrapper
    {
        void Clear();

        void Write(string format, params object[] arg);

        void WriteLine();
        void WriteLine(string format, params object[] arg);

        ConsoleKeyInfo ReadKey();
        ConsoleKeyInfo ReadKey(bool intercept);

        string Title { get; set; }

        ConsoleColor ForegroundColor { get; set; }
        ConsoleColor BackgroundColor { get; set; }

        void SetCursorPosition(int left, int top);
    }
}
