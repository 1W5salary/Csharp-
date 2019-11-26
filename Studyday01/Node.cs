using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    public class Node
    {
        public Node previous { get; set; }
        public Node next { get; set; }
        public int value { get; set; }

        public Node(int value) {
            value = this.value;
        }
        public Node() { }
    }
}
