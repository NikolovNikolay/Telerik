
namespace PriorityQueueImplementation
{
    using System;
    using System.Linq;

    public class PriorityQueueEmptyException : ApplicationException
    {
        private const string message = "The selected queue is empty and dequeu operation can not be completed";

        public PriorityQueueEmptyException() : base(message)
        {
        }
    }
}
