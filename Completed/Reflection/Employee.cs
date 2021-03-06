﻿using Commons;
using Reflection.Metaprogramming;

namespace Reflection
{
    public class Employee
    {
        [Identifier]
        public int Id { get; set; }

        public override bool Equals(object obj)
            => Equals<Employee>.Invoke(this, obj);
    }
}
