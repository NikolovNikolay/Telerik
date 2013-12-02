
namespace ADTQueue
{
    using System;
    using System.Collections.Generic;

    public class QueuedItem<T>
    {
        private T value;
        private QueuedItem<T> nextItem;

        public QueuedItem(T value)
        {
            this.value = value;
        }

        public T Value
        {
            get { return this.value; }
        }

        public QueuedItem<T> Next
        {
            get
            {
                return this.nextItem;
            }

            set
            {
                this.nextItem = value;
            }
        }
    }
}
