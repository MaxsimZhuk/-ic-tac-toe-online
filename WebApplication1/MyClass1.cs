using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class MyClass1
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}";
        }
    }
}