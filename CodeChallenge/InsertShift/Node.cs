using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertShift
{
    public class Node
    {
        public int key;
        public int Data { get; set; }
        public Node Next { get; set; }
        // public Node root { get; set; }
        public string NewValue { get; set; }
        public Node left { get; set; }
        public Node right { get; set; }
        public List<Node> child { get; set; }
        
        public Node(int d) {
            Data =d;
            Next =left = right = null;
            child = new List<Node>();
        }
        public Node()
        {
            left =right=null;
            

        }

       
    }
}
