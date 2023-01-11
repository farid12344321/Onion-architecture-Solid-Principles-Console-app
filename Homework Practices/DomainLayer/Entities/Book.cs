﻿using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class Book :BaseEntitiy
    {
        public string Name { get; set; }
        public string Author  { get; set; }
       public int MyProperty { get; set; }
    }
}
