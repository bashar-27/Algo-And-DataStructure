﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertShift
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
        
        public Node(int d) {
            this.Data =d;
            Next = null;
        }
    }
}
