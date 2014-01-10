﻿
namespace TreeOfNNodes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Node<T>
    {
        public T Value { get; set; }

        public List<Node<T>> Children { get; set; }

        public bool HasParent { get; set; }
        public bool Marked { get; set; }
        public bool IsRoot { get; set; }

        public Node(T value)
        {
            this.Value = value;
            this.Children = new List<Node<T>>();
            this.HasParent = false;
            this.Marked = false;
            this.IsRoot = false;
        }
    }
}
