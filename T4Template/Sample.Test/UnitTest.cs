using System;
using Xunit;

namespace Sample.Test
{
    public class CustomerTest
    {
        [Fact]
        public void Equals���s����Id�v���p�e�B��Equals�����s����邱��()
        {
            var customer1 = new Customer {Id = 1};
            var customer2 = new Customer {Id = 1};
            Assert.True(customer1.Equals(customer2));
        }
    }

    public class EmployeeTest
    {
        [Fact]
        public void Equals���s����Id�v���p�e�B��Equals�����s����邱��()
        {
            var employee1 = new Employee { Id = 1 };
            var employee2 = new Employee { Id = 1 };
            Assert.True(employee1.Equals(employee2));
        }
    }
}
