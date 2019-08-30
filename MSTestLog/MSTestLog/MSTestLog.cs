using System;
using System.IO;
using System.Text;

namespace MSTestTool
{
    public class MSTestLog
    {
        private static StringBuilder _testOutputBuilder;
        private static StringWriter _testOutputWriter;
        private static TextWriter _originalWriter;

        /// <summary>
        /// 初始化
        /// </summary>
        public static void Initialize()
        {
            _testOutputBuilder = new StringBuilder();
            _testOutputWriter = new StringWriter(_testOutputBuilder);
            _originalWriter = Console.Out;
            Console.SetOut(_testOutputWriter);
        }

        public static string WriteLine(string msg)
        {
            string ret_ = writeLine(_originalWriter, msg);

            Console.SetOut(_originalWriter);
            _testOutputWriter.Dispose();

            return ret_;
        }

        private static string writeLine(TextWriter textWriter, string errorMessage)
        {
            textWriter.WriteLine(errorMessage);
            return errorMessage;
        }
    }
}
