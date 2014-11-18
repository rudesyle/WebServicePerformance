﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceClass
{
    public class Person
    {
        public Person()
        {
            Id = 10;
            Name = "Rick";
            Entered = DateTime.Now;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Entered { get; set; }
    }
}
