using System;
using System.Linq;

namespace _3.OutOfRangeException
{
    class InvalidRangeException<T> : Exception
    {
        private const string message = "Not in range.";

        public InvalidRangeException(T start, T end, Exception innerException = null)
            : base(message, innerException)
        {
            this.start = start;
            this.end = end;
        }

        public T start { get; set; }
        public T end { get; set; }
    }
}
