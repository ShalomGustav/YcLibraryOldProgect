using System;

namespace YcLibrary.Exceptions
{
    public class YcResponceException : Exception
    {
        public YcResponceException()
        {
        }

        public YcResponceException(string message) : base(message)
        {
        }

        public YcResponceException(string code, string description)
        {
            Description = description;
            Code = code;
        }

        public string Code { get; set; }
        public string Description { get; set; }
    }
}
